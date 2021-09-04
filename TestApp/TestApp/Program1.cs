using System;
using System.Collections.Generic;

namespace TestSum
{
    class Program1
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            var res = new List<int>();

            for (int i = -1000000; i <= 1000000; i++)
            {
                if ((c * i + d) == 0)
                {
                    Console.WriteLine("NO");
                    return;
                }
                if ((a==c)&&(b==d))
                {
                    Console.WriteLine("INF");
                    return;
                }
                if (((double) ((double)(a * i + b) / (double)(c * i + d))) == 0)
                {
                    res.Add(i);
                }
            }

            Console.WriteLine(String.Join(" ", res.ToArray()));
            return;
        }
    }
}
