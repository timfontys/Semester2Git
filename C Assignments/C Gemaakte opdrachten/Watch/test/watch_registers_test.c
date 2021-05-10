#include <stdio.h>
#include <string.h>

#include "unity.h"
#include "unity_test_module.h"
#include "watch_registers.h"

// leave resource_detector.h as last include!
#include "resource_detector.h"

// I rather dislike keeping line numbers updated, so I made my own macro to
// ditch the line number
#define MY_RUN_TEST(func) RUN_TEST(func, 0)

void watch_setUp(void)
{
}

void watch_tearDown(void)
{
    // This is run after EACH test
}

void test_toggeling_pause_bit(void) 
{
    uint8_t config = 0;
    watch_registers_toggle_config_is_paused(&config);
    TEST_ASSERT_EQUAL(8, config); 
}

void test_set_config_time_format(void)
{
    uint8_t config = 0;
    watch_registers_set_config_time_format(&config, 1);
    TEST_ASSERT_EQUAL(1, config);
} 

void test_set_config_time_update_interval(void) 
{
    uint8_t config = 1;
    watch_registers_set_config_time_update_interval(&config, 3);
    TEST_ASSERT_EQUAL(7, config);
}

void test_get_config_settings(void) 
{
    uint8_t config = 9;
    bool is_paused; 
    time_format format;
    time_update_interval interval;
    watch_registers_get_config_settings(config, &is_paused, &format, &interval);
    TEST_ASSERT_EQUAL(1, format);
    TEST_ASSERT_TRUE(is_paused);
}

void test_setting_time_hours(void)
{
    const uint8_t hours = 0xA5;
    uint8_t time_bits_high = 0xA5;
    uint8_t time_bits_low = 0x5A;

    watch_registers_set_time_hours(&time_bits_low, &time_bits_high, hours);
    TEST_ASSERT_EQUAL_HEX8(0x55, time_bits_high);
    TEST_ASSERT_EQUAL_HEX8(0x5A, time_bits_low);
}

void test_get_time()
{
    const uint8_t hours = 11;
    const uint8_t minutes = 55;
    const uint8_t seconds = 42;
    uint8_t time_bits_low = 0;
    uint8_t time_bits_high = 0;

    watch_registers_set_time_seconds(&time_bits_low, &time_bits_high, seconds);
    watch_registers_set_time_minutes(&time_bits_low, &time_bits_high, minutes);
    watch_registers_set_time_hours(&time_bits_low, &time_bits_high, hours);

    uint8_t h;
    uint8_t m;
    uint8_t s;
    watch_registers_get_time(time_bits_low, time_bits_high, &h, &m, &s);
    TEST_ASSERT_EQUAL(hours, h);
    TEST_ASSERT_EQUAL(minutes, m);
    TEST_ASSERT_EQUAL(seconds, s);
}

void test_get_date()
{
    const uint8_t years = 50;
    const uint8_t month = 10;
    const uint8_t day_of_month = 20;
    uint8_t date_bits_low = 0;
    uint8_t date_bits_high = 0;

    watch_registers_set_date_day_of_month(&date_bits_low, &date_bits_high, day_of_month);
    watch_registers_set_date_month(&date_bits_low, &date_bits_high, month);
    watch_registers_set_date_year(&date_bits_low, &date_bits_high, years);

    uint8_t y;
    uint8_t m;
    uint8_t d;
    watch_registers_get_date(date_bits_low, date_bits_high, &y, &m, &d);
    TEST_ASSERT_EQUAL(years, y);
    TEST_ASSERT_EQUAL(month, m);
    TEST_ASSERT_EQUAL(day_of_month, d);
}

void run_watch_tests()
{
    UnityRegisterSetupTearDown( watch_setUp, watch_tearDown);

    MY_RUN_TEST(test_setting_time_hours);
    MY_RUN_TEST(test_get_time);
    MY_RUN_TEST(test_toggeling_pause_bit);
    MY_RUN_TEST(test_set_config_time_format);
    MY_RUN_TEST(test_set_config_time_update_interval);
    MY_RUN_TEST(test_get_config_settings);
    MY_RUN_TEST(test_get_date);

    UnityUnregisterSetupTearDown();
}
