using System;

class DivideSevenByFive
{
    static void Main()
    {
        int Num = int.Parse(Console.ReadLine());
        if(Num % 7 == 0 && Num % 5 == 0)
        {
            Console.WriteLine("true" + " " + Num);
        }
        else
        {
            Console.WriteLine("false" + " " + Num);
        }
    }
}

