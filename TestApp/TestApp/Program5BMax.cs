using System;
using System.Collections.Generic;
using System.IO;

namespace TestApp
{
    class Program5BMax
    {
        static void Main(string[] args)
        {
            var res = new List<UInt64>();
            String line;
            try
            {
                StreamReader sr = new StreamReader("input.txt");
                line = sr.ReadLine();
                string[] array1 = line.Split(' ');
                var n = Convert.ToInt32(array1[0]);
                line = sr.ReadLine();
                var arr = new Int64[n];
                var arrStr = line.Split(' ');
                int f = 0;
                foreach (var s in arrStr)
                {
                    if (string.IsNullOrWhiteSpace(s))
                    {
                        continue;
                    }
                    arr[f] = Convert.ToInt64(s);
                    f++;
                }

                Int64? max = null;
                for (int i = 0; i < n; i++)
                {
                    var s = arr[i];
                    for (int j = i + 1; j < n; j++)
                    {
                        s = s + arr[j];

                        if (s < max)
                        {
                            break;
                        }

                        max = s;
                    }
                }
                Console.WriteLine(max);
                sr.Close();
            }
            catch (Exception e)
            {
                Console.Write("Exception: " + e.Message);
            }
            finally
            {
            }
        }
    }
}
