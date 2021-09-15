using System;
using System.Collections.Generic;
using System.Linq;

namespace TestApp
{
    class Program3BPolitic
    {
        static void Main()
        {
            var line = Console.ReadLine();
            var array = line.Split(' ');
            int d = Convert.ToInt32(array[0]);
            int k = Convert.ToInt32(array[1]);
            var a = new int[k];
            var b = new int[k];
            for (Int32 j = 0; j < k; j++)
            {
                var lineJ = Console.ReadLine();
                if (lineJ != null)
                {
                    var arrayJ = lineJ.Split(' ');
                    a[j] = Convert.ToInt32(arrayJ[0]);
                    b[j] = Convert.ToInt32(arrayJ[1]);
                }
                else
                {
                    Console.WriteLine(0);
                }

            }

            var res = new bool[d];
            for (int i = 1; i <= d; i++)
            {
                if (i % 7 == 0 || (i + 1) % 7 == 0)
                {
                    continue;
                }
                // a+n*b = D
                // n = (D-a)/b
                for (int j = 0; j < k; j++)
                {
                    double n = (double)(i - a[j]) / b[j];
                    if (n>=0 && n % 1 == 0)
                    {
                        if (res[i-1] == false)
                        {
                            res[i-1] = true;
                        }
                    }
                }
            }

            Console.WriteLine(res.Count(p => p==true));
        }
    }
}
