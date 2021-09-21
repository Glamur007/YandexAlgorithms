using System;
using System.IO;
using System.Linq;

namespace TestApp
{
    class Program3BDigits
    {
        static void Main()
        {
            int q = 0;
            String line;
            try
            {
                StreamReader sr = new StreamReader("input.txt");
                line = sr.ReadLine();
                if (line != null)
                {
                    string[] array = line.Split(' ');
                    line = sr.ReadLine();
                    if (line != null)
                    {
                        string[] array2 = line.Split(' ');
                        foreach (var s in array2)
                        {
                            if (array.Contains(s))
                            {
                                q++;
                            }
                        }
                    }
                }
                sr.Close();
            }
            catch (Exception e)
            {
                Console.Write("Exception: " + e.Message);
            }

            Console.WriteLine(q);
        }
    }
}
