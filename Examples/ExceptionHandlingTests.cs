using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyExampleLibrary
{
    class ExceptionHandlingTests
    {
        public static void Initialize()
        {
            Console.Clear();
            Console.SetCursorPosition(0, 0);
            try
            {
                Console.Write("Enter a number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter another number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(num1 / num2);
            }
            catch (DivideByZeroException e) //If you declare an Exception and it respective name, you will display all kind of exceptions that could happen
            //otherwise if you declare an specific exception you will be able only to catch and handle that issue, otherwise the program will crash.
            //Specific exception example: (DivideByZeroException e)
            {
                Console.WriteLine("[MATH-ERROR] " + e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine("[FORMAT-ERROR] " + e.Message);
            }
            finally
            {

            }

            Console.ReadLine();
        }
    }
}
