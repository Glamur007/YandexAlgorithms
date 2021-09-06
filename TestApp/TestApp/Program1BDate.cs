using System;
using System.Collections.Generic;

namespace TestSum
{
    class ProgramBDate
    {
        static void Main()
        {
            var line = Console.ReadLine();
            var array = line.Split(' ');
            int? a = null;
            int? b = null;
            int? c = null;
            for (int e = 0; e < array.Length; e++)
            {
                if (string.IsNullOrWhiteSpace(array[e]))
                {
                    continue;
                }
                if (!a.HasValue)
                {
                    a = Convert.ToInt32(array[e]);
                    continue;
                }
                if (!b.HasValue)
                {
                    b = Convert.ToInt32(array[e]);
                    continue;
                }
                if (!c.HasValue)
                {
                    c = Convert.ToInt32(array[e]);
                    continue;
                }
            }

            if (c >= 1970 && c <= 2069)
            {
                if (a == b && a <= 12) //03.03
                {
                    Console.WriteLine(1);
                    return;
                } 

                if ((a > 12 && b <= 12) || (b > 12 && a <= 12))
                {
                    Console.WriteLine(1);
                    return;
                }
                else 
                {
                    Console.WriteLine(0);
                    return;
                }
            }
            else
            {
                Console.WriteLine(0);
                return;
            }
            return;
        }
    }
}
