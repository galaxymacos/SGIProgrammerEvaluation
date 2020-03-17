#include "Rectangle.h"
#include "Point2D.h"
#include <memory>

int main(){
    Point2D origin(0,0);
    Rectangle rectangle1(origin, -1, -2);

    cout<<"Rectangle1 coordinates: "<<rectangle1<<endl;

    cout<<"------------Test ContainPoint method"<<endl;
    Point2D ContainTestPoint1(0, 0);
    Point2D ContainTestPoint2(1, 1);
    cout << "Does rectangle contain the point " << ContainTestPoint1 << "? " << rectangle1.ContainPoint(ContainTestPoint1) << endl;
    cout << "Does rectangle contain the point " << ContainTestPoint2 << "? " << rectangle1.ContainPoint(ContainTestPoint2) << endl;

    cout<<endl;
    Point2D vertexOfRect2(1,1);
    Rectangle rect2(vertexOfRect2, -2.5f,-2.5f);
    cout<<"------------------Test intersect method"<<endl;
    cout<<"Rectangle1 coordinates: "<<rectangle1<<endl;
    cout<<"Rectangle2 coordinates: "<<rect2<<endl;
    cout<<"Does rectangle1 overlap with rectangle2? "<<Rectangle::Intersect(rectangle1, rect2)<<endl;
    cout<<endl;

    cout<<"Testing copy constructor"<<endl;
    Rectangle rectangle1Copy(rectangle1);
    cout<<"Rectangle 1: "<<rectangle1<<endl;
    cout<<"Rectangle 1 copy"<<rectangle1Copy<<endl;
    cout<<"Does two rect1 and rect1Copy have the same address ? "<< (addressof(rectangle1) == addressof(rect2)) <<endl;

    cout<<endl;
    cout<<"Testing assignment operator overload"<<endl;
    Rectangle newRect = rectangle1;
    cout<<"Rectangle 1: "<<rectangle1<<endl;
    cout<<"New Rectangle 1: "<<newRect<<endl;
    cout<<"Does two rect1 and newRect have the same address ? "<< (addressof(rectangle1) == addressof(newRect)) <<endl;

}

