﻿using System;
using MyExampleLibrary.Objects;

namespace MyExampleLibrary
{
    //Here, every method is a menu.
    class Instance
    {
        public static int width = 60;
        public static int height = 25;
        public static void MainMenu()
        {
            string title = "Menu Principal";
            string[] listMenu = { "1. OpenBasicCalculator", "2. ExampleUList1", "3. MiniGuessGame", "4.", "5.", "6.", "7.", "8.", "9.", "0. Salir" };
            Menu mainMenu = new Menu(title, 1, false, width, height);
            Graphics.DrawMargin(mainMenu.sizex, mainMenu.sizey, mainMenu.instanceName, "green");
            Graphics.DrawList(listMenu, width, height);
            Console.ReadLine();
        }

        public static void Settings()
        {
            Menu settingsMenu = new Menu("Opciones", 2, false, 60, 25);
        }
    }    
}