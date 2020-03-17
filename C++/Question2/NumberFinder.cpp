//
// Created by galax on 3/17/2020.
//

#include "NumberFinder.h"

long NumberFinder::GetNumberOfIndex(int targetIndex) {
    std::unordered_set<long> numbers;
    numbers.insert(1);
    int numberCount = 1;
    long numberToCheckNext = 2;

    while(numberCount<targetIndex){
        if(CheckNumber(numberToCheckNext, numbers)){
            numbers.insert(numberToCheckNext);
            numberCount++;
        }
        numberToCheckNext++;
    }
    return numberToCheckNext-1;
}

bool NumberFinder::CheckNumber(long numberToCheckNext, std::unordered_set<long>& targetNumbers) {
    int score = 0;
    if(numberToCheckNext % 2 == 0){
        if(targetNumbers.find(numberToCheckNext/2)!=targetNumbers.end()){
            score++;
        }
    }
    if(numberToCheckNext % 3 == 0){
        if(targetNumbers.find(numberToCheckNext/3)!=targetNumbers.end()){
            score++;
        }
    }
    if(numberToCheckNext % 5 == 0){
        if(targetNumbers.find(numberToCheckNext/5)!=targetNumbers.end()){
            score++;
        }
    }
    return score>=1;
}
