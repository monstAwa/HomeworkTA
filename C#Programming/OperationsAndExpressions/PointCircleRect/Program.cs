using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class PointCircleRect
{
    static void Main(string[] args)
    {
        int cX = 1;
        int cY = 1;
        double cR = 1.5;

        int rL = -1;
        int rW = 6;
        int rT = 1;
        int rH = 2;

        double pX = double.Parse(Console.ReadLine());
        double pY = double.Parse(Console.ReadLine());

        if (Math.Sqrt(Math.Pow((Math.Abs(cX - pX)), 2) + Math.Pow(Math.Abs(cY - pY), 2)) > cR)
        {
            Console.Write("outside circle ");
        }
        else
        {
            Console.Write("inside circle ");
        }

        if (pX >= rL && pX <= rL + rW && pY <= rT && pY >= rT - rH)
        {
            Console.Write("inside rectangle");
        }
        else
        {
            Console.WriteLine("outside rectangle");
        }
    }
}

