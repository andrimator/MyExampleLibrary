using System;
using MyExampleLibrary.Objects;
using MiniGuessGame;
using OpenBasicCalculator;
using MyExampleLibrary.Instances;

namespace MyExampleLibrary
{
    class Program
    {
        public static bool stillRunning = true;
        static void Main(string[] args)
        {
            //IOSystem.TestZone();
            //IOSystem.Initialize();
            //Console.ReadLine();
            while (Program.stillRunning == true)
            {
                Instance.MainMenu();

                //Proyectos
                AsyncAwaitTasks.Initialize();
                BasicCalculator.Initialize();
                ExampleUList1.Initialize();
                MyMiniGuessGame.Initialize();
                ExceptionHandlingTests.Initialize();

                Console.ReadLine();
            }

        }
    }
}
