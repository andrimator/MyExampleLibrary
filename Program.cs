using System;
using MyExampleLibrary.Instances;

namespace MyExampleLibrary
{
    class Program
    {
        public static bool isRunning = true;
        static void Main(string[] args)
        {
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
