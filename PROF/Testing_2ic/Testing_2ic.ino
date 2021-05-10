#include <Wire.h>
#include <ESP8266WiFi.h>
#include <PubSubClient.h>

char* ssid = "AndroidAPB0A5"; // Enter your WiFi name
const char* password =  "xavz8527"; // Enter WiFi password
const char* mqttServer = "77.169.159.14";
const int mqttPort = 1883;
const char* mqttUser = "pi";
const char* mqttPassword = "raspberry";

WiFiClient espClient;
PubSubClient client(espClient);

unsigned char ok_flag;
unsigned char fail_flag;

unsigned short lenth_val = 0;
unsigned char i2c_rx_buf[16];
unsigned char dirsend_flag = 0;

enum States
{
  noSensorsActivated,
  sensor1ActivatedFirst,
  sensor2ActivatedFirst,
  waitingLateSensorDeActivated
} sensorStates;

int serial_putc( char c, struct __file * )
{
  Serial.write( c );
  return c;
}

void printf_begin(void)
{
  //fdevopen( &serial_putc, 0 );
}

void setup() {
  Wire.begin();
  Serial.begin(9600, SERIAL_8N1);
  printf_begin();
  WiFi.begin(ssid, password);
  while (WiFi.status() != WL_CONNECTED) {
    delay(500);
    Serial.println("Connecting to WiFi..");
  }
  Serial.println("Connected to the WiFi network");

  client.setServer(mqttServer, mqttPort);
  client.setCallback(callback);

  while (!client.connected()) {
    Serial.println("Connecting to MQTT...");

    if (client.connect("ESP8266Client", mqttUser, mqttPassword )) {

      Serial.println("connected");
    }
    else {
      Serial.print("failed with state ");
      Serial.print(client.state());
      delay(2000);
    }
  }
}

void callback(char* topic, byte* payload, unsigned int length) {

  Serial.print("Message arrived in topic: ");
  Serial.println(topic);

  Serial.print("Message:");
  for (int i = 0; i < length; i++) {
    Serial.print((char)payload[i]);
  }

  Serial.println();
  Serial.println("-----------------------");

}


void SensorRead(unsigned char addr, unsigned char* datbuf, unsigned char cnt, bool sensorRead)
{
  unsigned short result = 0;
  // step 1: instruct sensor to read echoes
  if (sensorRead)
  {
    Wire.beginTransmission(50);
  }
  else
  {
    Wire.beginTransmission(82);
  }
  // transmit to device #82 (0x52)
  // the address specified in the datasheet is 164 (0xa4)
  // but i2c adressing uses the high 7 bits so it's 82
  Wire.write(byte(addr));      // sets distance data address (addr)
  Wire.endTransmission();      // stop transmitting
  // step 2: wait for readings to happen
  delay(1);                   // datasheet suggests at least 30uS
  // step 3: request reading from sensor
  if (sensorRead)
  {
    Wire.requestFrom(50, cnt);
  }
  else
  {
    Wire.requestFrom(82, cnt);
  }// request cnt bytes from slave device #82 (0x52)
  // step 5: receive reading from sensor
  if (cnt <= Wire.available()) { // if two bytes were received
    *datbuf++ = Wire.read();  // receive high byte (overwrites previous reading)
    *datbuf++ = Wire.read(); // receive low byte as lower 8 bits
  }
}

int ReadDistance()
{
  static int people = 0;
  static bool sensor1Read = false;
  static int sensorActivatedFirst = 0;
  if (sensor1Read)
  {
    sensor1Read = false;
//    Serial.println("Sensor1: ");
//    Serial.print(lenth_val);
  }
  else
  {
    sensor1Read = true;
//    Serial.println("Sensor2: ");
//    Serial.print(lenth_val);
  }
  SensorRead(0x00, i2c_rx_buf, 2, sensor1Read);
  lenth_val = i2c_rx_buf[0];
  lenth_val = lenth_val << 8;
  lenth_val |= i2c_rx_buf[1];
  int val = lenth_val;
  if (val <= 1500)
  {
    switch (sensorStates)
    {
      case noSensorsActivated:
        if (sensor1Read)
        {
          sensorStates = sensor1ActivatedFirst;
          sensorActivatedFirst = 1;
        }
        else
        {
          sensorStates = sensor2ActivatedFirst;
          sensorActivatedFirst = 2;
        }
        break;
      case sensor1ActivatedFirst:
        if (!sensor1Read)
        {
          sensorStates = waitingLateSensorDeActivated;
        }
        break;
      case sensor2ActivatedFirst:
        if (sensor1Read)
        {
          sensorStates = waitingLateSensorDeActivated;
        }
        break;
      default:
        break;
    }
  }
  else if (sensorStates == waitingLateSensorDeActivated)
  {
    switch (sensorActivatedFirst)
    {
      case 1:
        people++;
        break;
      case 2:
        people--;
      default:
        break;
    }
    sensorStates = noSensorsActivated;
    sensorActivatedFirst = 0;
    if (people < 0) { people = 0;}
    String message = "554,4," + String(people);
    Serial.println(people);
    client.publish("treinen/trein1",  message.c_str(), true);
  }
  delay(50);
 // Serial.println(sensorStates);
  return people;
}



void loop() {
  int x = ReadDistance();
  client.loop();
}
