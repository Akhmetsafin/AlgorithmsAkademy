using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonachiNum
{
    class FibonachiBody
    {
        /// <summary>
        /// Вывод на косоль вычислений метода FibonachiRecurtion 
        /// </summary>
        static void Run()
        {
            Console.WriteLine("Введите число:");
            string textNum = Console.ReadLine();
            if (int.TryParse(textNum, out int numberInter))

            {

                for (int i = 0; i < numberInter; i++)
                {
                    if (i < numberInter - 1)
                        Console.Write($"{FibonachiRecurtion(i)} | ");
                    else
                        Console.WriteLine($"{FibonachiRecurtion(i)} | ");
                }
                Console.WriteLine("продолжить нажмите любую клавишу, выйти нажмите ESC");
                
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
        public void Core()
        {
            do
            {
                //Console.WriteLine("Введите число: ");
                Run();


            }
            while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }

    }
}
