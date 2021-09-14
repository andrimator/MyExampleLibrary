using System;
using MyExampleLibrary.Instances;
using MyExampleLibrary.Objects;
using MiniGuessGame;

namespace MyExampleLibrary
{
    class Program
    {
        public static bool isRunning = true;
        static void Main(string[] args)
        {
            ExampleUList1.Initialize();
            MyMiniGuessGame.Initialize();
            while(Program.isRunning == true)
            {
                Console.Clear();
                Menu MainMenu = new Menu("Menu Principal", 1, false, 60, 25);
                MainMenu.Initialize();


                Console.ReadLine();
            }
            
        }
    }
}
