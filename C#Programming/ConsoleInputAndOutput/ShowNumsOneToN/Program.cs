using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ShowNumsOneToN
{
    static void Main(string[] args)
    {
        int nums = int.Parse(Console.ReadLine());

        for (int i = 1; i < nums + 1; i++)
        {
            Console.WriteLine(i);
        }
    }
}
