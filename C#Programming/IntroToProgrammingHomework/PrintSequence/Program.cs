using System;

class PrintSequence
{
    static void Main()
    {
        int count;
        for (count = 2; count < 12; count++)
        {
            if (count % 2 == 0)
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

