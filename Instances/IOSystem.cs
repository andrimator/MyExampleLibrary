using System;
using System.Threading.Tasks;

namespace MyExampleLibrary
{
    class IOSystem
    {
        public static void TestZone()
        {
            Console.WriteLine(IO.GetCharKey());
            Console.ReadLine();
        }
        public static void Initialize()
        {

        }
        public static async void OldInitialize()
        {
            await Task.Run(() => 
            {
                while (true)
                {
                    GetKey();
                }
                
            });
        }
        static string GetKey()
        {
            if (Console.KeyAvailable)
            {
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.A:
                        Console.Write("a");
                        return "a";
                    default:
                        break;
                }
            }
            return "N/A";
        }
    }
    class IO
    {
        public static char GetCharKey()
        {
            char[] input;
            string strinput;
            char output;
            strinput = Console.ReadLine().ToLower();
            input = strinput.ToCharArray();
            output = input[0];
            return output;
        }
    }
}
