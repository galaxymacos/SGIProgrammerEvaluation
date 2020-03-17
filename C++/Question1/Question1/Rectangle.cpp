
#include "Rectangle.h"
#include "Point2D.h"

#pragma once

using namespace std;

Rectangle::Rectangle(Point2D &vertex, float _width, float _height):vertex(vertex), width(_width), height(_height) {
    if(abs(_width)<0.0001f || abs(_height) < 0.0001f){

    }
    coordinates.push_back(vertex);
    coordinates.emplace_back(vertex.x+_width, vertex.y);
    coordinates.emplace_back(vertex.x, vertex.y+_height);
    coordinates.emplace_back(vertex.x+_width, vertex.y+_height);


}

bool Rectangle::Intersect(Rectangle &rectangle1, Rectangle &rectangle2) {
    for(auto &coordinateInRect1: rectangle1.coordinates){
        if(rectangle2.ContainPoint(coordinateInRect1)){
            return true;
        }
    }
    for(auto &coordinateInRect2: rectangle2.coordinates){
        if(rectangle1.ContainPoint(coordinateInRect2)){
            return true;
        }
    }
    return false;
}



bool Rectangle::ContainPoint(Point2D &point) {
    float topBoundary = coordinates[0].y;
    float leftBoundary = coordinates[0].x;
    float bottomBoundary = coordinates[0].y;
    float rightBoundary = coordinates[0].x;

    for (auto & coordinate : coordinates) {
        if(coordinate.y > topBoundary){
            topBoundary = coordinate.y;
        }
        if(coordinate.y < bottomBoundary){
            bottomBoundary = coordinate.y;
        }
        if(coordinate.x < leftBoundary){
            leftBoundary = coordinate.x;
        }
        if(coordinate.y > rightBoundary){
            rightBoundary = coordinate.x;
        }
    }

    return point.x >= leftBoundary && point.x <= rightBoundary && point.y <= topBoundary &&
           point.y >= bottomBoundary;

}



ostream &operator<<(ostream &outputStream, const Rectangle &p) {
    for(auto& vertex: p.coordinates){
        outputStream<<"("<<vertex.x<<","<<vertex.y<<")";
    }
    return outputStream;
}

Rectangle& Rectangle::operator=(const Rectangle &otherRect) {
    coordinates.clear();
    for(auto coordinate: otherRect.coordinates){
        coordinates.emplace_back(coordinate.x, coordinate.y);
    }
    return *this;
}

Rectangle::Rectangle(Rectangle &otherRect, Point2D &vertex):Rectangle(otherRect.vertex, otherRect.width,otherRect.height) {
}

Rectangle Rectangle::Clone() {
    Rectangle otherRect(vertex, width, height);
    return otherRect;
}

