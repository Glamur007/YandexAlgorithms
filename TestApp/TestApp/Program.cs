using System;

namespace TestSum
{
    class Program
    {
        static void Main(string[] args)
        {
            // драгоценности
            string j = Console.ReadLine();
            // камни
            string s = Console.ReadLine();

            int result = 0;
            foreach (var c in s)
            {
                if (j.IndexOf(c) >= 0)
                {
                    ++result;
                }
            }

            Console.WriteLine(result);
        }
        /*static void Main(string[] args)
        {
            // драгоценности
            string j = Console.ReadLine();
            // камни
            string s = Console.ReadLine();

            int result = 0;
            foreach (char ch in s)
            {
                if (j.IndexOf(ch) >= 0)
                {
                    ++result;
                }
            }

            Console.WriteLine(result);
        }*/

        /*static void Main()
        {
            string[] array = Console.ReadLine().Split(' ');
            int a = int.Parse(array[0]);
            int b = int.Parse(array[1]); ;
            Console.WriteLine(a + b);
        }*/
    }
}
