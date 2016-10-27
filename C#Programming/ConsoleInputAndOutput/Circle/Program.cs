using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Circle
{
    static void Main()
    {
        double r = double.Parse(Console.ReadLine());
        Console.WriteLine("{0} {1}", (2 * Math.PI * r).ToString("0.00"), (Math.PI * Math.Pow(r, 2)).ToString("0.00"));
    }
}

