using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SumOfFiveNums
{
    static void Main()
    {
        int[] nums = new int[5];

        for (int i = 0; i < 5; i++)
        {
            nums[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine(nums.Sum());
    }
}

