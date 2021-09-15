using System;
using System.Collections.Generic;
using System.IO;

namespace TestApp
{
    class Program3ASumWithFile
    {
        static void Main(string[] args)
        {
            var res = new Dictionary<string, int>();

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
                    if (!string.IsNullOrWhiteSpace(array[0]) && !string.IsNullOrWhiteSpace(array[1]))
                    {
                        if (res.ContainsKey(array[0]))
                        {
                            res[array[0]] = res[array[0]] + Convert.ToInt32(array[1]);
                        }
                        else
                        {
                            res[array[0]] = Convert.ToInt32(array[1]);
                        }
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

            try
            {
                //Pass the filepath and filename to the StreamWriter Constructor
                StreamWriter sw = new StreamWriter("output.txt");
                foreach (var s in res)
                {
                    sw.WriteLine(s.Key + " "+ s.Value.ToString());
                }
                //Write a line of text
                //sw.WriteLine(r.ToString());
                //Close the file
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
