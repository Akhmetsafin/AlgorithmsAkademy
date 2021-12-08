using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonachiNum
{
    class FibonachiBody
    {
        static void Run()
        {
            //Console.WriteLine("Введите число:");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                if (i < n - 1)
                    Console.Write($"{FibonachiRecurtion(i)} | ");
                else
                    Console.WriteLine($"{FibonachiRecurtion(i)} | ");
            }
            Run();
        }
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
                Console.WriteLine("Введите число: ");
                Verification();
            }
            while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }

    }
}
