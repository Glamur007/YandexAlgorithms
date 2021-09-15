using System;
using System.Collections.Generic;
using System.Linq;

namespace TestApp
{
    class Program2BHouse
    {
        static void Main()
        {
            var line = Console.ReadLine();
            var array = line.Split(' ');
            short? d = null;
            var max = new Dictionary<short, short>();
            for (Int16 g = 0; g < array.Length; g++)
            {
                if (string.IsNullOrWhiteSpace(array[g]))
                {
                    continue;
                }
                var a = Convert.ToUInt16(array[g]);
                if (a == 2)
                {
                    d = 0;
                }

                if (a == 1)
                {
                    if (d != null)
                    {
                        d = (short)(d + 1);
                        max[g] = d.Value;
                    };
                }

                if (a == 0)
                {
                    if (d != null)
                    {
                        d = (short) (d + 1);
                    }
                }
            }

            d = null;
            for (short h = (short)(array.Length - 1); h >= 0; h--)
            {
                if (string.IsNullOrWhiteSpace(array[h]))
                {
                    continue;
                }
                var a = Convert.ToUInt16(array[h]);
                if (a == 2)
                {
                    d = 0;
                }

                if (a == 1)
                {
                    if (d != null)
                    {
                        d = (short) (d + 1);
                        if (max.ContainsKey(h))
                        {
                            max[h] = Math.Min(max[h], d.Value);
                        }
                        else
                        {
                            max[h] = d.Value;
                        }
                    }
                }

                if (a == 0)
                {
                    if (d != null)
                    {
                        d = (short) (d + 1);
                    }
                }
            }

            Console.WriteLine(max.Values.Max());
        }
    }
}
