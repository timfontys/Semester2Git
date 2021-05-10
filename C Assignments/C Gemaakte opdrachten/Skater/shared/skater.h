#ifndef SKATER_H
#define SKATER_H

typedef struct 
{
    char name[250];
    Nationality nationality;
    double fiveHundredMetersTime;
    double thousandFiveHundredMetersTime;
    double fiveKilometersTime;
    double tenKilometersTime;
} Skater;

typedef enum 
{
    Dutch,
    German,
    Danish,
    Belgian,
    Empty
} Nationality;

Skater skater[7];

int showSkaters(void);
int addSkaters(int skaterId);
int removeSkater(int skaterId); 
int addTime(void);
int showClassification(void);
int showFinalClassification(void);

// define your skater datatypes here

#endif
