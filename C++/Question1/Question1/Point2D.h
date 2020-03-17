
#include <iostream>


#ifndef UNTITLED1_POINT2D_H
#define UNTITLED1_POINT2D_H


class Point2D {
public:
    Point2D() = default;

    Point2D(float x, float y) : x(x), y(y) {}

    float x{};
    float y{};

    friend std::ostream& operator <<(std::ostream& outputStream, const Point2D& p);

};


#endif //UNTITLED1_POINT2D_H
