using System;
using System.Collections.Generic;

namespace TestSum
{
    class ProgramXO
    {
        static void Main()
        {
            var line1 = Console.ReadLine();
            var line2 = Console.ReadLine();
            var line3 = Console.ReadLine();

            var array1 = line1.Split(' ');
            var array2 = line2.Split(' ');
            var array3 = line3.Split(' ');

            var ar = new int[3,3];

            //ar[0,1] = Convert.ToInt32(array1[0]);

            for (int i = 0; i < 3; i++)
            {
                ar[0, i] = Convert.ToInt32(array1[i]);
            }
            for (int i = 0; i < 3; i++)
            {
                ar[1, i] = Convert.ToInt32(array2[i]);
            }
            for (int i = 0; i < 3; i++)
            {
                ar[2, i] = Convert.ToInt32(array3[i]);
            }

            //Console.WriteLine(ar[2, 2]);
            int cnt0 = 0;
            int cnt1 = 0;
            int cnt2 = 0;

            for (int i = 0; i < 3; i++)
            {
                for  (int g = 0; g<3; g++)
                {
                    if (ar[i,g] == 0)
                    {
                        cnt0++;
                    }
                    else if (ar[i,g] == 1)
                    {
                        cnt1++;
                    }
                    else if (ar[i,g] == 2)
                    {
                        cnt2++;
                    }
                }
            }

            if (cnt1-cnt2 == 1 || cnt0 == 9)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
            return;
        }
    }
}