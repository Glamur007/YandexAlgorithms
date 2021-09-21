using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace TestApp
{
    class Program4BVybory
    {
        static void Main(string[] args)
        {
            String line;
            var res = new Dictionary<string, int>();
            var resR = new Dictionary<string, int>();
            double pervoeChastn = 1;
            int all = 0;
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

                    var cnt = Convert.ToInt32(array[array.Length - 1]);
                    all += cnt;
                    var name = string.Empty;
                    for (int i = 0; i < array.Length-1; i++)
                    {
                        name += array[i]+" ";
                    }

                    name = name.TrimEnd();
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

            pervoeChastn = (double)all / 450;
            var d = 0;
            int g;
            int sum = 0;
            var f = new Dictionary<string, double>();
            foreach (var s in res)
            {
                g = (int) (s.Value / pervoeChastn);
                f.Add(s.Key, (s.Value / pervoeChastn) - g);
                resR.Add(s.Key, g);
                sum += g;
            }

            if (sum < 450)
            {
                var ds = f.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
                foreach (var d1 in ds)
                {
                    if (sum < 450)
                    {
                        resR[d1.Key] += 1;
                        sum++;
                    }
                }
            }

            foreach (var i in resR)
            {
                sb.AppendLine(i.Key + " " +i.Value);
            }


            try
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
            }
        }
    }
}
