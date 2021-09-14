using System;
using System.Collections.Generic;
using System.Text;

namespace MyExampleLibrary.Instances
{
    public class Menu
    {
        public string instanceName;
        public int id;
        public int elements;
        public bool debug;
        public int sizex;
        public int sizey;

        public Menu(string aname, int aid, bool debugMode, int sizeX, int sizeY)
        {//Menu Constructor
            instanceName = aname;
            id = aid;
            debug = debugMode;
            sizex = sizeX;
            sizey = sizeY;
        }
        public void Initialize()
        {
            DrawMargin(sizex,sizey,instanceName);
            Input.GetInt();
        }
        private static void DrawMargin(int x, int y, string name)
        {
            int tx, ty;
            tx = x; ty = y;
            //Este metodo dibujara el menu en X
            Console.SetCursorPosition(0,0);
            for(int i = 0; i <= x; i++)
            {
                Console.Write("=");
            }
            Console.SetCursorPosition(0, y);
            for (int i = 0; i <= x; i++)
            {
                Console.Write("=");
            }
            for (int i = 0; i <= y; i++)
            {
                Console.SetCursorPosition(x, ty);
                Console.Write("|");
                ty--;
            }
            ty = y;
            for (int i = 0; i <= y; i++)
            {
                Console.SetCursorPosition(0, ty);
                Console.Write("|");
                ty--;
            }
            //Window Name
            Console.SetCursorPosition((x - name.Length)/2, 0);
            Console.Write(name);
        }

        
    }
    public class Input
    {
        public static int GetInt()
        {
            Console.SetCursorPosition(2,2);
            int input = 0;
            Console.Write("Input: ");
            while (input == 0)
            {
                Console.Write(" [Error] Input: ");
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
