using System;

namespace MenuMyHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
           
            MainMenu mainMenu = new MainMenu();
            Console.WriteLine(mainMenu.menuText);
            mainMenu.MyMenu();
        }
    }
}
