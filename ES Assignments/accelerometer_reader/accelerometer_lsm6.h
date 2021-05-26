#ifndef ACCELEROMETER_LSM6_H
#define ACCELEROMETER_LSM6_H

#include "accelerometer.h"

void accelerometer_lsm6_begin();
void accelerometer_lsm6_set_measurement_mode();
void accelerometer_lsm6_measure(accelerometer_data* data);
int accelerometer_lsm6_get_x();
int accelerometer_lsm6_get_y();
int accelerometer_lsm6_get_z();

#endif
