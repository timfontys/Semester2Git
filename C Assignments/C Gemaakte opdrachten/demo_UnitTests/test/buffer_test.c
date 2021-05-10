/* 
 * auteur : Freddy Hurkmans
 * datum  : November 15th 2015
 * code   : C99
 */

#include "buffer.h"
#include "unity.h"

// I rather dislike keeping line numbers updated, so I made my own macro to ditch the line number
#define MY_RUN_TEST(func) RUN_TEST(func, 0)

void setUp(void)
{
    // This is run before EACH test
}

void tearDown(void)
{
    // This is run after EACH test
}

void test_to_see_if_our_compiler_can_add_2_integers(void)
{
    int result = 2;
    TEST_ASSERT_EQUAL(result, 1+1);
}

void test_if_buffer8_value_can_be_added_and_read(void) {
	uint8_t value = 32;
	uint32_t index = 0;
	int result = writeBufferValueAsUint8(index, value);
	TEST_ASSERT_EQUAL(0, result);
	
	uint8_t readValue = 0;
	result = readBufferValueAsUint8(index, &readValue);
	TEST_ASSERT_EQUAL(0, result);
	TEST_ASSERT_EQUAL(value, readValue);
}


// void test_indexOutOfRange_above(void)
// {
//     uint32_t testValue = 21;
//     TEST_ASSERT_EQUAL(-1, indexOutOfRange(testValue));
// }

// void test_indexOutOfRange_under(void)
// {
//     uint32_t testValue = -1;
//     TEST_ASSERT_EQUAL(-1, indexOutOfRange(testValue));
// }

// void test_indexInRange(void)
// {
//     uint32_t testValue = 3;
//     TEST_ASSERT_EQUAL(0, indexOutOfRange(testValue));
// }
void test_initBuffer_assuming_readBufferValueAsUnit8_Works(void)
{
    initBuffer();
    for (int i = 0; i < 20; i++)
    {
        uint8_t testValue = 3;
        readBufferValueAsUint8(i, &testValue);
        TEST_ASSERT_EQUAL(0, testValue);  
    }
}

void test_readBufferValueAsUnit8(void) 
{
   int value = writeBufferValueAsUint8(3, 32);
   TEST_ASSERT_EQUAL(0, value);
}

void test_writeBufferValueAsUint32(void)
{
    int value = writeBufferValueAsUint32(1, 2155905152);
    TEST_ASSERT_EQUAL(0, value);
}


int main (int argc, char * argv[])
{
    UnityBegin();
    MY_RUN_TEST(test_readBufferValueAsUnit8);
    MY_RUN_TEST(test_initBuffer_assuming_readBufferValueAsUnit8_Works);
    MY_RUN_TEST(test_to_see_if_our_compiler_can_add_2_integers);
    MY_RUN_TEST(test_if_buffer8_value_can_be_added_and_read);
    // MY_RUN_TEST(test_indexOutOfRange_above);
    // MY_RUN_TEST(test_indexOutOfRange_under);
    // MY_RUN_TEST(test_indexInRange);
    MY_RUN_TEST(test_readBufferValueAsUnit8);
    MY_RUN_TEST(test_writeBufferValueAsUint32);
    
    return UnityEnd();
}
