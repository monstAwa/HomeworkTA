using System;

class Age
{
    static void Main()
    {
        DateTime birthdate = DateTime.ParseExact(Console.ReadLine(), "MM.dd.yyyy", null);
        Console.WriteLine(Math.Round(DateTime.Now.Subtract(birthdate).TotalDays - DateTime.Now.Subtract(birthdate).TotalDays % 365) / 365);
        Console.WriteLine((Math.Round(DateTime.Now.Subtract(birthdate).TotalDays - DateTime.Now.Subtract(birthdate).TotalDays % 365) / 365) + 10);
    }
}

