using System;
using System.Collections.Generic;
using System.IO;

namespace TestApp
{
    class Program5BSum
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
                for (int i = 0; i < arrStr.Length; i++)
                {
                    if (string.IsNullOrWhiteSpace(arrStr[i]))
                    {
                        continue;
                    }
                    arr[i] = Convert.ToInt64(arrStr[i]);
                }

                Int64? max = null;
                Int64? localMax = null;
                Int64? oldLocalMax = null;
                for (int i = 0; i < n; i++)
                {
                    localMax = arr[i];
                    for (int j = i + 1; j < n; j++)
                    {
                        oldLocalMax = localMax;
                        localMax = localMax + arr[j];
                        if (oldLocalMax > localMax)
                        {
                            if (oldLocalMax > max || !max.HasValue)
                            {
                                max = oldLocalMax;
                            }
                            break;
                        }
                    }

                    if (max < localMax || !max.HasValue)
                    {
                        max = localMax;
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
