
#pragma once
#include<vector>
#include "NumberClass.h"

class NumberFinder {
public:
    NumberFinder();
    long ReachTargetNumber(int time);
private:
    vector<NumberClass*> numbersToCheck;
    long GetNextSmallestInheritor();
    void CreateNewNumber(long number);
};


