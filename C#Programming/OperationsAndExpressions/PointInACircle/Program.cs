using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class PointInACircle
{
    static void Main(string[] args)
    {
        float pX = float.Parse(Console.ReadLine());
        float pY = float.Parse(Console.ReadLine());
        double cR = 2;
        double distance = Math.Sqrt(Math.Pow(pX, 2) + Math.Pow(pY, 2));
        if (distance <= cR)
        {
            Console.WriteLine("yes {0:0.00}", distance); 
        }
        else
        {
            Console.WriteLine("no {0:0.00}", distance);
        }
    }
}

