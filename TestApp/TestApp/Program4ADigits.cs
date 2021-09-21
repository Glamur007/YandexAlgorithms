using System;
using System.Collections.Generic;
using System.Linq;

namespace TestApp
{
    class Program4ADigits
    {

        static void Main()
        {
            int q;
            var line = Console.ReadLine();
            var array = line.Split(' ');
            var str1 = array[0];

            var line2 = Console.ReadLine();
            var array2 = line2.Split(' ');
            var str2 = array2[0];

            var des = new List<char>();
            foreach (var ch in str1)
            {
                var idx = str2.IndexOf(ch);
                if (idx >= 0)
                {
                    str2 = str2.Remove(idx, 1);
                    des.Add(ch);
                }
            }

            if (!des.Any())
            {
                Console.WriteLine(-1);
                return;
            }

            var fd = des.OrderByDescending(d => d).ToArray();
            string s = new string(fd);

            long resDig = 0;
            try
            {
                resDig = Convert.ToInt64(s);
                if (resDig == 0)
                {
                    Console.WriteLine(0);
                    return;
                }
            }
            catch (Exception e)
            {
                //Console.WriteLine(0);
            }

            Console.WriteLine(s);
        }
    }
}
