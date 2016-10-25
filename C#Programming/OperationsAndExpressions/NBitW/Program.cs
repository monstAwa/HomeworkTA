using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class NBitW
{
    static void Main(string[] args)
    {
        long number = long.Parse(Console.ReadLine());
        int position = int.Parse(Console.ReadLine());

        long mask = 1 << position;

        long result = number & mask;
        result = result >> position;
        Console.WriteLine(result);
    }
}

