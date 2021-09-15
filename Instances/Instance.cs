using System;
using MyExampleLibrary.Objects;

namespace MyExampleLibrary
{
    //Here, every method is a menu.
    class Instance
    {
        public static int width = 60;
        public static int height = 15;
        public static void MainMenu()
        {
            Console.Title = "MyExampleLibrary Console Edition";
            string title = "Menu Principal";
            string[] listMenu = { "1. OpenBasicCalculator", "2. ExampleUList1", "3. MiniGuessGame", "4.", "5.", "6.", "7.", "8.", "9.", "0. Salir" };
            Menu mainMenu = new Menu(title, 1, false, width, height);
            Graphics.DrawMargin(mainMenu.sizex, mainMenu.sizey, mainMenu.instanceName, "red");
            Graphics.DrawList(listMenu, width, height);
            Graphics.SetPoint(2,13);
            Input.GetInt();

            Console.ReadLine();
        }

        public static void Settings()
        {
            Menu settingsMenu = new Menu("Opciones", 2, false, 60, 25);
        }
    }
    public class Input
    {
        public static int GetInt()
        {
            int input = 0;
            while (input == 0)
            {
                Console.Write("Elige una opción de la lista: ");
                try
                {
                    input = Convert.ToInt32(Console.ReadLine());
                }
                catch (SystemException)
                {

                }
            }
            return input;
        }
    }
}
