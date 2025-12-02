using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloading;

public class Point
{
    public int X { get; set; }
    public int Y { get; set; }


    public static Point operator++(Point point)
    {
        point.X++;
        point.Y++;
        return point;
    }
    public static Point operator--(Point point)
    {
        point.X--;
        point.Y--;
        return point;
    }
    public static Point operator-(Point point)
    {
        return new Point { X = -point.X, Y = -point.Y };
    }

    public override string ToString()
    {
        return $"Point: X = {X}, Y = {Y}";
    }

}
