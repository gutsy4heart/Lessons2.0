using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism;

public class Shapes
{
    public virtual double GetArea()
    {
        Console.WriteLine("Неизвестная фигура");
        return 0;
    }
}

public class Circle : Shapes
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }
    public override double GetArea()
    {
        return Math.PI * Radius * Radius;

    }
}

public class Rectangle: Shapes
{
    public double Width { get; set; }
    public double Height { get; set; }
    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public override double GetArea() 
    { 
        return Width * Height;
    }


}

public class Triangle : Shapes
{
    public double BaseLength { get; set; }
    public double Height { get; set; }

    public Triangle(double baseLength, double height)
    {
        BaseLength = baseLength;
        Height = height;
    }
    public override double GetArea()
    {
        return 0.5 * BaseLength * Height;
    }
}