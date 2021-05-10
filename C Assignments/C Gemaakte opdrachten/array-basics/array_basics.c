#include "array_basics.h"
#include <stddef.h>

// leave resource_detector.h as last include!
#include "resource_detector.h"

int array_add_value_to_array(
  uint8_t  value,
  uint8_t* array,
  uint8_t  maximum_array_size,
  uint8_t  number_of_values_present_in_array,
  uint8_t* new_number_of_values_present_in_array)
{
	//Example:
	if (maximum_array_size == number_of_values_present_in_array) 
	{
		return -1;
	}
	array[number_of_values_present_in_array] = value;
	number_of_values_present_in_array++;
	*new_number_of_values_present_in_array = number_of_values_present_in_array;
	return 0;
	// Input:
	// value: 42
	// array : {1,2,3};
	// maximum_array_size: 10
	// number_of_values_present_in_array: 3

	// Result:
	// array : {1,2,3,42};
	// new_number_of_values_present_in_array: 4
	// return value: 0
}

int array_find_number_of_occurences_of_requested_value_in_array(
  uint8_t  requested_value,
  uint8_t* array,
  uint8_t  number_of_values_present_in_array,
  uint8_t* number_of_occurences)
{
	for (int i = 0; i < number_of_values_present_in_array; i++) 
		  {
			if (array[i] == requested_value) 
				 {
					 *number_of_occurences += 1;
				 }  
		 }

	//Example:

	// Input:
	// requested_value : 2
	// array : {1,2,3,2,10,2,5};
	// number_of_values_present_in_array : 7

	// Result:
	// number_of_occurences : 3
	// return value: 0
	return 0;
}

int array_replace_requested_value_array(
  uint8_t  requested_value,
  uint8_t  new_value,
  uint8_t* array,
  uint8_t  number_of_values_present_in_array)
{
	for (int i = 0; i < number_of_values_present_in_array; i++) 
	{
		if (array[i] == requested_value) 
		{
			array[i] = new_value;
		}  
		
	}
	//Example:

	// Input:
	// requested_value : 2
	// new_value: 42
	// array : {1,2,3,2,10,2,5};
	// number_of_values_present_in_array : 7

	// Result:
	// array : {1,42,3,42,10,42,5};
	// return value: 0

	return 0;
}

int array_remove_requested_value_from_array(
  uint8_t  requested_value,
  uint8_t* array,
  uint8_t  number_of_values_present_in_array,
  uint8_t* updated_number_of_values_present_in_array)
{
	int amountValueInArray = 0;
	for (int i = 0; i < number_of_values_present_in_array; i++) 
	{
		if (array[i] == requested_value) 
		{
			amountValueInArray++;
		}  
		if (amountValueInArray > 0) 
		{
			array[i] = array[i + amountValueInArray];
		}
	}
	number_of_values_present_in_array -= amountValueInArray;
	*updated_number_of_values_present_in_array = number_of_values_present_in_array;
	//Example:

	// Input:
	// requested_value : 2
	// array : {1,2,3,2,10,2,5};
	// number_of_values_present_in_array : 7

	// Result:
	// array : {1, 3, 10, 5};
	// updated_number_of_values_present_in_array : 4;
	// return value: 0

	return 0;
}

int array_multiply_all_array_values_by_value(
  uint8_t multiplication_value,
  uint8_t* array,
  uint8_t  number_of_values_present_in_array)
{
	for (int i = 0; i < number_of_values_present_in_array; i++) 
	{
		array[i] *= multiplication_value;
		
	}
	//Example:

	// Input:
	// multiplication_value : 3
	// array : {1,2,3};
	// number_of_values_present_in_array: 3

	// Result:
	// array : {3,6,9};
	// return value: 0

	return 0;
}

int array_apply_function_to_all_values(
  void (*element_function)(uint8_t value, uint8_t* new_value),
  uint8_t* array,
  uint8_t  number_of_values_present_in_array)
{
	for (int i = 0; i < number_of_values_present_in_array; i++)
	{
		element_function(array[i], &array[i]);
	}
	
	//Example:

	// Input:
	// element_function
	// array : {1,2,3};
	// number_of_values_present_in_array: 3

	// Result:
	// array : { element_function(array[0],
	//           element_function(array[1]),
	//           element_function(array[2]) };
	// return value: 0

	return 0;
}
