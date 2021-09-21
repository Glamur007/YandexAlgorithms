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
                var q = Convert.ToInt32(array1[1]);
                line = sr.ReadLine();
                var arr = new UInt64[n];
                var left = new int[q];
                var right = new int[q];
                var arrStr = line.Split(' ');
                for (int i = 0; i < arrStr.Length; i++)
                {
                    if (string.IsNullOrWhiteSpace(arrStr[i]))
                    {
                        continue;
                    }
                    arr[i] = Convert.ToUInt64(arrStr[i]);
                }
                var j = 0;
                line = sr.ReadLine();
                while (line != null)
                {
                    var leftRightStr = line.Split(' ');
                    left[j] = Convert.ToInt32(leftRightStr[0]);
                    right[j] = Convert.ToInt32(leftRightStr[1]);
                    j++;
                    line = sr.ReadLine();
                }

                for (int i = 0; i < q; i++)
                {
                    UInt64 s = 0;
                    for (int k = left[i]; k <= right[i]; k++)
                    {
                        s = s + arr[k - 1];
                    }
                    res.Add(s);
                }
                sr.Close();
            }
            catch (Exception e)
            {
                Console.Write("Exception: " + e.Message);
            }
            finally
            {
            }

            try
            {
                StreamWriter sw = new StreamWriter("output.txt");
                foreach (var s in res)
                {
                    sw.WriteLine(s);
                }
                sw.Close();
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
