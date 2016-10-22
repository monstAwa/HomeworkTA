using System;

class Program
{
    static void Main()
    {
        byte count;
        for(count = 33; count < 127; count++)
        {
            Console.Write((char)count);
        }
    }
}

