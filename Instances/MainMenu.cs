using System;
using System.Collections.Generic;
using System.Text;

namespace MyExampleLibrary
{
    public class MainMenu
    {
        public static int Elements = 5;


        public static void Initialize()
        {
            DrawGUI();
            GetInput();
        }


        public static void DrawGUI()
        {
            //Este metodo dibujara el menu
        }

        public static int GetInput()
        {
            int input = 0;
            Console.Write("Input: ");
            while (input == 0)
            {
                Console.Write("[Error] Input: ");
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
