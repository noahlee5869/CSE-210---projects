using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Base> shapes = new List<Base>();

        Square s1 = new Square("Red", 3);
        shapes.Add(s1);

        Rectangle s2 = new Rectangle("Blue", 3, 4);
        shapes.Add(s2);

        Circle s3 = new Circle("Green", 10);
        shapes.Add(s3);

        foreach (Base s in shapes)
        {
            string color = s.GetColor();

            double area = s.GetArea();

            Console.WriteLine($"The Color is {color} and the area of the shapes is {area}");
        }

    }
}