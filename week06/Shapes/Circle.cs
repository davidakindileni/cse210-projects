/*
BYU-Pathway CS210 - Programming with Classes | 25T5 | Waldyr Junior
Author: Akinsola David Akindileni
W06 Learning Activity: Polymorphism | Shape Program | Circle Class
*/

using System;

public class Circle : Shape
{
    // derived class for Circle shape

    // define member variable 
    private double _radius = 0;
    private const double PI = 3.1415926535897931;
    private string _type = "Circle";

    // define constructors
    public Circle(string color, double radius) : base(color)
    {
        _radius = radius;
    }

    // define functions
    public override double GetArea()
    {
        return Math.Round(PI * (_radius * _radius), 2);
    }

    public override string GetShapeType()
    {
        return _type;
    }
}