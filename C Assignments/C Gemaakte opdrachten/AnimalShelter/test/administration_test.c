#include <string.h>

#include "administration.h"
#include "unity.h"
#include "unity_test_module.h"

// leave resource_detector.h as last include!
#include "resource_detector.h"

// I rather dislike keeping line numbers updated, so I made my own macro to ditch the line number
#define MY_RUN_TEST(func) RUN_TEST(func, 0)

void administration_setUp(void)
{
    // This is run before EACH test
}

void administration_tearDown(void)
{
    // This is run after EACH test
}

void test_EmptyTest(void)
{
    TEST_ASSERT_EQUAL(1, 1);
}

void test_add_animal_extreme_values(void) 
{
    Animal animal = { 1, 0, 0, 0, { 0, 0, 0 } };
    Animal animalArray[20];
    size_t animalArrayLength = 10;
    size_t numberOfAnimalsPresent = 9;
    size_t newNumberOfAnimalsPresent = 9;

    int result = addAnimal(&animal, animalArray, animalArrayLength, numberOfAnimalsPresent, &newNumberOfAnimalsPresent);
    TEST_ASSERT_EQUAL(10, newNumberOfAnimalsPresent);
    TEST_ASSERT_EQUAL(0, result);
    animalArrayLength = 10;
    numberOfAnimalsPresent = 10;
    newNumberOfAnimalsPresent = 9;

    result = addAnimal(&animal, animalArray, animalArrayLength, numberOfAnimalsPresent, &newNumberOfAnimalsPresent);

    TEST_ASSERT_EQUAL(-1, result);
    TEST_ASSERT_EQUAL(9, newNumberOfAnimalsPresent);
}



void test_remove_animal_extreme_values(void) 
{
    int animalId = 1;
    Animal animalArray[50];
    animalArray[1].Id = 1;
    size_t numberOfAnimalsPresent = 0;
    size_t newNumberOfAnimalsPresent = 0;
    int result = removeAnimal(animalId, animalArray, numberOfAnimalsPresent, &newNumberOfAnimalsPresent);
    TEST_ASSERT_EQUAL(-1, result);
    TEST_ASSERT_EQUAL(0, newNumberOfAnimalsPresent);
}

void test_add_animal_null_values(void) 
{
    Animal animal = { 1, 0, 0, 0, { 0, 0, 0 } };
    Animal animalArray[20];
    size_t animalArrayLength = 10;
    size_t numberOfAnimalsPresent = 9;
    size_t newNumberOfAnimalsPresent = 0;

    int result = addAnimal(&animal, animalArray, animalArrayLength, numberOfAnimalsPresent, NULL);
    TEST_ASSERT_EQUAL(0, newNumberOfAnimalsPresent);
    TEST_ASSERT_EQUAL(-1, result);
}

void test_remove_animal_null_values(void) 
{
    int animalId = 1;
    Animal animalArray[50];
    animalArray[1].Id = 1;
    size_t numberOfAnimalsPresent = 0;
    size_t newNumberOfAnimalsPresent = 0;
    int result = removeAnimal(animalId, animalArray, numberOfAnimalsPresent, NULL);
    TEST_ASSERT_EQUAL(-1, result);
    TEST_ASSERT_EQUAL(0, newNumberOfAnimalsPresent);
}

void test_add_animal(void) 
{
    Animal animal = { 1, 0, 0, 0, { 0, 0, 0 } };
    Animal animalArray[50];
    size_t animalArrayLength = 50;
    size_t numberOfAnimalsPresent = 0;
    size_t newNumberOfAnimalsPresent = 0;
    int result = addAnimal(&animal, animalArray, animalArrayLength, numberOfAnimalsPresent, &newNumberOfAnimalsPresent);
    TEST_ASSERT_EQUAL(1, newNumberOfAnimalsPresent);
    TEST_ASSERT_EQUAL(0, result);


}

void test_remove_animal(void) 
{
    int animalId = 1;
    Animal animalArray[50];
    animalArray[1].Id = 1;
    size_t numberOfAnimalsPresent = 3;
    size_t newNumberOfAnimalsPresent = 0;
    int result = removeAnimal(animalId, animalArray, numberOfAnimalsPresent, &newNumberOfAnimalsPresent);
    TEST_ASSERT_EQUAL(0, result);
    TEST_ASSERT_EQUAL(2, newNumberOfAnimalsPresent);
}

void test_find_Animal_By_Id(void) 
{
    int animalId = 1;
    Animal animalArray[50];
    animalArray[1].Id = 1;
    size_t numberOfAnimalsPresent = 3;
    Animal animal = { 1, 0, 0, 0, { 0, 0, 0 } };
    int result = findAnimalById(animalId, animalArray, numberOfAnimalsPresent, &animal);
    TEST_ASSERT_EQUAL(1, result);
    TEST_ASSERT_EQUAL(-1, findAnimalById(animalId, animalArray, numberOfAnimalsPresent, NULL));
}


void run_administration_tests()
{
    UnityRegisterSetupTearDown( administration_setUp, administration_tearDown);
    MY_RUN_TEST(test_add_animal_null_values);
    MY_RUN_TEST(test_add_animal_extreme_values);
    MY_RUN_TEST(test_remove_animal_extreme_values);
    MY_RUN_TEST(test_EmptyTest);
    MY_RUN_TEST(test_add_animal);
    MY_RUN_TEST(test_remove_animal);
    MY_RUN_TEST(test_find_Animal_By_Id);

    UnityUnregisterSetupTearDown();
}
