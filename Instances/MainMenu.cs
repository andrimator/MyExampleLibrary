using System;
using System.Collections.Generic;
using System.Text;

namespace MyExampleLibrary
{
    class MainMenu
    {
        public void DrawGUI()
        {
            //Este metodo dibujara el menu
        }

        public int GetInput()
        {
            int input = 0;
            Console.Write("Input: ");
            while (input == 0)
            {
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
