using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SumOfNNumbers
{
    static void Main()
    {
        int InputNums = int.Parse(Console.ReadLine());
        double[] numbers = new double[InputNums];
        for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = double.Parse(Console.ReadLine());
        }
        Console.WriteLine(numbers.Sum());
    }
}
