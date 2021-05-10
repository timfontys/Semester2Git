#ifndef ARRAY_BASICS_H
#define ARRAY_BASICS_H

#include <stdint.h>

/* pre    : maximum_array_size must be greater than number_of_values_present_in_array
 * post   : array is updated with the value from value, the updated number of values is passed in new_number_of_values_present_in_array
 * returns: 0 on success or -1 if an error occurs
 */
int array_add_value_to_array(
  uint8_t  value,
  uint8_t* array,
  uint8_t  maximum_array_size,
  uint8_t  number_of_values_present_in_array,
  uint8_t* new_number_of_values_present_in_array);

/* pre    :
 * post   : The number of found values that equals requested_value is passed in number_of_occurences
 * returns: 1 on success, 0 if not found or -1 if an error occurs
 */
int array_find_number_of_occurences_of_requested_value_in_array(
  uint8_t  requested_value,
  uint8_t* array,
  uint8_t  number_of_values_present_in_array,
  uint8_t* number_of_occurences);

/* pre    :
 * post   : All values in the array that equal the requested_value are updated with the new_value.
 * returns: The number of replaced values, 0 if no values are replaced or -1 if an error occurs
 */
int array_replace_requested_value_array(
  uint8_t  requested_value,
  uint8_t  new_value,
  uint8_t* array,
  uint8_t  number_of_values_present_in_array);

/* pre    :
 * post   : All values in the array that equal requested_value are removed from the array.
 * returns: The number of removed values, 0 if no values are removed or -1 if an error occurs
 *          The updated number of values present is writted to updated_number_of_values_present_in_array
 */
 int array_remove_requested_value_from_array(
   uint8_t  requested_value,
   uint8_t* array,
   uint8_t  number_of_values_present_in_array,
 	 uint8_t* updated_number_of_values_present_in_array);
   
/* pre    :
 * post   : All values in the array are multiplied by the multiplication_value
 * returns: 1 on success, 0 if not found or -1 if an error occurs
*/
int array_multiply_all_array_values_by_value(
  uint8_t multiplication_value,
  uint8_t* array,
  uint8_t  number_of_values_present_in_array);

/* pre    :
 * post   : Alle array elements are updated by applying the element_function to
 *          each array value.
 * returns: 1 on success, 0 if not found or -1 if an error occurs
*/
int array_apply_function_to_all_values(
  void (*element_function)(uint8_t value, uint8_t* new_value),
  uint8_t* array,
  uint8_t  number_of_values_present_in_array);

#endif
