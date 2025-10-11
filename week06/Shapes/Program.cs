/*
BYU-Pathway CS210 - Programming with Classes | 25T5 | Waldyr Junior
Author: Akinsola David Akindileni
W06 Learning Activity: Polymorphism | Shape Program | Program Class
*/

using System;

class Program
{
    static void Main(string[] args)
    {
        // create a new instance of a list of shapes
        List<Shape> shapes = new List<Shape>();

        // create a new instance of the square class
        Square s1 = new Square("Red", 5);
        shapes.Add(s1);

        // create a new instance of the rectangle class
        Rectangle s2 = new Rectangle("Green", 5, 10);
        shapes.Add(s2);

        // create a new instance of the circle class
        Circle s3 = new Circle("Blue", 5);
        shapes.Add(s3);

        // loop through the list to get the color, area, and type of each shape in the list
        foreach (Shape s in shapes)
        {
            string color = s.GetColor();
            double area = s.GetArea();
            string shapeType = s.GetShapeType();

            // display the tupe, color, and area of each shape in the list
            Console.WriteLine($"The {shapeType} is {color} and its area is {area}.");
        }
    }
}