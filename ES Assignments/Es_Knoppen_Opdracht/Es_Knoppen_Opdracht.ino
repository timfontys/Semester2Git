int ledPin = 7;

enum
{
  ledAan,
  ledUit,
  onTimer
} knoppenStates;

enum
{
  geenEvent,
  knop1InGedrukt,
  knop2InGedrukt,
  knop3InGedrukt,
  timerRanOut
} knoppenEvents;
unsigned long eindTijd;
unsigned long currentMillis;
unsigned long currentMillisAnalog;
int analogVal;
unsigned long lastAnalogRead = 0;


void setup() {
  Serial.begin(9600);
  pinMode(A0, INPUT);
  pinMode(ledPin, OUTPUT);
}




void CheckForNewEvent(void)
{
  if (knoppenEvents == onTimer && eindTijd < millis())
  {
    knoppenEvents = timerRanOut;
  }
  currentMillisAnalog = millis();
  if (currentMillisAnalog - lastAnalogRead > 100) {
    analogVal = analogRead(A0);
    lastAnalogRead = millis();
  }

  if (420 < analogVal && analogVal < 430) {
    knoppenEvents = knop1InGedrukt;
  }
  else if (310 < analogVal && analogVal < 320) {
    knoppenEvents = knop2InGedrukt;
    
  }
  else if (165 < analogVal && analogVal < 175) {
    knoppenEvents = knop3InGedrukt;
  
  }
}

void TienSecAan() {
  digitalWrite(ledPin, HIGH);
  eindTijd = millis() + 10000;
}

void ZestigSecAan() {
  digitalWrite(ledPin, HIGH);
  eindTijd = millis() + 60000;
}


void loop() {

  CheckForNewEvent();

  switch (knoppenEvents)
  {
    case knop1InGedrukt:
      if (knoppenStates == ledAan || knoppenStates == onTimer)
      {
        digitalWrite(ledPin, LOW);
        knoppenStates = ledUit;
      }
      else
      {
        digitalWrite(ledPin, HIGH);
        knoppenStates = ledAan;
      }
      knoppenEvents = geenEvent;
      break;
    case knop2InGedrukt:
      TienSecAan();
      knoppenStates = onTimer;
      knoppenEvents = geenEvent;
      break;
    case knop3InGedrukt:
      ZestigSecAan();
      knoppenStates = onTimer;
      knoppenEvents = geenEvent;
      break;
    case timerRanOut:
      break;
    default:
      break;
  }

}
