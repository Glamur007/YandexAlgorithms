using System;
using System.Collections.Generic;

namespace TestSum
{
    class Program
    {
        static void Main()
        {
            var dict = new SortedList<int, (int, int, int)>();
            int p = int.Parse(Console.ReadLine());
            for (int i = 1; i < p; i++)
            {
                for (int k = 1; k<=p-i; k++)
                {
                    for (int h=1; h<=p-i-k; h++)
                    {
                        if ((h + k + i == p)&&((i+k>h)&&(i+h>k)&&(k+h>i)))
                        //if (h + k + i == p)
                        {
                            var s = p * (p - i) * (p - h) * (p - k);
                            if (!dict.ContainsKey(s))
                            {
                                dict.Add(s, (i, h, k));
                            }
                        }
                            // Console.WriteLine(i.ToString() + " " + k.ToString() + " "+h.ToString());
                    }
                }
            }
            var keys = dict.Keys;
            if (keys.Count > 0)
            {
                if (dict.TryGetValue(keys[0], out var min))
                {
                    Console.WriteLine(min.Item1.ToString() + " " + min.Item2.ToString() + " " + min.Item3.ToString());
                }
                if (dict.TryGetValue(keys[keys.Count - 1], out var max))
                {
                    Console.WriteLine(max.Item1.ToString() + " " + max.Item2.ToString() + " " + max.Item3.ToString());
                }
            }
            else
            {
                Console.WriteLine(-1);
            }
            return;
        }
    }
}
