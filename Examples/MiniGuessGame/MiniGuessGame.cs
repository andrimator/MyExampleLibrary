using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyExampleLibrary.MiniGuessGame
{
    class MiniGuessGame
    {
        static void Initialize()
        {
            while(true)
            {
                Console.Clear();
                DrawSeparator(35);
                Console.WriteLine("\nUnknown.exe | v0.1-alpha");
                DrawSeparator(35);
                Console.WriteLine("\nBienvenido a la primera edición de Unknown.exe\nPor favor, elige una de las siguientes opciones: ");

                MenuSelect();
            }
        }

        static void MenuSelect()
        {
            Console.Write("\nElige una opción: ");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1": //Start the game
                    StartGame();
                    break;
                case "2": //Start the game
                    StartGame();
                    break;
                default:
                    Console.WriteLine("Por favor escribe una opcion valida!");
                    break;
            }
        }

        static void StartGame()
        {
            //Comienza nivel 1
            Game.LevelOne();
        }

        //Dibujar Separación
        static void DrawSeparator(int lenght)
        {
            for (int i = 0; i <= lenght; i++)
            {
                Console.Write("-");
            }
        }
    }
}
