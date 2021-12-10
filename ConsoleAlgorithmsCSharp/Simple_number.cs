using System;

namespace ConsoleAlgorithmsCSharp
{
    public class Simple_number
    {
        public string welcom = "Программа определения простых и не простых чисел";
    
            /*
            Simple_number simple_Number = new Simple_number();
            Console.WriteLine(simple_Number.welcom);
            simple_Number.Core();
            */
        
        /// <summary>
       /// метод проверки чисел
       /// </summary>
        public void Verification()
        {
            int i = 2;
            int d = 0;
            string value;
            string text = Console.ReadLine();
            if (int.TryParse(text, out int numberInter))

            {
                while (i < numberInter)
                {
                    if (numberInter % i == 0)
                    {
                        i++;
                        d++;
                        continue;
                    }
                    else
                    {
                        i++;
                        continue;
                    }
                }

                {
                    if (d == 0)
                    {
                        value = "это число - простое";
                    }
                    else
                    {
                        value = "это число - не простое";
                    }

                    //Console.ReadLine();
                }
                Console.WriteLine(value);
                Console.WriteLine("продолжить нажмите любую клавишу, выйти нажмите ESC");

            }
            else
            {
                Console.WriteLine("Не удалось распознать число, попробуйте еще раз.");
            }
        }
        /// <summary>
        ///  Цикл продолжения или выхода
        /// </summary>
        public void Core()
        {
           // do
           // {
                Console.WriteLine("Введите число: ");
                Verification();
           // }
           // while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }

    }
}
