using System;
using System.Collections.Generic;
using System.IO;

namespace TestApp
{
    class Program5BSkoba
    {
        static void Main(string[] args)
        {
            var res = new List<UInt64>();
            String line;
            try
            {
                StreamReader sr = new StreamReader("input.txt");
                line = sr.ReadLine();
                var leftS = 0;
                var rightS = 0;
                var s = 0;
                if (line != null)
                {
                    for (int i = 0; i < line.Length; i++)
                    {
                        if (line[i] == '(')
                        {
                            leftS++;
                            s++;
                        }
                        if (line[i] == ')')
                        {
                            rightS++;
                            if (rightS > leftS)
                            {
                                Console.WriteLine("NO");
                                return;
                            }
                            s--;
                        }
                    }

                    if (s == 0 && leftS == rightS)
                    {
                        Console.WriteLine("YES");
                    }
                    else
                    {
                        Console.WriteLine("NO");
                    }
                }
            }
            catch
            {
                // ignored
            }
        }
    }
}
