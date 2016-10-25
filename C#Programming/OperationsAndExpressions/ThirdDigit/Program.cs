using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ThirdDigit
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        if (N.ToString().Length < 3 || N < 0)
        {
            Console.WriteLine("false 0");
        }
        else if (N.ToString().ElementAt(N.ToString().Length - 3) == '7')
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine("false {0}", N.ToString().ElementAt(N.ToString().Length - 3));
        }
    }
}

