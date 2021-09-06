using System;
using System.Collections.Generic;

namespace TestSum
{
    class ProgramBMetro
    {
        static void Main()
        {
           var line = Console.ReadLine();
            var array = line.Split(' ');
            int? cnt = null;
            int? i = null;
            int? j = null;
            for (int e = 0; e< array.Length; e++)
            {
                if (string.IsNullOrWhiteSpace(array[e]))
                {
                    continue;
                }
                if (!cnt.HasValue)
                {
                    cnt = Convert.ToInt32(array[e]);
                    continue;
                }
                if (!i.HasValue)
                {
                    i = Convert.ToInt32(array[e]);
                    continue;
                }
                if (!j.HasValue)
                {
                    j = Convert.ToInt32(array[e]);
                    continue;
                }
            }

            int? min1 = Math.Abs((j - i).Value) - 1;
            int? min2 = null;
            if (j > i)
            {
                min2 = Math.Abs((i + (cnt - j)).Value) - 1;
            }
            else
            {
                min2 = Math.Abs((j + (cnt - i)).Value) - 1;
            }
            int? min = null;
            if (min2 < min1)
            {
                min = min2;
            }
            else
            {
                min = min1;
            }
            Console.WriteLine(min);
        }
    }
}
