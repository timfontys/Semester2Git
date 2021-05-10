#include <stdbool.h>
#include <stdint.h>
#include <stdio.h>
#include <stdlib.h>
#include <string.h>

// Add your includes here:
#include "terminal_io.h"
#include "skater.h"

// leave resource_detector.h as last include!
#include "resource_detector.h"

int main(int argc, char* argv[])
{
    MenuOptions choice = MO_SHOW_ICESKATERS;
    printProgramHeader();

    while (choice != MO_QUIT)
    {
        choice = getMenuChoice();

        switch (choice)
        {
        case MO_SHOW_ICESKATERS:
            showSkaters();
            break;
        case MO_ADD_ICESKATER:
            addSkater(getInt("Wich skater number do you want to change"));
            break;
        case MO_REMOVE_ICESKATER:
            removeSkater(getInt("Wich skater number do you want to be removed"));
            break;
        case MO_ADD_TIME:
            addTime();
            break;
        case MO_SHOW_CLASSIFICATION:
            showClassification();
            break;
        case MO_SHOW_FINAL_CLASSIFICATION:
            showFinalClassification();
            break;
        case MO_LOAD:
            fprintf(stderr, "not yet implemented\n");
            break;
        case MO_SAVE:
            fprintf(stderr, "not yet implemented\n");
            break;
        case MO_QUIT:
            // nothing to do here
            break;
        default:
            fprintf(stderr, "ERROR: invalid choice: %d\n", choice);
            break;
        }
    }
    return 0;
}
