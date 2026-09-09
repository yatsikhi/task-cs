#include <iostream>
#include <string>
using namespace std;

class Point {
public:
    int _x;
    int _y;
    int _num;
    Point(int x, int y, int num) : _x(x), _y(y), _num(num) {}
};

class Circle {
public:
    Point* point;
    int _rad;
    bool _filled;
    int _num;
    Circle(int rad, int x, int y, int num, bool filled)
        : _rad(rad), _filled(filled), _num(num) {
        point = new Point(x, y, num);
    }
};

int main() {
    int max_count = 38; 
    int multiplicity = 6; 
    int rad = 25; 

    Circle** circles = new Circle * [max_count];

    for (int i = 0; i < max_count; i++) {
        circles[i] = new Circle(
            rad,
            (i % multiplicity) * 50,
            (i / multiplicity) * 50,
            i,
            false
        );

        if ((i / multiplicity) % 2 == 1) {
            circles[i]->_filled = true;
            circles[i]->point->_x = multiplicity * 50 - circles[i]->point->_x;
            circles[i]->_rad = rad + multiplicity * (i % multiplicity);
        }
    }

    for (int i = 0; i < max_count; i++) {
        Circle* c = circles[i];
        string str = "Circle: {Point: _num = " +
            to_string(c->point->_num) +
            ", _x = " + to_string(c->point->_x) +
            ", _y = " + to_string(c->point->_y) +
            "}, _rad = " + to_string(c->_rad) +
            ", _filled = " + to_string(c->_filled) + "}";
        cout << str << "\n";
    }

    for (int i = 0; i < max_count; i++) {
        delete circles[i]->point;
        delete circles[i];
    }
    delete[] circles;

    return 0;
}
