#include "administration.h"

#include <stdbool.h>
#include <stdio.h>
#include <stdlib.h>
#include <string.h>

// leave resource_detector.h as last include!
#include "resource_detector.h"

int addAnimal(
            const Animal* animalPtr, Animal* animalArray,
            size_t animalArrayLength, size_t numberOfAnimalsPresent,
            size_t* newNumberOfAnimalsPresent)
{
    if ((animalPtr != NULL && animalArray != NULL && newNumberOfAnimalsPresent != NULL) && animalArrayLength > numberOfAnimalsPresent) 
    {
        animalArray[numberOfAnimalsPresent] = *animalPtr;
        numberOfAnimalsPresent += 1;
        *newNumberOfAnimalsPresent = numberOfAnimalsPresent;
        return 0;
    }
    else 
    {
        return -1;
    }
}

int removeAnimal(
            int animalId, Animal* animalArray,
            size_t numberOfAnimalsPresent,
            size_t* newNumberOfAnimalsPresent)
{
    if ((animalArray == NULL || newNumberOfAnimalsPresent == NULL) || numberOfAnimalsPresent <= 0) 
    {
        return -1;
    }
    int id;
    int amountDelete = 0;
    for (int i = 0; i < numberOfAnimalsPresent; i++) 
    {
        id = animalArray[i].Id;
        if (id == animalId) 
        {
            amountDelete++;
            numberOfAnimalsPresent -= 1;
            *newNumberOfAnimalsPresent = numberOfAnimalsPresent;
            animalArray[i] = animalArray[i + amountDelete];
        }
    }
    return 0;
}

int findAnimalById(
            int animalId, const Animal* animalArray,
            size_t numberOfAnimalsPresent, Animal* animalPtr)
{
    if (animalArray == NULL || animalPtr == NULL) 
    {
        return -1;
    }

    for (int i = 0; i < numberOfAnimalsPresent; i++) 
    {
        if (animalId == animalArray[i].Id) 
        {
            *animalPtr = animalArray[i];
            return 1;
        }
    }
    return 0;
}

/*-------------------------------------------------------------------------------*/
int sortAnimalsByAge(Animal* animalArray, size_t numberOfAnimalsPresent)
{
    return 0;
}

int sortAnimalsByYearFound(
            Animal* animalArray, size_t numberOfAnimalsPresent)
{
    return 0;
}

int sortAnimalsBySex(Animal* animalArray, size_t numberOfAnimalsPresent)
{
    return 0;
}
