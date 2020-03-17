//
// Created by galax on 3/17/2020.
//

#include "Point2D.h"

std::ostream &operator<<(std::ostream &outputStream, const Point2D &p) {
    return outputStream << "(" <<p.x <<","<< p.y<<")";
}
