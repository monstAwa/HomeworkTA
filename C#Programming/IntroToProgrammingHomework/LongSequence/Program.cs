using System;

class LongSequence
{
    static void Main()
    {
        int count;
        for (count = 2; count < 1002; count++)
        {
            if (count % 2 ==0)
            {
                Console.WriteLine(count);
            }
            else
            {
                Console.WriteLine(-count);
            }
        }
    }
}

