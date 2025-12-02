using System.Drawing;

public class Program
{
    public static void Main(string[] args)
    {
        Point point = new Point { X = 10 , Y = 30 };
        Console.WriteLine($"Исходная точка\n: {point}");
        Console.WriteLine(point.X--);
        Console.WriteLine(point.Y++);
    }
}