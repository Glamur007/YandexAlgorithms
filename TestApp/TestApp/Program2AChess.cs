using System;

namespace TestApp
{
    class Program2AConfuse
    {
        static void Main()
        {
            var cntStr = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(cntStr))
            {
                return;
            }

            var cnt = Convert.ToUInt16(cntStr);

            var chess = new int[10,10];
            for (int i = 0; i < cnt; i++)
            {
                var cl = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(cl))
                {
                    continue;
                }

                var d = cl.Split(' ');
                chess[Convert.ToUInt16(d[0]), Convert.ToUInt16(d[1])] = 1;
            }

            var p = 0;
            for (int k = 1; k <= 8; k++)
            {
                for (int l = 1; l <= 8; l++)
                {
                    if (chess[k,l] == 1)
                    {
                        var pSquare = 4;
                        if (chess[k - 1, l] == 1)
                        {
                            pSquare = pSquare - 1;
                        }
                        if (chess[k + 1, l] == 1)
                        {
                            pSquare = pSquare - 1;
                        }
                        if (chess[k, l-1] == 1)
                        {
                            pSquare = pSquare - 1;
                        }
                        if (chess[k, l+1] == 1)
                        {
                            pSquare = pSquare - 1;
                        }

                        p = p + pSquare;
                    }

                }
            }

            Console.WriteLine(p);
        }
    }
}
