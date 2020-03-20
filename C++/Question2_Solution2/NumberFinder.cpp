//
// Created by galax on 3/19/2020.
//

#include <iostream>
#include "NumberFinder.h"

long NumberFinder::ReachTargetNumber(int time) {
    long result = 1;
    for (long i = 0; i < time - 1; i++) {
        result = GetNextSmallestInheritor();
    }
    return result;
}

long NumberFinder::GetNextSmallestInheritor() {
    bool hasInitialized = false;

    long smallestInheritor = -1; // the smallest number that satisfy the condition yet bigger than all the numbers already in the target list
    vector<NumberClass*> numbersToMovePointer;   // The pointers of these number class need to be move forward by one

    for (auto numberToCheck: numbersToCheck) {
        if (!hasInitialized) {
            smallestInheritor = numberToCheck->SmallestCombination();
            numbersToMovePointer.push_back(numberToCheck);
            hasInitialized = true;
        } else {
            if (numberToCheck->SmallestCombination() < smallestInheritor) {
                smallestInheritor = numberToCheck->SmallestCombination();
                numbersToMovePointer.clear();
                numbersToMovePointer.push_back(numberToCheck);


            } else if (numberToCheck->SmallestCombination() == smallestInheritor) {
                smallestInheritor = numberToCheck->SmallestCombination();
                numbersToMovePointer.push_back(numberToCheck);
            }
        }
    }


    for (int i = 0; i < numbersToMovePointer.size(); ++i) {
        if (!numbersToMovePointer[i]->MovePointer()) {
            numbersToCheck.erase(numbersToCheck.begin() + i);
        }
    }

    bool shouldCreateNewNumber = true;
    for (auto numberClass: numbersToCheck) {
        if (numberClass->targetNumber == smallestInheritor) {
            shouldCreateNewNumber = false;
        }
    }
    if (shouldCreateNewNumber) {
        CreateNewNumber(smallestInheritor);
    }
    return smallestInheritor;

}

void NumberFinder::CreateNewNumber(long number) {
    numbersToCheck.push_back(new NumberClass(number));
}

NumberFinder::NumberFinder() {
    numbersToCheck.push_back(new NumberClass(1));
}
