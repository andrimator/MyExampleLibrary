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
        public void Initialize() //When the menu is created.
        {
        }
        public void GetUserInput(string[] list, int elements)
        {
        }
        public static void Exit()
        {

        }
    }
    public class Graphics
    {
        public static bool usingMargin;
        public static void SetPoint(int x, int y) { Console.SetCursorPosition(x, y); }
        public static void Draw(string text) { Console.Write(text); }
        public static void DrawMargin(int x, int y, string name, string titleColor)
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
            //Window 
            switch (titleColor)
            {
                case "green": Console.ForegroundColor = ConsoleColor.Green; break;
                case "red": Console.ForegroundColor = ConsoleColor.Red; break;
                default: break;
            }
            Console.SetCursorPosition((x - name.Length) / 2, 0);
            Console.Write("["+name+"]");
            //Footer
            Console.ForegroundColor = ConsoleColor.White;
            name = "[created by andrimator]";
            Console.SetCursorPosition((x - name.Length) / 2, y);
            Console.Write(name);
            usingMargin = true;
        }
        public static void DrawList(string[] list, int posX, int posY)
        {
            int[] startPos = { 0, 0 };
            int x, y;
            x = posX;
            y = posY;
            startPos[0] = x;
            startPos[1] = y;
            x = 2; y = 2;
            try
            {
                SetPoint(x, y); Draw(list[0]);
                SetPoint(x, y + 1); Draw(list[1]);
                SetPoint(x, y + 2); Draw(list[2]);
                SetPoint(x, y + 3); Draw(list[3]);
                SetPoint(x, y + 4); Draw(list[4]);
                SetPoint(x, y + 5); Draw(list[5]);
                SetPoint(x, y + 6); Draw(list[6]);
                SetPoint(x, y + 7); Draw(list[7]);
                SetPoint(x, y + 8); Draw(list[8]);
                SetPoint(x, y + 9); Draw(list[9]);
            }
            catch (SystemException)
            {

            }
            
        }
        public static int GetInputInt(int posx, int posy)
        {
            int input = 0;
            bool validData = false;
            while (validData == false)
            {
                SetPoint(posx, posy);
                Console.Write("Elige una opción de la lista: ");
                try
                {
                    input = Convert.ToInt32(Console.ReadLine());
                    switch (input)
                    {
                        case 0 & 1 & 2 & 3 & 4 & 5 & 6 & 7 & 8 & 9:
                            validData = true;
                            break;
                        default:
                            Graphics.SetPoint(posy, posx);
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("¡Debes escribir un numero de la lista");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            break;
                    }
                }
                catch (SystemException)
                {
                    Graphics.SetPoint(posy, posx);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("¡Debes escribir solo numeros!");
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
            }
            return input;
        }


    }
}
