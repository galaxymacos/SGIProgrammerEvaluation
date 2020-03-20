//
// Created by galax on 3/19/2020.
//
#include <vector>

#pragma once
using namespace std;

class NumberClass {


public:
    explicit NumberClass(long targetNumber);
    void InitializeList();
    vector<long> ListToMultiple;
    long SmallestCombination();
    bool MovePointer();

    long targetNumber;
private:
    int pointerIndex = 0;
};


