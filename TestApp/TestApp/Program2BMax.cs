using System;

namespace TestApp
{
    class Program2BMax
    {
        static void Main()
        {
            UInt32? max = null;
            var array = new UInt32[10000];
            UInt16 k = 0;
            UInt16? ind = null;
            UInt16 cnt = 0;
            for (int e = 0; e < 10000; e++)
            {
                var line = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(line))
                {
                    continue;
                }

                var a = Convert.ToUInt32(line);
                if (a == 0)
                {
                    break;
                }

                if (!max.HasValue)
                {
                    max = a;
                    ind = k;
                    cnt = 1;
                }
                else
                {
                    if (a > max.Value)
                    {
                        max = a;
                        ind = k;
                        cnt = 1;
                    }
                    else if (a == max.Value)
                    {
                        cnt++;
                    }
                }

                array[k] = a;
                k++;
            }

            for (int g = 0; g < ind; g++)
            {
                if (array[g] == max)
                {
                    cnt++;
                }
            }

            Console.WriteLine(cnt);

        }
    }
}
