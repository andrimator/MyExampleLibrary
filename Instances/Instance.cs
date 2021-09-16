using System;
using MyExampleLibrary.Objects;

namespace MyExampleLibrary.Instances
{
    //Here, every method is a menu.
    class Instance
    {
        public static int width = 60;
        public static int height = 15;
        public static void MainMenu()
        {
            Console.Clear();
            //On Start Declarations
            Console.Title = "MyExampleLibrary Console Edition";
            string title = "Menu Principal";
            string[] listMenu = { "1. OpenBasicCalculator", "2. ExampleUList1", "3. MiniGuessGame", "4.", "5.", "6.", "7.", "8.", "9.", "0. Salir" };
            Menu mainMenu = new Menu(title, 1, false, width, height);
            //Instance Loop
            while (true)
            {
                try
                {
                    Console.Clear();
                    Graphics.DrawMargin(mainMenu.sizex, mainMenu.sizey, mainMenu.instanceName, "red");
                    Graphics.DrawList(listMenu, width, height);
                    /*if (inputFailed)
                    {
                        Graphics.SetPoint(2, 12);
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("¡Debes escribir solo numeros!");
                        Console.ForegroundColor = ConsoleColor.Gray;
                    }*/

                    InstanceInput.MainMenu(false);

                }
                catch (SystemException)
                {
                    InstanceInput.MainMenu(true);
                }
                
            }
        }

        public static void Menu()
        {
            //On Start Declarations
            Console.Clear();
            Console.Title = "MyExampleLibrary Console Edition";
            string title = "Menu Principal";
            string[] listMenu = { "1. OpenBasicCalculator", "2. ExampleUList1", "3. MiniGuessGame", "4.", "5.", "6.", "7.", "8.", "9.", "0. Salir" };
            Menu mainMenu = new Menu(title, 1, false, width, height);
        }

        public static void Settings()
        {
            Menu settingsMenu = new Menu("Opciones", 2, false, 60, 25);
        }
    }
    class InstanceInput
    {
        public static void MainMenu(bool isfail)
        {
            if (isfail)
            {
                Graphics.SetPoint(2, 12);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("¡Debes escribir solo numeros!");
                Console.ForegroundColor = ConsoleColor.Gray;
                Graphics.SetPoint(2, 13);
                Console.Write("Elige una opción de la lista: ");
                char input = IO.GetCharKey();
            }
            else
            {
                Graphics.SetPoint(2, 13);
                Console.Write("Elige una opción de la lista: ");
                char input = IO.GetCharKey();
            }
        }
    }
}
