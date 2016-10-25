using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class BitExchange
{
    static void Main(string[] args)
    {
        uint number = uint.Parse(Console.ReadLine());
        
        string toPrint = Convert.ToString(number, 2);
        for (int i = toPrint.Length; i < 32; i++) 
        {
            toPrint = "0" + toPrint;
        }

        string tempStr = toPrint.ElementAt(5).ToString() + toPrint.ElementAt(6).ToString() + toPrint.ElementAt(7).ToString();

        toPrint = toPrint.Insert(26, tempStr); 

        tempStr = toPrint.ElementAt(29).ToString() + toPrint.ElementAt(30).ToString() + toPrint.ElementAt(31).ToString();

        toPrint = toPrint.Remove(29, 3);
        toPrint = toPrint.Insert(5, tempStr);
        toPrint = toPrint.Remove(8, 3);

        Console.WriteLine(Convert.ToInt64(toPrint, 2));
    }
}

