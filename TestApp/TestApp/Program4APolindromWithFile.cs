using System;
using System.Collections.Generic;
using System.IO;

namespace TestApp
{
    class Program4APolindromWithFile
    {

        static void Main()
        {

            String line;
            int q;
            String str = null;
            try
            {
                //Pass the file path and file name to the StreamReader constructor
                StreamReader sr = new StreamReader("input.txt");
                //Read the first line of text
                line = sr.ReadLine();
                //Continue to read until you reach end of file
                while (line != null)
                {
                    str = line;
                    //write the line to console window
                    //Console.WriteLine(line);
                    //Read the next line
                    line = sr.ReadLine();

                }
                //close the file
                sr.Close();
            }
            catch (Exception e)
            {
                Console.Write("Exception: " + e.Message);
            }
            finally
            {
                Console.Write("Executing finally block.");
            }

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
            try
            {
                StreamWriter sw = new StreamWriter("output.txt");
                sw.WriteLine(res);
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
