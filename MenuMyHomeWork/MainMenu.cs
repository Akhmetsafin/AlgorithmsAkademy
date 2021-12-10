using ConsoleAlgorithmsCSharp;
using FibonachiNum;
using System;

namespace MenuMyHomeWork
{
    public class MainMenu
    {
        public string menuText = "Добро пожаловать в меню Домашних заданий по предмету Алгоритмы \n" +
                  "Выберите ниже из списка:\n" +
                  "1-Проверка числа простое/непростое\n" +
                  "2-Число Фибоначи рекурсивный метотод / обычный метод\n" +
                  "9-Выход";

        /// <summary>
        /// Меню для программы
        /// </summary>
        /// <returns></returns>
        public void MyMenu()
        {

            string text = Console.ReadLine();

            do
            {
                if (int.TryParse(text, out int numberInter))
                {
                    if (numberInter == 1)


                        SimpleNumbers();




                    if (numberInter == 2)

                        FibonachiNumbers();

                    if (numberInter == 9)

                        Environment.Exit(0);
                    Console.WriteLine("Для выхода в главное меню нажмите ESC");
                }
                else
                {
                    Console.WriteLine("Команда не распознана");

                }
            }
            while (Console.ReadKey(true).Key != ConsoleKey.Escape);
            Console.Clear();
            Console.WriteLine(menuText);
            MyMenu();




        }
        /// <summary>
        /// Меню для вывода проекта с проверкой простых чисел
        /// </summary>
        public void SimpleNumbers()
        {
            Simple_number simple_Number = new Simple_number();
            Console.WriteLine(simple_Number.welcom);
            simple_Number.Core();
        }
        /// <summary>
        /// Меню для вывода проекта чисел Фибоначи
        /// </summary>
        public void FibonachiNumbers()
        {
            FibonachiBody fibonachiBody = new FibonachiBody();
            fibonachiBody.Core();
        }
    }
}
