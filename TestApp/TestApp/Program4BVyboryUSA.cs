using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace TestApp
{
    class Program4BVyboryUSA
    {
        static void Main(string[] args)
        {
            String line;
            var res = new Dictionary<string, int>();
            var sb = new StringBuilder();
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

                    var cnt = Convert.ToInt32(array[1]);
                    var name = array[0];
                    if (res.ContainsKey(name))
                    {
                        res[name] = res[name] + cnt;
                    }
                    else
                    {
                        res.Add(name, cnt);
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
            }
            foreach (var i in res)
            {
                sb.AppendLine(i.Key + " " +i.Value);
            }
            Console.WriteLine(sb);

            /*try
            {
                //Pass the filepath and filename to the StreamWriter Constructor
                StreamWriter sw = new StreamWriter("output.txt");
                //Write a line of text
                //sw.WriteLine(r.ToString());
                //Close the file
                sw.WriteLine(sb.ToString());
                sw.Close();
            }
            catch (Exception e)
            {
                Console.Write("Exception: " + e.Message);
            }
            finally
            {
            }*/
        }
    }
}
