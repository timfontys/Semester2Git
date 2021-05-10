#include "watch_registers.h"

// leave resource_detector.h as last include!
#include "resource_detector.h"

void watch_registers_toggle_config_is_paused(uint8_t *config)
{
    if (config != NULL)
    {
        *config ^= 1 << 3;
    }
}

void watch_registers_set_config_time_format(uint8_t *config, time_format format)
{
    if (config != NULL)
    {
        uint8_t tempConfig = *config;
        *config |= 1 << 0;
        switch (format)
        {
        case 0:
            *config ^= 1 << 0;
            break;
        case 1:
            *config ^= 0 << 0;
            break;
        default:
            printf("Error this should not happen");
            *config = tempConfig;
            break;
        }
    }
}

void watch_registers_set_config_time_update_interval(
    uint8_t *config, time_update_interval interval)
{
    if (config != NULL)
    {
        uint8_t tempConfig = *config;
        *config |= ((1 << 2) | (1 << 1));
        switch (interval)
        {
        case 0:
            *config ^= ((1 << 2) | (1 << 1));
            break;
        case 1:
            *config ^= ((1 << 2) | (0 << 1));
            break;
        case 2:
            *config ^= ((0 << 2) | (1 << 1));
            break;
        case 3:
            *config ^= ((0 << 2) | (0 << 1));
            break;
        default:
            printf("Error this should not happen");
            *config = tempConfig;
            break;
        }
    }
}

void watch_registers_get_config_settings(
    uint8_t config, bool *is_paused, time_format *format,
    time_update_interval *interval)
{
    if (is_paused != NULL && format != NULL && interval != NULL)
    {
        uint8_t tempConfig = 1 << 3;
        tempConfig &= config;
        if (tempConfig == 8)
        {
            *is_paused = true;
        }
        else
        {
            *is_paused = false;
        }
        tempConfig = 0;
        tempConfig = 1 << 0;
        tempConfig &= config;
        if (tempConfig == 1)
        {
            *format = 1;
        }
        else
        {
            *format = 0;
        }
        tempConfig = 0;
        tempConfig = ((1 << 2) | (1 << 1));
        tempConfig &= config;
        switch (tempConfig)
        {
        case 0:
            *interval = 0;
            break;
        case 2:
            *interval = 1;
            break;
        case 4:
            *interval = 2;
            break;
        case 6:
            *interval = 3;
            break;
        default:
            printf("Error this should not happen");
            break;
        }
    }
}

void watch_registers_set_time_hours(
    uint8_t *time_bits_low, uint8_t *time_bits_high, uint8_t hours)
{
    if (time_bits_low != NULL && time_bits_high != NULL)
        ;
    {
        uint8_t resetBit = 0xF;
        *time_bits_high &= resetBit;
        *time_bits_high |= hours << 4;
    }
}

void watch_registers_set_time_minutes(
    uint8_t *time_bits_low, uint8_t *time_bits_high, uint8_t minutes)
{
    if (time_bits_low != NULL && time_bits_high != NULL)
    {
        uint8_t resetBit = 0xF;
        *time_bits_high &= resetBit;
        resetBit = 0x3F;
        *time_bits_low &= resetBit;
        *time_bits_high |= minutes >> 2;
        *time_bits_low |= minutes << 6;
    }
}

void watch_registers_set_time_seconds(
    uint8_t *time_bits_low, uint8_t *time_bits_high, uint8_t seconds)
{
    if (time_bits_low != NULL && time_bits_high != NULL)
    {
        uint8_t resetBit = 0xC0;
        *time_bits_low &= resetBit;
        *time_bits_low |= seconds;
    }
}

void watch_registers_get_time(
    uint8_t time_bits_low, uint8_t time_bits_high, uint8_t *hours,
    uint8_t *minutes, uint8_t *seconds)
{
    if (hours != NULL && minutes != NULL && seconds != NULL)
    {
        *hours = time_bits_high >> 4;
        time_bits_high &= 0xF;
        *minutes = time_bits_high << 2 | time_bits_low >> 6;
        time_bits_low &= 0x3F;
        *seconds = time_bits_low;
    }
}

void watch_registers_set_date_year(
    uint8_t *date_bits_low, uint8_t *date_bits_high, uint8_t year)
{
    if (date_bits_low != NULL)
    {
        *date_bits_low &= 0x80;
        *date_bits_low |= year;
    }
}

void watch_registers_set_date_month(
    uint8_t *date_bits_low, uint8_t *date_bits_high, uint8_t month)
{
    if (date_bits_low != NULL && date_bits_high != NULL)
    {
        *date_bits_low &= 0x7F;
        *date_bits_high &= 0xF8;
        *date_bits_high |= month >> 1;   
        *date_bits_low |= month << 7;
    }
}

void watch_registers_set_date_day_of_month(
    uint8_t *date_bits_low, uint8_t *date_bits_high,
    uint8_t day_of_month)
{
    if (date_bits_high != NULL)
    {
        *date_bits_high &= 0x7;
        *date_bits_high |= day_of_month << 3;
    }
}

void watch_registers_get_date(
    uint8_t date_bits_low, uint8_t date_bits_high, uint8_t *year,
    uint8_t *month, uint8_t *day_of_month)
{
    if (month != NULL && year != NULL && day_of_month != NULL)
    {
        *day_of_month = date_bits_high >> 3;
        date_bits_high &= 0x7;
        *month = date_bits_high << 1 | date_bits_low >> 7;
        date_bits_low &= 0x7F;
        *year = date_bits_low;
    }
}
