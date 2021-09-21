using System;
using System.IO;
using System.Linq;
using System.Text;

namespace TestApp
{
    class Program3BDigits3
    {
        static void Main()
        {
            StringBuilder stringBuilder = new StringBuilder();
            StreamWriter sw;
            String line;
            try
            {
                StreamReader sr = new StreamReader("input.txt");
                line = sr.ReadLine();
                if (line != null)
                {
                    string[] array = line.Split(' ');
                    for (int i = 0; i < array.Length; i++)
                    {
                        var r = false;
                        for (int j = 0; j < array.Length; j++)
                        {
                            if (i!=j && array[i] == array[j])
                            {
                                r = true;
                                break;
                            }
                        }

                        stringBuilder.Append(r ?  null: array[i]+" ");
                    }
                }
                sr.Close();
            }
            catch (Exception e)
            {
                Console.Write("Exception: " + e.Message);
            }

            Console.WriteLine(stringBuilder.ToString());
        }
    }
}
