using System;
using System.Collections.Generic;
using System.IO;

namespace TestApp
{
    class Program3AFibonachi
    {
        static void Main(string[] args)
        {
            var list = new List<int>();
            var res = new List<string>();
            var fibonachi = new List<int>();
            String line;
            try
            {
                //Pass the file path and file name to the StreamReader constructor
                StreamReader sr = new StreamReader("input.txt");
                //Read the first line of text
                line = sr.ReadLine();
                //Continue to read until you reach end of file
                while (line != null)
                {
                    //write the line to console window
                    //Console.WriteLine(line);
                    string[] array = line.Split(' ');
                    if (!string.IsNullOrWhiteSpace(array[0]))
                    {
                        list.Add(Convert.ToInt32(array[0]));
                    }

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

            fibonachi.Add(1);
            fibonachi.Add(1);
            for (int i = 2; i < 100000; i++)
            {
                fibonachi.Add(fibonachi[i - 1] + fibonachi[i - 2]);
            }

            for (int i = 1; i < list.Count; i++)
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
                Console.Write("Executing finally block.");
            }
        }
    }
}
