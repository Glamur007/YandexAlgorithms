using System;

namespace TestApp
{
    class Program2BDiplom
    {
        static void Main()
        {
            var cntStr = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(cntStr))
            {
                return;
            }

            var cnt = Convert.ToUInt16(cntStr);

            var line = Console.ReadLine();
            var array = line.Split(' ');

            UInt16[] ai = new UInt16[100];
            var k = 0;
            var cntSec = 0;
            var maxFolder = 0;
            for (int g = 0; g < array.Length; g++)
            {
                if (!string.IsNullOrWhiteSpace(array[g]))
                {
                    ai[k] = Convert.ToUInt16(array[g]);

                    if (maxFolder < ai[k])
                    {
                        maxFolder = ai[k];
                    }

                    cntSec = cntSec + ai[k];

                    k++;
                }
            }

            cntSec = cntSec - maxFolder;

            /*Array.Sort(ai);

            for (int f = 0; f < ai.Length - 1; f++)
            {
                cntSec = cntSec + ai[f];
            }*/

            Console.WriteLine(cntSec);
        }
    }
}
