using System;

class MoonGravity
{
    static void Main(string[] args)
    {
        double moonGrav = 0.17;
        double W = double.Parse(Console.ReadLine());
        double moonW = moonGrav * W;
        Console.WriteLine("{0:0.000}", moonW);
    }
}

