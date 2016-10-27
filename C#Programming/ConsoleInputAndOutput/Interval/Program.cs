using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Interval
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int M = int.Parse(Console.ReadLine());
        int print = 0;
        for (int i = Math.Min(N, M) + 1; i < Math.Max(N, M); i++)
        {
            if (i % 5 == 0)
            {
                print++;
            }
        }
        Console.WriteLine(print);
    }
}

