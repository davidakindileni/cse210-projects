/*
BYU-Pathway CS210 - Programming with Classes | 25T5 | Waldyr Junior
Author: Akinsola David Akindileni
W06 Learning Activity: Polymorphism | Shape Program | Shape Class
*/

using System;

public abstract class Shape
{
    // This is the base class for all the shapes

    // define member variables
    private string _color;

    // define getters and setters
    public Shape(string color)
    {
        _color = color;
    }
    public string GetColor()
    {
        return _color;
    }
    public void SetColor(string color)
    {
        _color = color;
    }
    // define functions
    public abstract double GetArea();

    public abstract string GetShapeType();

}