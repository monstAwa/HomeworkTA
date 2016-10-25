using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class FourDigits
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int firstNumber = (n / 1000) % 10;
        int secondNumber = (n / 100) % 10;
        int thirdNumber = (n / 10) % 10;
        int fourthNumber = n % 10;
        if (n > 0 && n < 9999)
        {
            Console.WriteLine(firstNumber + secondNumber + thirdNumber + fourthNumber);
            Console.WriteLine("{0}{1}{2}{3}", fourthNumber, thirdNumber, secondNumber, firstNumber);
            Console.WriteLine("{0}{1}{2}{3}", fourthNumber, firstNumber, secondNumber, thirdNumber);
            Console.WriteLine("{0}{1}{2}{3}", firstNumber, thirdNumber, secondNumber, fourthNumber);
        }
        else
        {
            Console.WriteLine("SMTH WRONG");
        }
    }
}

