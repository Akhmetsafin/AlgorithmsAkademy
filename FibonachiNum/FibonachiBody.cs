using System;

namespace FibonachiNum
{
    public class FibonachiBody
    {
        /// <summary>
        /// Вывод на косоль вычислений метода FibonachiRecurtion 
        /// </summary>
        static void Run(string textNum)
        {
            Console.WriteLine("Число Фибоначи с рекурсией");

            if (int.TryParse(textNum, out int numberInter))
            {
                for (int i = 0; i < numberInter + 1; i++)
                {
                    if (i < numberInter)
                        Console.Write($"{FibonachiRecurtion(i)} | ");
                    else
                        Console.WriteLine($"{FibonachiRecurtion(i)} | ");
                }
            }
            else
            {
                Console.WriteLine("Не удалось распознать число, попробуйте еще раз.");
            }
        }
        /// <summary>
        /// Вычисление числа Фибоначи рекурсивным методом
        /// </summary>
        /// <param name="f"></param>
        /// <returns></returns>
        static int FibonachiRecurtion(int f)
        {
            if (f == 0) return 0;
            if (f == 1) return 1;
            return FibonachiRecurtion(f - 1) + FibonachiRecurtion(f - 2);
        }
        /// <summary>
        /// Фибоначи без рекурсии
        /// </summary>
        /// <param name="textNumnoRecur"></param>
        /// <returns></returns>
        static void Fibonachi(string textNumnoRecur)
        {
            int result = 0;
            Console.WriteLine("Число Фибоначи без рекурсии");
            if (int.TryParse(textNumnoRecur, out int numberInter))

            {

                int b = 1;
                int tmp;

                for (int i = 0; i < numberInter; i++)
                {
                    tmp = result;
                    result = b;
                    b += tmp;

                    if (i < numberInter - 1)
                    {
                        if (i == 0) Console.Write($"{(0)} | ");
                        if (i == 1) Console.Write($"{(1)} | ");
                        Console.Write($"{(b)} | ");
                    }
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Не удалось распознать число, попробуйте еще раз.");

            }


        }
        /// <summary>
        /// Сборка методов
        /// </summary>
        public void Core()
        {
           //do
          //  {
                Console.WriteLine("Введите число:");
                string textNum = Console.ReadLine();
                Run(textNum);
                Fibonachi(textNum);
               
         //  }
          // while (Console.ReadKey(true).Key != ConsoleKey.Escape);
           
        }

    }
}
