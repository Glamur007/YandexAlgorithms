using System;

namespace TestApp
{
    class Program2AGlass
    {
        static void Main()
        {
            var line = Console.ReadLine();
            var array = line.Split(' ');
            int? x_1 = null;
            int? x_2 = null;
            int? y_1 = null;
            int? y_2 = null;
            for (int e = 0; e < array.Length; e++)
            {
                if (string.IsNullOrWhiteSpace(array[e]))
                {
                    continue;
                }
                if (!x_1.HasValue)
                {
                    x_1 = Convert.ToInt32(array[e]);
                    continue;
                }
                if (!y_1.HasValue)
                {
                    y_1 = Convert.ToInt32(array[e]);
                    continue;
                }
                if (!x_2.HasValue)
                {
                    x_2 = Convert.ToInt32(array[e]);
                    continue;
                }
                if (!y_2.HasValue)
                {
                    y_2 = Convert.ToInt32(array[e]);
                    continue;
                }
            }

            var line2 = Console.ReadLine();
            var array2 = line2.Split(' ');
            int? x3 = null;
            int? y3 = null;
            int? r = null;
            for (int e = 0; e < array2.Length; e++)
            {
                if (string.IsNullOrWhiteSpace(array2[e]))
                {
                    continue;
                }

                if (!x3.HasValue)
                {
                    x3 = Convert.ToInt32(array2[e]);
                    continue;
                }

                if (!y3.HasValue)
                {
                    y3 = Convert.ToInt32(array2[e]);
                    continue;
                }

                if (!r.HasValue)
                {
                    r = Convert.ToInt32(array2[e]);
                    continue;
                }
            }

            if (!x_1.HasValue || !x_2.HasValue || !x3.HasValue || !y_1.HasValue || !y_2.HasValue || !y3.HasValue || !r.HasValue)
            {
                return;
            }

            int x1 = 0;
            int x2 = 0;
            int y1 = 0;
            int y2 = 0;

            if (x_1 < x_2 && y_1 < y_2)
            {
                x1 = x_1.Value;
                y1 = y_1.Value;
                x2 = x_2.Value;
                y2 = y_2.Value;
            }
            else
            {
                x1 = x_2.Value;
                y1 = y_2.Value;
                x2 = x_1.Value;
                y2 = y_1.Value;
            }

            var cnt = 0;
            var tempX1 = (int)(x3 - r);
            var tempX2 = (int)(x3 + r);
            var tempY1 = (int)(y3 - r);
            var tempY2 = (int)(y3 + r);

            //Если весь пр-к в окружности
            if (Math.Pow(x1 - x3.Value, 2) + Math.Pow(y1 - y3.Value, 2) <= Math.Pow(r.Value, 2) &&
                (Math.Pow(x2 - x3.Value, 2) + Math.Pow(y2 - y3.Value, 2) <= Math.Pow(r.Value, 2)))
            {
                cnt = (x2 - x1 +1 ) * (y2 - y1 + 1);
            }
            else
            {

                for (int i = tempX1; i <= tempX2; i++)
                {
                    for (int j = tempY1; j <= tempY2; j++)
                    {
                        if (i >= x1 && i <= x2 && j >= y1 && j <= y2)
                        {
                            if (Math.Pow(i - x3.Value, 2) + Math.Pow(j - y3.Value, 2) <= Math.Pow(r.Value, 2))
                            {
                                cnt++;
                            }
                        }
                    }
                }
            }

            Console.WriteLine(cnt);
        }
    }
}
