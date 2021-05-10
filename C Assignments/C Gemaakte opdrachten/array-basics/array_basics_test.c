#include "array_basics.h"
#include "unity.h"
#include <stdio.h>
#include <math.h>

// leave resource_detector.h as last include!
#include "resource_detector.h"

// I rather dislike keeping line numbers updated, so I made my own macro to ditch the line number
#define MY_RUN_TEST(func) RUN_TEST(func, 0)

void setUp(void)
{
    //printf("This is run before EACH test.\n");
}

void tearDown(void)
{
    //printf("This is run after EACH test.\n");
}

void test_array_add_value_to_array_with_incorrect_parameters() {
	uint8_t maximum_array_size = 10;
	uint8_t number_of_values_present_in_array = 0;
	uint8_t value = 42;

	TEST_ASSERT_EQUAL(-1, array_add_value_to_array(
		value,
		NULL,
		maximum_array_size,
		number_of_values_present_in_array,
		NULL));
}

void test_array_add_value_to_array_with_zero_elements() {
	uint8_t maximum_array_size = 10;
	uint8_t array[10];
	uint8_t number_of_values_present_in_array = 0;
	uint8_t new_number_of_values_present_in_array = 0;
	uint8_t value = 42;

	TEST_ASSERT_EQUAL(0, array_add_value_to_array(
		value,
		array,
		maximum_array_size,
		number_of_values_present_in_array,
		&new_number_of_values_present_in_array));

		TEST_ASSERT_EQUAL(1, new_number_of_values_present_in_array);
		TEST_ASSERT_EQUAL(value, array[0]);
}
/*+-------------------------------------------------------------------------+*/
/*| Exercise: add unit tests and implementation of all methods              |*/
/*| as given in array_basics.h                                              |*/
/*+-------------------------------------------------------------------------+*/

void test_array_find_number_of_occurences_of_requested_value_in_array() 
{
	uint8_t  requested_value = 2;
	uint8_t array[] = {2, 2, 3, 5, 4};
	uint8_t  number_of_values_present_in_array = 5;
	uint8_t number_of_occurences;
    array_find_number_of_occurences_of_requested_value_in_array(requested_value, array, number_of_values_present_in_array, &number_of_occurences);
	TEST_ASSERT_EQUAL(2, number_of_occurences);
}

void test_array_replace_requested_value_array() 
{
  uint8_t  requested_value = 5;
  uint8_t  new_value = 2;
  uint8_t array[] = {3, 4, 5, 4};
  uint8_t  number_of_values_present_in_array = 4;
  array_replace_requested_value_array(requested_value, new_value, array, number_of_values_present_in_array);
  TEST_ASSERT_EQUAL(2, array[2]);
}

void test_array_remove_requested_value_from_array() 
{
  uint8_t  requested_value = 4;
  uint8_t array[] = {2, 4, 1, 4};
  uint8_t  number_of_values_present_in_array = 4;
  uint8_t  updated_number_of_values_present_in_array;
  array_remove_requested_value_from_array(requested_value, array, number_of_values_present_in_array, &updated_number_of_values_present_in_array);
  TEST_ASSERT_EQUAL(2, updated_number_of_values_present_in_array);
  TEST_ASSERT_EQUAL(1, array[1]);
}

void test_array_multiply_all_array_values_by_value() 
{
  uint8_t multiplication_value = 2;
  uint8_t array[] = {1, 2 ,3, 4};
  uint8_t number_of_values_present_in_array = 4;
   array_multiply_all_array_values_by_value(multiplication_value, array, number_of_values_present_in_array);
   TEST_ASSERT_EQUAL(4, array[1]);
}
// TODO: implement more unit tests here....
// .....
// ...
// ..
// .

/*+-------------------------------------------------------------------------+*/
/*|    F u n c t i o n  P o i n t e r s   B o n u s                         |*/
/*+-------------------------------------------------------------------------+*/
void square(uint8_t value, uint8_t* new_value)
{
		*new_value = value*value;
}

void test_array_apply_function_to_all_values()
{
	uint8_t array[] = {1,2,3,4};

	TEST_ASSERT_EQUAL(0, array_apply_function_to_all_values(
		square,
		array,
		4));

	uint8_t expected_array[] = {1,4,9,16};
	TEST_ASSERT_EQUAL_UINT8_ARRAY(expected_array, array, 4);
}

/*+-------------------------------------------------------------------------+*/
int main (int argc, char * argv[])
{
    UnityBegin();

		//TODO: add more unit tests here

		MY_RUN_TEST(test_array_add_value_to_array_with_incorrect_parameters);
        MY_RUN_TEST(test_array_add_value_to_array_with_zero_elements);
		MY_RUN_TEST(test_array_apply_function_to_all_values);
		MY_RUN_TEST(test_array_find_number_of_occurences_of_requested_value_in_array);

    return UnityEnd();
}
