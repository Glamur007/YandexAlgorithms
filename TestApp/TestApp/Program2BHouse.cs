using System;

namespace TestApp
{
    class Program2BHouse
    {
        static void Main()
        {
            var arrayInt = new UInt16[10];
            var line = Console.ReadLine();
            var array = line.Split(' ');
            var f = 0;
            var d = 0;
            UInt16[] max = new UInt16[10];
            for (int g = 0; g < array.Length; g++)
            {
                if (!string.IsNullOrWhiteSpace(array[g]))
                {
                    arrayInt[f] = Convert.ToUInt16(array[g]);
                    if (arrayInt[f] == 2)
                    {
                        d++;
                    }
                    else if ((arrayInt[f] == 1 && max[d] == 0)||(max[d] != 0 && (arrayInt[f] == 1|| arrayInt[f] == 0)))
                    {
                        max[d]++;
                    }
                    f++;
                }
            }

            for (int h = arrayInt.Length - 1; h > 0; h--)
            {
                if (arrayInt[h] == 2)
                {
                    d++;
                }
                else if ((arrayInt[h] == 1 && max[d] == 0) || (max[d] != 0 && (arrayInt[h] == 1 || arrayInt[h] == 0)))
                {
                    max[d]++;
                }
            }

            for (int s = 0; s < d; s++)
            {
                Console.WriteLine(max[s]);
            }
        }
    }
}
