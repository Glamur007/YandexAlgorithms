using System;
using System.Collections.Generic;
using System.IO;

namespace TestApp
{
    class Program3AFibonachi2
    {
        static void Main(string[] args)
        {
            var res = new List<string>();
            var fibonachi = new List<ulong>();

            var line = Console.ReadLine();
            var array = line.Split(' ');
            var cnt = Convert.ToInt32(array[0]);

            var list = new List<ulong>();
            ulong maxInt = 0;
            for (int j = 0; j < cnt; j++)
            {
                var lineJ = Console.ReadLine();
                if (lineJ != null)
                {
                    var arrayJ = lineJ.Split(' ');
                    ulong f = 0;
                    try
                    {
                        f = Convert.ToUInt64(arrayJ[0]);
                    }
                    catch (Exception)
                    {

                    }

                    
                    list.Add(f);
                    if (maxInt < f)
                    {
                        maxInt = f;
                    }
                }
                else
                {
                    Console.WriteLine(0);
                }

            }

            fibonachi.Add(1);
            fibonachi.Add(1);
            for (int i = 2; i < 1000000; i++)
            {
                ulong e = fibonachi[i - 1] + fibonachi[i - 2];
                if (e <= maxInt)
                {
                    fibonachi.Add(e);
                }
                else
                {
                    break;
                }
            }

            for (int i = 0; i < cnt; i++)
            {
                if (fibonachi.Contains(list[i]))
                {
                    res.Add("Yes");
                }
                else
                {
                    res.Add("No");
                }
            }

            foreach (var re in res)
            {
                Console.WriteLine(re);
            }
        }
    }
}
