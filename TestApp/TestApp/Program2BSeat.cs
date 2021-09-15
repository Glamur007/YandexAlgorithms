using System;
using System.Collections.Generic;
using System.Linq;

namespace TestApp
{
    class Program2BSeat
    {
        static void Main()
        {
            var line = Console.ReadLine();
            var array = line.Split(' ');
            var l = Convert.ToUInt16(array[0]);
            var centerIdx = (l - 1) / 2;
            var k = Convert.ToUInt16(array[1]);
            var line2 = Console.ReadLine();
            var array2 = line2.Split(' ');
            var f = new List<UInt16>();
            for (int i = 0; i < array2.Length; i++)
            {
                if (string.IsNullOrWhiteSpace(array2[i]))
                {
                    continue;
                }

                var val = Convert.ToUInt16(array2[i]);
                if (l % 2 !=0 && val == centerIdx)
                {
                    Console.WriteLine(val);
                    return;
                }

                if ( val > centerIdx)
                {
                    Console.WriteLine(f[i-1] +" " + val);
                    return;
                }
                if (!f.Contains(val))
                {
                    f.Add(val);
                }
            }
        }
    }
}
