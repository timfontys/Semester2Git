#include "skater.h"
#include "terminal_io.h"

// leave resource_detector.h as last include!
#include "resource_detector.h"

int showSkaters(void)
{
    for (int i = 0; i < 8; i++)
    {
        printf("\n Name:  %d", skater[i].name);
        printf("\n Nationality: %d", skater[i].nationality);
        printf("\n 500m Time: %d", skater[i].fiveHundredMetersTime);
        printf("\n 1500m Time: %d", skater[i].thousandFiveHundredMetersTime);
        printf("\n 5km Time: %d", skater[i].fiveKilometersTime);
        printf("\n 10km Time: %d", skater[i].tenKilometersTime);
    }
    return 1;
}

int addSkater(int skaterId)
{
    char name[250];
    char nationality[250];
    int fiveHundredMetersTime = getInt("Time of the 500 meter sprint");
    int thousandFiveHundredMetersTime = getInt("Time of the 1500 meter sprint");
    int fiveKilometersTime = getInt("Time of the 5 kilometer sprint");
    int tenKilometersTime = getInt("Time of the 10 kilometer sprint");
    getStr("Name of skater:", name, 250);
    getStr("Name of skater:", nationality, 250);
    strCopy(skater[skaterId].name, name);
    skater[skaterId].nationality = nationality;
    skater[skaterId].fiveHundredMetersTime = fiveHundredMetersTime;
    skater[skaterId].thousandFiveHundredMetersTime = thousandFiveHundredMetersTime;
    skater[skaterId].fiveKilometersTime = fiveKilometersTime;
    skater[skaterId].tenKilometersTime = tenKilometersTime;
}

int removeSkater(int skaterId)
{
    int removingSkater = 0;
    for (int i = 0; i < 8; i++)
    {
        if (i == skaterId)
        {
            removingSkater++;
        }
        skater[i] = skater[i + removingSkater];
    }
    if (removingSkater == 1)
    {
        strCopy(skater[7].name, "");
        skater[7].nationality = Empty;
        skater[7].fiveHundredMetersTime = 0;
        skater[7].thousandFiveHundredMetersTime = 0;
        skater[7].fiveKilometersTime = 0;
        skater[7].tenKilometersTime = 0;
        return 1;
    }
    else
    {
        return 0;
    }
}

int addTime(void)
{
    int distanceChoise = getInt("Pick the number you want to change: \n [1] 500m \n [2] 1500m \n [3] 5km \n [4] 10km");
    int skaterId = getInt("Enter the skater ID");
    int newTime = getInt("Enter new time");
    switch (distanceChoise)
    {
    case 1:
        if (skater[skaterId].fiveHundredMetersTime < newTime)
        {
            if (1 == getInt("Time is higher then old time, if you still want to change it press [1] else press [2]"))
            {
                skater[skaterId].fiveHundredMetersTime = newTime;
                return 0;
            }
            else
            {
                return -1;
            }
        }
        skater[skaterId].fiveHundredMetersTime = newTime;
        return 0;
        break;

    case 2:
        if (skater[skaterId].thousandFiveHundredMetersTime < newTime)
        {
            if (1 == getInt("Time is higher then old time, if you still want to change it press [1] else press [2]"))
            {
                skater[skaterId].thousandFiveHundredMetersTime = newTime;
                return 0;
            }
            else
            {
                return -1;
            }
        }
        skater[skaterId].thousandFiveHundredMetersTime = newTime;
        return 0;
        break;

    case 3:
        if (skater[skaterId].fiveKilometersTime < newTime)
        {
            if (1 == getInt("Time is higher then old time, if you still want to change it press [1] else press [2]"))
            {
                skater[skaterId].fiveKilometersTime = newTime;
                return 0;
            }
            else
            {
                return -1;
            }
        }
        skater[skaterId].fiveKilometersTime = newTime;
        return 0;
        break;

    case 4:
        if (skater[skaterId].tenKilometersTime < newTime)
        {
            if (1 == getInt("Time is higher then old time, if you still want to change it press [1] else press [2]"))
            {
                skater[skaterId].tenKilometersTime = newTime;
                return 0;
            }
            else
            {
                return -1;
            }
        }
        skater[skaterId].tenKilometersTime = newTime;
        return 0;
        break;

    default:
        printf("Something went wrong please try again");
        addTime();
    }
}

int showClassification(void)
{
    int distanceChoise = getInt("Pick the number you want to see the fastest time of: \n [1] 500m \n [2] 1500m \n 5km \n 10km");
    int timeArray[7];
    for (int i; i < 8; i++)
    {
        timeArray[i] = skater[i].fiveHundredMetersTime;
    }
    switch (distanceChoise)
    {
    case 1:
        for (int i; i < 8; i++)
        {
            timeArray[i] = skater[i].fiveHundredMetersTime;
        }
        return 0;
        break;
    case 2:
        for (int i; i < 8; i++)
        {
            timeArray[i] = skater[i].fiveHundredMetersTime;
        }
        return 0;
        break;
    case 3:
        for (int i; i < 8; i++)
        {
            timeArray[i] = skater[i].fiveHundredMetersTime;
        }
        return 0;
        break;
    case 4:
        for (int i; i < 8; i++)
        {
            timeArray[i] = skater[i].fiveHundredMetersTime;
        }
        return 0;
        break;
    default:
        printf("Something went wrong please try again");
    }
    int size = sizeof(timeArray) / sizeof(timeArray[0]);
    selectionSort(timeArray, size);
    printf("\n From fastest to slowest time: \n");
    printArray(timeArray, size);
    return 0;
}

int showFinalClassification(void) 
{
    int averageTime[7];

    for (int i = 0; i < 8; i++) 
    {
        if (skater[i].fiveHundredMetersTime <= 0 || skater[i].thousandFiveHundredMetersTime <= 0 || skater[i].fiveKilometersTime <= 0 || skater[i].tenKilometersTime <= 0) 
        {
            averageTime[i] = 0;
        }
        else 
        {
            averageTime[i] = (skater[i].fiveHundredMetersTime + skater[i].thousandFiveHundredMetersTime + skater[i].fiveKilometersTime + skater[i].tenKilometersTime) / 4;
        }
    }
    int size = sizeof(averageTime) / sizeof(averageTime[0]);
    selectionSort(averageTime, size);
    printf("\n From fastest to slowest average time: \n");
    
    for (int j = 0; j < 8; j++) 
    {
        if (averageTime[j] == 0) 
        {
            printf("\nThis skater didnt complete all the races yet \n");
        }
        else 
        {
            printf("%d", averageTime[j]);
        }
    }
    return 0;
}
