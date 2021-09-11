using System;

namespace TestApp
{
    class Program2AConfuse
    {
        static void Main()
        {
            var line = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(line))
            {
                return;
            }

            var f = 0;
            var sum = 0;
            for (int i = line.Length-1; i > (line.Length-1)/2; i--)
            {
                if (line[i] == line[f])
                {
                    f++;
                    continue;
                }

                line = line.Remove(i, 1).Insert(i, line[f].ToString());
                f++;
                sum++;
            }
            //Console.WriteLine(line);
            Console.WriteLine(sum);
        }
    }
}
