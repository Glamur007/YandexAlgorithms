using System;
using System.Collections.Generic;
using System.IO;

namespace TestApp
{
    class Program5BSumThree
    {
        static void Main(string[] args)
        {
            var res = new List<UInt64>();
            String line;
            try
            {
                StreamReader sr = new StreamReader("threesum.in");
                line = sr.ReadLine();
                var s = Convert.ToInt64(line);
                line = sr.ReadLine();
                var arrA = line.Split(' ');
                line = sr.ReadLine();
                var arrB = line.Split(' ');
                line = sr.ReadLine();
                var arrC = line.Split(' ');
                int na = Convert.ToInt32(arrA[0]);
                int nb = Convert.ToInt32(arrB[0]);
                int nc = Convert.ToInt32(arrC[0]);
                var a = new Int64[na];
                var b = new Int64[nb];
                var c = new Int64[nc];

                for (int i = 1; i <= na; i++)
                {
                    a[i-1] = Convert.ToInt32(arrA[i]);
                }
                for (int i = 1; i <= nb; i++)
                {
                    b[i-1] = Convert.ToInt32(arrB[i]);
                }
                for (int i = 1; i <= nc; i++)
                {
                    c[i-1] = Convert.ToInt32(arrC[i]);
                }

                for (int i = 0; i < na; i++)
                {
                    for (int j = 0; j < nb; j++)
                    {
                        for (int k = 0; k < nc; k++)
                        {
                            if (a[i] + b[j] + c[k] == s)
                            {
                                Console.WriteLine(i+" "+j+" "+k);
                                return;
                            }
                        }
                    }
                }
                Console.WriteLine(-1);
            }
            catch
            {
                // ignored
            }
        }
    }
}
