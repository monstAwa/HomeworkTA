using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class ModifyBitW
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int pos = int.Parse(Console.ReadLine());
            ulong bitValue = ulong.Parse(Console.ReadLine());
            ulong mask;
            ulong result;

            if (num == 0)
            {
                num++;
                result = (ulong)num << pos; ;
            }
            else if (bitValue == 1 && (num >> pos) % 2 == 1)
            {
                mask = (ulong)0 << pos;
                result = (ulong)num ^ mask;
            }
            else if (bitValue == 0 && (num >> pos) % 2 == 0)
            {
                mask = (ulong)0 << pos;
                result = (ulong)num ^ mask;
            }
            else
            {
                mask = (ulong)1 << pos;
                result = (ulong)num ^ mask;
            }

            Console.WriteLine(result);
        }
    }

