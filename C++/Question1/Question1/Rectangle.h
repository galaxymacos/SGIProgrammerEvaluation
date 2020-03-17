
#include <string>
#include <vector>


#include "Point2D.h"

using namespace std;

class Point2D;

class Rectangle {

public:
    Rectangle(Point2D& vertex, float _width, float _height);
    Rectangle(Rectangle &otherRect, Point2D &vertex);

    bool ContainPoint(Point2D& point);

    static bool Intersect(Rectangle& rectangle1, Rectangle& rectangle2);

    friend ostream& operator <<(ostream& outputStream, const Rectangle& p);

    Rectangle& operator= (const Rectangle &otherRect);
    vector<Point2D> coordinates;


    Point2D& vertex;
    float width;
    float height;


private:


    Rectangle Clone();
};


