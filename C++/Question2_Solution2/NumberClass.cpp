//
// Created by galax on 3/19/2020.
//

#include <iostream>
#include "NumberClass.h"

NumberClass::NumberClass(long targetNumber): targetNumber(targetNumber) {
    InitializeList();
}

void NumberClass::InitializeList() {
    ListToMultiple = {2,3,5};
}

long NumberClass::SmallestCombination() {
    return targetNumber * ListToMultiple[pointerIndex];
}

bool NumberClass::MovePointer() {
    pointerIndex = pointerIndex+1;
    return pointerIndex < ListToMultiple.size();
}

