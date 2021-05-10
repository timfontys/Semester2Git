#include "stringcalc.h"
#include <stdlib.h>
#include <stdio.h>
#include <string.h>
// leave resource_detector.h as last include!
#include "resource_detector.h"

extern int Add(char *numbers)
{
    if (numbers != NULL)
    {
        int lenght = strlen(numbers);
        int index = 0;
        int Sum = 0;
        char temporaryNum[lenght];

        for (int i = 0; i <= lenght; i++)
        {
            if ((numbers[i] >= '0' && numbers[i] <= '9') || numbers[i] == '-')
            {
                temporaryNum[index++] = numbers[i];
            }
            else
            {
                temporaryNum[index] = 0;
                int num = atoi(temporaryNum);
                if ((num > 0 && num <= 1001) || num >= 1111)
                {
                    Sum += num;
                }
                index = 0;
            }
        }
        return Sum;
    }
    return -1;
}
