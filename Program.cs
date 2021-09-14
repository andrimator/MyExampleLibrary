using System;
using MyExampleLibrary.Objects;
using MiniGuessGame;
using OpenBasicCalculator;

namespace MyExampleLibrary
{
    class Program
    {
        public static bool isRunning = true;
        static void Main(string[] args)
        {
            IntVector2D MenuSize = new IntVector2D(60, 25);
            while (Program.isRunning == true)
            {
                string[] listMenu = {"1. OpenBasicCalculator","2. ExampleUList1","3. MiniGuessGame"};
                Console.Clear();
                Menu MainMenu = new Menu("Menu Principal", 1, false, MenuSize.x, MenuSize.y);
                MainMenu.Initialize();
                MainMenu.LoadList(listMenu,3);
                Input.GetInt();
                Console.ReadLine();

                BasicCalculator.Initialize();
                ExampleUList1.Initialize();
                MyMiniGuessGame.Initialize();

                Console.ReadLine();
            }
            
        }
    }
}
