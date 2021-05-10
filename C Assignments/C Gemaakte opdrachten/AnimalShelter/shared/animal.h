#ifndef ANIMAL_H
#define ANIMAL_H

typedef enum
{
    Cat,
    Dog,
    GuineaPig,
    Parrot
} Species;

typedef enum
{
    Male,
    Female
} Sex;

typedef struct
{
    int Day;
    int Month;
    int Year;
} Date;

#define MaxNameLength 25
#define MaxLocationLength 100

typedef struct
{
    int     Id;
    Species Species;
    Sex     Sex;
    int     Age;
    Date    DateFound;
} Animal;

#endif
