using System;
using MyExampleLibrary.Objects;
using MiniGuessGame;
using OpenBasicCalculator;

namespace MyExampleLibrary
{
    class Program
    {
        public static bool stillRunning = true;
        static void Main(string[] args)
        {
            AsyncAwaitTasks.Initialize();
            /*while (Program.stillRunning == true)
            {
                Instance.MainMenu();

                //Proyectos
                BasicCalculator.Initialize();
                ExampleUList1.Initialize();
                MyMiniGuessGame.Initialize();
                ExceptionHandlingTests.Initialize();

                Console.ReadLine();
            }*/
            
        }
    }
}
