using System;

class OddOrEven
{
    static void Main()
    {
        int Num = int.Parse(Console.ReadLine());
        if (Num > 30 || Num < -30)
        {
            Console.WriteLine("Enter Number Between -30 and 30!");
        }
        else
        {
            if (Num % 2 == 0)
            {
                Console.WriteLine("even" + " " + Num);
            }
            else
            {
                Console.WriteLine("odd" + " " + Num);
            }            
        }
    }
}

