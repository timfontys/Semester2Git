#include <Arduino.h>

#include "accelerometer_simulator.h"
#include "raw_data.h"

long startTime = 0;
float randomAccelerationDeltaInMs2 = 0;

void accelerometer_simulator_begin()
{
  Serial.println("Initialised!");

  startTime = millis();
  randomSeed(startTime);

  const Measurement* measurement = raw_data_get_sample(0);

  randomAccelerationDeltaInMs2 =
    0.25 * measurement->accelerationInMs2 * random(-50, 51) / 100;
}

void accelerometer_simulator_set_measurement_mode()
{
  // Do nothing...
}

float lineareInterpolatie(float x, float x1, float x2, float y1, float y2)
{
  float y = y1 + ((y2 - y1) / (x2 - x1)) * (x - x1);
  return y;
}


void accelerometer_simulator_measure(accelerometer_data* data)
{
  static float speedInMs = 0;
  static float speedInKu = 0;
  static float accelerataionArray[250];
  static int currentIndex = 0;
  static float accelerationTimeArray[250];
  static long startTime80;
  static long startTime100;
  static long endTime120;

  float accelerationInMs2 = 0;

  int calculated_index = (millis() - startTime) /
                         RAW_DATA_TIME_BETWEEN_MEASURMENTS_IN_MS;
  int number_of_samples = raw_data_get_number_of_samples();

  if (calculated_index >= number_of_samples)
  {
    data->x = data->y = data->z = 0;
    return;
  }

  const Measurement* measurement = raw_data_get_sample(calculated_index);

  accelerationInMs2 = measurement->accelerationInMs2;
  accelerationInMs2 += randomAccelerationDeltaInMs2;
  accelerationInMs2;
  speedInMs = accelerationInMs2 * ((millis() - startTime) / 1000);
  speedInKu = speedInMs * 3.6;
  data->y = accelerationInMs2;
  data->z = 0;
  if (speedInKu <= 0)
  {
    data->x = 1;
  }
  else {
    data->x = speedInKu;
  }
  accelerataionArray[currentIndex] = speedInKu;
  accelerationTimeArray[currentIndex] = millis() - startTime;
  if (speedInKu > 80)
  {
    startTime80 = lineareInterpolatie(80, accelerataionArray[currentIndex], accelerataionArray[currentIndex - 1], accelerationTimeArray[currentIndex], accelerationTimeArray[currentIndex - 1]);
  }
  if (speedInKu > 100)
  {
    static bool printOnce = true;
    float endTime100 = lineareInterpolatie(100, accelerataionArray[currentIndex], accelerataionArray[currentIndex - 1], accelerationTimeArray[currentIndex], accelerationTimeArray[currentIndex - 1]);
    if (printOnce) {
      Serial.println(endTime100);
      startTime100 = endTime100;
      printOnce = false;
      Serial.println((100 / 3.6 ) * ((endTime100 / 1000) * (endTime100 / 1000)) / 2);
    }
  }
  if (speedInKu > 120)
  {
    static bool printOnce = true;
    endTime120 = lineareInterpolatie(100, accelerataionArray[currentIndex], accelerataionArray[currentIndex - 1], accelerationTimeArray[currentIndex], accelerationTimeArray[currentIndex - 1]);
    if (printOnce) {
      Serial.println(endTime120 - startTime80);
      printOnce = false;
    }
  }

  if (speedInKu > 200)
  {
    static bool printOnce = true;
    float endTime200 = lineareInterpolatie(200, accelerataionArray[currentIndex], accelerataionArray[currentIndex - 1], accelerationTimeArray[currentIndex], accelerationTimeArray[currentIndex - 1]);
    if (printOnce) {
      Serial.println(endTime200);
      Serial.println(endTime200 - startTime100);
      printOnce = false;
      Serial.println((100 / 3.6 ) * ((endTime200 / 1000) * (endTime200 / 1000)) / 2);
    }
  }
  currentIndex++;
}
