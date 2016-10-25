using System;

class Rectangles
{
    static void Main()
    {
        double width = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());
        double area = height * width;
        double perimeter = 2 * (height + width);
        Console.Write("{0:0.00} ", area);
        Console.WriteLine("{0:0.00}", perimeter);
    }
}

