using System;
using System.Collections.Generic;

namespace TestApp
{
    class Program4APolindrom
    {

        static void Main()
        {
            int q;
            var line = Console.ReadLine();
            var array = line.Split(' ');
            var cnt = Convert.ToInt32(array[0]);

            var str = Console.ReadLine();
            
            var alpha = new Char[]
            {
                'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U',
                'V', 'W', 'X', 'Y', 'Z'
            };

            var cntd = new Dictionary<char, int>();
            for (int i = 0; i < str.Length; i++)
            {
                if (cntd.ContainsKey(str[i]))
                {
                    cntd[str[i]] = cntd[str[i]] + 1;
                }
                else
                {
                    cntd.Add(str[i], 1);
                }
            }

            var resBegin = string.Empty;
            var resEnd = string.Empty;
            char? last = null; 
            foreach (var c in alpha)
            {
                var f = cntd.TryGetValue(c, out q);
                /*if (f && q == 1 && !last.HasValue)
                {
                    last = c;
                }*/
                if (f&&q>=1)
                {
                    while (q>1)
                    {
                        resBegin = resBegin + c;
                        q--;
                        resEnd = c + resEnd;
                        q--;
                    }

                    if (q == 1 && !last.HasValue)
                    {
                        last = c;
                    }
                }

            }

            var res = resBegin + last + resEnd;
            Console.WriteLine(res);
        }
    }
}
