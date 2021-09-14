using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Operadores != && ||

namespace MyExampleLibrary
{
    class ExampleUList1
    {
        public static void Initialize()
        {
            //Bienvenido al Hub, sientate y ponte cómodo..
            //Exercise1(true, true);
            //GetMax2(23, 65);
            //GetMax3(23, 4443, 23445);
            WhileLoops();

            Array2D();

            Console.ReadLine();
        }

        //Métodos:

        static void Array2D()
        {
            //Bidimentional Array
            int[,] numberGrid =
            {       /*Y- Y- Y*/
                /*X*/{1, 2, 3},
                /*X*/{4, 5, 6},
                /*X*/{7, 8, 9},
            };

            //ConsoleWriteLine(variable[x, y]);
            Console.WriteLine(numberGrid[0, 1]);
        } //Exercise 7: 2D Arrays [x, y]

        static int GetPow(int baseNum, int powNum)
        {
            int result = 1;

            for(int i = 0; i < powNum; i++)
            {
                result = result * baseNum;
            }

            return result;
        } //Exercise 6: Elevating numbers with exponents using for loops.

        static void SimpleGuessGame()
        {
            int level = 1;
            string answerWord = "notch";
            string guess = "";
            int guessCount = 0;
            int guessLimit = 5;
            bool outOfGuesses = false;

            do
            {
                if(guessCount < guessLimit)
                {
                    Console.Write("Who is the original creator of Minecraft?: ");
                    guess = Console.ReadLine();
                    guessCount++;
                }
                else
                {
                    outOfGuesses = true;
                }

            } while (guess != answerWord && !outOfGuesses);

            if(outOfGuesses) Console.WriteLine("Im sorry.. you lose!");
            else Console.WriteLine("You're right! Lets keep going...\nPress any key to continue.");
            level++;

            answerWord = "2011";


        } //Exercise 5: Basic 1Answer GuessGame

        static void WhileLoops()
        {
            int index = 1;

            //While Loop
            while (index <= 5) //You check first the condition.
            {
                Console.WriteLine(index); //Then you execute the code ;)
                index++;
            }

            //Do While Loop
            do //Executes the code first.
            {
                Console.WriteLine(index);
                index++;
            } while (index <= 5); //Then checks the condition, if false, it breaks.

        } //Exercise 4: Do While / While Loops

        static int GetMax3(int num1, int num2, int num3) //Exercise 3: Get Bigger Number (3 vars) (Comparison > nums)
        {
            int result;
            if (num1 >= num2 && num1 >= num3) result = num1;
            else if(num2 >= num1 && num2 >= num3) result = num2;
            else result = num3;
            return result;
        }

        static int GetMax2(int num1, int num2) //Exercise 2: Get Bigger Number (2 vars) (Comparison > nums)
        {
            int result;
            if (num1 > num2) result = num1;
            else result = num2;


            return result;
        }

        static void Exercise1(bool guapo, bool alto)
        {
            //Si guapo: TRUE y alto: TRUE, se ejecuta.
            if (guapo && alto)
            {
                Console.WriteLine("Eres guapo y alto.");
            } else if (!guapo && alto) { //Si guapo: FALSE y alto: TRUE, se ejecuta.
                Console.WriteLine("Eres alto pero no eres guapo...");
            } else if (guapo && !alto) { //Si guapo: TRUE y alto: FALSE, se ejecuta.
                Console.WriteLine("Eres guapo pero no eres alto....");
            } else Console.WriteLine("No eres nada...");
        } // Exercise 1 - If Statements - BASIC
    }
}
