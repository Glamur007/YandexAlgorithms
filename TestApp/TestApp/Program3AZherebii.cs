using System;
using System.Collections.Generic;

namespace TestApp
{
    class Program3AFibonachi2
    {
        static void Main(string[] args)
        {
            var res = new List<string>();
            var fibonachi = new List<int>();

            var line = Console.ReadLine();
            var array = line.Split(' ');
            int cnt = Convert.ToInt32(array[0]);

            var bals = new UInt16[cnt];
            var line2 = Console.ReadLine();
            var array2 = line2.Split(' ');
            int i = 0;
            foreach (var s in array2)
            {
                if (!string.IsNullOrWhiteSpace(s))
                {
                    bals[i] = Convert.ToUInt16(s);
                    i++;
                }
            }

            var x = new List<int>();
            var xCnt = new Dictionary<int, int>();
            var line3 = Console.ReadLine();
            var array3 = line3.Split(' ');
            int j = 0;
            var min = new List<int>();
            foreach (var s in array3)
            {
                if (!string.IsNullOrWhiteSpace(s))
                {
                    var y = Convert.ToUInt16(s);
                    var idx = x.IndexOf(y);
                    if (idx>=0)
                    {
                        xCnt[y] = xCnt[y]+1;
                    }
                    else
                    {
                        x.Add(y);
                        xCnt[y] = 1;
                    }
                    j++;
                }
            }

            var maxVyi = 0;
            var resF = 0;
            for (int k = 1; k < 10; k++)
            {
                var tr = xCnt.TryGetValue(k, out j);
                if ((tr&&(j==1))||!tr)
                {
                    var petya = bals[bals.Length - 1] + k;
                    var vyigrysh = 0;
                    for (int f = 0; f < bals.Length-1; f++)
                    {
                        if (bals[f] < petya)
                        {
                            vyigrysh++;
                        }
                    }

                    if (maxVyi < vyigrysh)
                    {
                        maxVyi = vyigrysh;
                        resF = k;
                    }
                }
            }

            Console.WriteLine(resF);
        }
    }
}
