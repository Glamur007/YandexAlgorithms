using System;
using System.IO;

namespace TestSum
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] array = Console.ReadLine().Split(' ');
            //int a = int.Parse(array[0]);
            //int b = int.Parse(array[1]);
            //Console.WriteLine(a + b);

            int a;
            int b;
            int r = 0;

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
                    a = int.Parse(array[0]);
                    b = int.Parse(array[1]);
                    r = a + b;
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
                //Write a line of text
                sw.WriteLine(r.ToString());
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
