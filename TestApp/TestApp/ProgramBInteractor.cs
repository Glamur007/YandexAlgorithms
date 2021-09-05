﻿using System;
using System.Collections.Generic;

namespace TestSum
{
    class ProgramBInteractor
    {
        static void Main()
        {
            int r = int.Parse(Console.ReadLine());
            int i = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            /*Вердикт чекера и вердикт интерактора — это целые числа от 0 до 7 включительно.
            Код завершения задачи — это целое число от -128 до 127 включительно.
            Если интерактор выдал вердикт 0, итоговый вердикт равен 3 в случае, если программа завершилась с ненулевым кодом, и вердикту чекера в противном случае.
            Если интерактор выдал вердикт 1, итоговый вердикт равен вердикту чекера.
            Если интерактор выдал вердикт 4, итоговый вердикт равен 3 в случае, если программа завершилась с ненулевым кодом, и 4 в противном случае.
            Если интерактор выдал вердикт 6, итоговый вердикт равен 0.
            Если интерактор выдал вердикт 7, итоговый вердикт равен 1.
            В остальных случаях итоговый вердикт равен вердикту интерактора.*/
            var res = i;
            var is0 = r.Equals(0);            
            switch (i)
            {
                case 0:
                    if (is0)
                    {
                        res = c;
                    }
                    else
                    {
                        res = 3;
                    }
                    break;
                case 1:
                    res = c;
                    break;
                case 4:
                    if (is0)
                    {
                        res = 4;
                    }
                    else
                    {
                        res = 3;
                    }
                    break;
                case 6:
                    res = 0;
                    break;
                case 7:
                    res = 1;
                    break;
                default:
                    break;
            }
            Console.WriteLine(res);

        }
    }
}
