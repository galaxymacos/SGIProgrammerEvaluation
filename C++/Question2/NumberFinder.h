//
// Created by galax on 3/17/2020.
//

#ifndef UNTITLED_NUMBERFINDER_H
#define UNTITLED_NUMBERFINDER_H
#include <unordered_set>


class NumberFinder {
public:
    static long GetNumberOfIndex(int targetIndex);

    static bool CheckNumber(long numberToCheckNext, std::unordered_set<long>& targetNumbers);
};


#endif //UNTITLED_NUMBERFINDER_H
