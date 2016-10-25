using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ThirdBitW
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        int mask = 1 << 3;
        int res = n & mask;
        res = res >> 3;

        Console.WriteLine(res);
    }
}

