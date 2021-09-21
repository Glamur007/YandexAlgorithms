using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace TestApp
{
    class Program3BDigits3
    {
        static void Main()
        {
            String line;
            var yesList = new List<int>();
            try
            {
                //Pass the file path and file name to the StreamReader constructor
                StreamReader sr = new StreamReader("input.txt");
                //Read the first line of text
                line = sr.ReadLine();
                var maxDigit = Convert.ToUInt32(line);
                var firstLine = true;
                var noList = new List<int>();
                //Continue to read until you reach end of file
                while (line != null)
                {
                    line = sr.ReadLine();
                    if (line == "HELP")
                    {
                        break;
                    }
                    string[] array = line.Split(' ');
                    line = sr.ReadLine();
                    var contains = line == "YES" ? true : false;
                    for (int i = 0; i < array.Length; i++)
                    {
                        var f = Convert.ToInt32(array[i]);
                        if (firstLine)
                        {
                            if (contains)
                            {
                                yesList.Add(f);
                            }
                            else
                            {
                                noList.Add(f);
                            }
                        }
                        else
                        {
                            if (contains)
                            {
                                if (!yesList.Contains(f))
                                {
                                    if(!noList.Contains(f))
                                    {
                                        noList.Add(f);
                                    }
                                }
                            }
                            else
                            {
                                if (!noList.Contains(f))
                                {
                                    noList.Add(f);
                                }
                                if (yesList.Contains(f))
                                {
                                    yesList.Remove(f);
                                }

                            }
                        }
                    }

                    firstLine = false;

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

            yesList.Sort();
            var str = new StringBuilder();
            foreach (var i in yesList)
            {
                str.Append(Convert.ToString(i) + " ");
            }
            Console.WriteLine(str.ToString().TrimEnd());

        }
    }
}
