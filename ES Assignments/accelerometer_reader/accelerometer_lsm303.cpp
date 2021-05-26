#include <Arduino.h>
#include <Wire.h>

#include "accelerometer_lsm303.h"

/*-------------------------------------------------------------*/
#include "lsm303d.h"
#define SENSOR_SLAVE_ADDRESS (LSM303D_DEVICE_ADDRESS)
/*-------------------------------------------------------------*/


void accelerometer_lsm303_begin()
{
  Wire.begin();
  delay(500);
}

void accelerometer_lsm303_set_measurement_mode()
{
  Wire.beginTransmission(SENSOR_SLAVE_ADDRESS);
  Wire.write(0x20);
  Wire.write(0b00010111);
  Wire.endTransmission(false);
}


int calculatingX()
{
  Wire.beginTransmission(SENSOR_SLAVE_ADDRESS);
  Wire.write(OUT_X_L_A);
  Wire.endTransmission(false);
  Wire.requestFrom(SENSOR_SLAVE_ADDRESS, 2);
  int value = Wire.read();
  return value;
}

int calculatingY()
{
  Wire.beginTransmission(SENSOR_SLAVE_ADDRESS);
  Wire.write(OUT_Y_L_A);
  Wire.endTransmission(false);
  Wire.requestFrom(SENSOR_SLAVE_ADDRESS, 2);
  int value = Wire.read();
  return value;
}

int calculatingZ()
{
  Wire.beginTransmission(SENSOR_SLAVE_ADDRESS);
  Wire.write(OUT_Z_L_A);
  Wire.endTransmission(false);
  Wire.requestFrom(SENSOR_SLAVE_ADDRESS, 2);
  int value = Wire.read();
  return value;
}


void accelerometer_lsm303_measure(accelerometer_data* data)
{
  data->x = calculatingX();
  data->y = calculatingY();
  data->z = calculatingZ();
}
