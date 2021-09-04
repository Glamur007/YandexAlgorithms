using System;

namespace TestSum
{
    class Program
    {
        static void Main()
        {
            var lig = Console.ReadLine();
            int cnt = Convert.ToInt32(lig);
            //int cnt = int.Parse(Console.ReadLine());
            var lines = new int[cnt, 8];
            for (int i = 0; i<cnt; i++)
            {
                var line = Console.ReadLine();
                var array = line.Split(' ');
                for (int g = 0; g<array.Length; g++)
                {
                    if (!string.IsNullOrWhiteSpace(array[g]))
                    {
                        lines[i, g] = Convert.ToInt32(array[g]);
                    }
                }

                /*
                var a = (lines[i, 0], lines[i, 1]);
                var b = (lines[i, 2], lines[i, 3]);
                var c = (lines[i, 4], lines[i, 5]);
                var d = (lines[i, 6], lines[i, 7]);
                */

                var f1 = lines[i, 2] - lines[i, 0];//a1 x
                var f2 = lines[i, 3] - lines[i, 1];//a1 y

                var t1 = lines[i, 4] - lines[i, 0]; // a2 x
                var t2 = lines[i, 5] - lines[i, 1]; // a2 y

                var w1 = lines[i, 6] - lines[i, 4]; //b1 x
                var w2 = lines[i, 7] - lines[i, 5]; // b1 y

                var y1 = lines[i, 6] - lines[i, 2]; //b2 x
                var y2 = lines[i, 7] - lines[i, 3]; //b2 y

                var a1b1 = Math.Abs(f1 * w1 + f2 * w2);
                var a2b2 = Math.Abs(t1 * y1 + t2 * y2);

                var ab1 = Math.Sqrt(Math.Pow(lines[i, 2] - lines[i, 0], 2) + Math.Pow(lines[i, 3] - lines[i, 1],2));
                var cd1 = Math.Sqrt(Math.Pow(lines[i, 6] - lines[i, 4], 2) + Math.Pow(lines[i, 7] - lines[i, 5],2));

                var ac1 = Math.Sqrt(Math.Pow(lines[i, 4] - lines[i, 0],2) + Math.Pow(lines[i, 5] - lines[i, 1],2));
                var bd1 = Math.Sqrt(Math.Pow(lines[i, 6] - lines[i, 2],2) + Math.Pow(lines[i, 7] - lines[i, 3],2));

                var delta = 0.0001;
                if ((Math.Abs(a1b1 - ab1* cd1) < delta  &&Math.Abs( ab1 - cd1) < delta) ||(Math.Abs(a2b2 - ac1 * bd1 )< delta && Math.Abs(ac1 - bd1 )< delta))
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }
            }
            return;
        }
    }
}
