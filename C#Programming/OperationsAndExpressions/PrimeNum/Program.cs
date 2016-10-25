using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class PrimeNum
{
    static void Main(string[] args)
    {

        int n = int.Parse(Console.ReadLine());
        if (n <= 1)
        {
            Console.WriteLine("false");
            Environment.Exit(0);
        }
        if (n == 2 || n == 3)
        {
            Console.WriteLine("true");
            Environment.Exit(0);
        }

        bool isPrime = true;
        for (int divideBy = 2; divideBy <= Math.Sqrt(n); divideBy++)
        {
            if (n % divideBy == 0)
            {
                isPrime = false;
            }
        }
        Console.WriteLine(isPrime.ToString().ToLower());
    }
}


