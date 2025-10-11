/*
BYU-Pathway CS210 - Programming with Classes | 25T5 | Waldyr Junior
Author: Akinsola David Akindileni
W06 Learning Activity: Polymorphism | Shape Program | Rectangle Class
*/

using System;

public class Rectangle : Shape
{
    // derived class for rectangle shape

    // define member variables
    private double _length = 0;
    private double _width = 0;
    private string _type = "Rectangle";

    // define constructor
    public Rectangle(string color, double length, double width) : base(color)
    {
        _length = length;
        _width = width;
    }
    // define functions
    public override double GetArea()
    {
        return _length * _width;
    }
    public override string GetShapeType()
    {
        return _type;
    }
}