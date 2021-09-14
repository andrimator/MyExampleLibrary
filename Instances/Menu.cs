using System;
using System.Collections.Generic;
using System.Text;

namespace MyExampleLibrary
{
    public class Menu
    {
        #region Variables
        public string instanceName;
        public int id;
        public int elements;
        public bool debug;
        public int sizex;
        public int sizey;
        private string mode;
        public string Mode
        {
            get { return mode; }
            set
            {
                if (value == "main" || value == "settings" || value == "3" || value == "4")
                {
                    mode = value;
                }
                else mode = "0";
            }
        }
        #endregion
        #region Constructores
        public Menu(string aname, int aid, bool debugMode, int sizeX, int sizeY)
        {//Menu Constructor
            instanceName = aname;
            id = aid;
            debug = debugMode;
            sizex = sizeX;
            sizey = sizeY;
        }
        public Menu(string aname, int aid, bool debugMode, int sizeX, int sizeY, string mode)
        {//Menu Constructor
            instanceName = aname;
            id = aid;
            debug = debugMode;
            sizex = sizeX;
            sizey = sizeY;
            Mode = mode;
        }
        #endregion
        public void Initialize()
        {
            Graphics.DrawMargin(sizex,sizey,instanceName);
        }
        public void LoadList(string[] list, int elements)
        {
            Console.SetCursorPosition(0,1);
            Console.WriteLine(list[0]);
            Console.WriteLine(list[1]);
            Console.WriteLine(list[2]);
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
    public class Graphics
    {
        public static void DrawMargin(int x, int y, string name)
        {
            int tx, ty;
            tx = x; ty = y;
            //Este metodo dibujara el menu en X
            Console.SetCursorPosition(0, 0);
            for (int i = 0; i <= x; i++)
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
            Console.SetCursorPosition((x - name.Length) / 2, 0);
            Console.Write("["+name+"]");
            //Footer
            name = "[created by andrimator]";
            Console.SetCursorPosition((x - name.Length) / 2, y);
            Console.Write(name);
        }
    }
}
