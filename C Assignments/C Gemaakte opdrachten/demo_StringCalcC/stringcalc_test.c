/* auteur : F.J. Hurkmans
 * datum  : November 4th 2013
 * code   : Ansi C
 * versie : 1
 */
#include "stringcalc.h"
#include "unity.h"

// leave resource_detector.h as last include!
#include "resource_detector.h"

// I rather dislike keeping line numbers updated, so I made my own macro to
// ditch the line number
#define MY_RUN_TEST(func) RUN_TEST(func, 0)

void setUp(void)
{
    // This is run before EACH test
}

void tearDown(void)
{
    // This is run after EACH test
}

void firstTest(void)
{
    int result = 2;
    TEST_ASSERT_EQUAL(result, 1 + 1);
}

void test_adding_ints(void) 
{
    TEST_ASSERT_EQUAL(36, Add("1,,....;;;,,,,,,2  33"));
}

void test_adding_negative_values(void) 
{
     TEST_ASSERT_EQUAL(247, Add("100....124,,,2..21-23"));
}

void test_adding_weird_values(void) 
{
    TEST_ASSERT_EQUAL(1935 ,Add("100,,,,.,299.91...--13...)_-_--__1445"));
}

void test_using_calculater_mulitple_times(void) 
{
    TEST_ASSERT_EQUAL(1935 ,Add("100,,,,.,299.91...--13...)_-_--__1445"));
    TEST_ASSERT_EQUAL(247, Add("100....124,,,2..21-23"));
    TEST_ASSERT_EQUAL(36, Add(",,1,,....;;;,,,,,,2  33,,,."));
    TEST_ASSERT_EQUAL(36, Add("1,,....;;;,,,,,,2  33,,,."));
    TEST_ASSERT_EQUAL(0, Add(""));
}

void test_adding_null(void) 
{
    TEST_ASSERT_EQUAL(-1, Add(NULL));
}

int main(int argc, char* argv[])
{
    UnityBegin();

    MY_RUN_TEST(firstTest);
    MY_RUN_TEST(test_adding_ints);
    MY_RUN_TEST(test_adding_negative_values);
    MY_RUN_TEST(test_adding_null);
    MY_RUN_TEST(test_adding_weird_values);
    MY_RUN_TEST(test_using_calculater_mulitple_times);

    return UnityEnd();
}
