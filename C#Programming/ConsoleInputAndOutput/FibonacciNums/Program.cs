using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ProgFibonacciNumsram
{
    static void Main(string[] args)
    {
        long n = long.Parse(Console.ReadLine());
        long previous1 = 0;
        long previous2 = 1;

        if (n == 1)
        {
            Console.WriteLine(0);
        }

        Console.Write("{0}, {1}", previous1, previous2);
        for (int i = 2; i < n; i++)
        {
            long currFib = previous1 + previous2;
            Console.Write(", {0}", currFib);
            previous1 = previous2;
            previous2 = currFib;
        }

        Console.WriteLine();
    }
}

