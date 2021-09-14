using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyExampleLibrary.MiniGuessGame
{
    class Game
    {
        public static void LevelOne()
        {
            int lives = 3;
            int xp = 0;

            Player player = new Player(lives, xp);


            int level = 1;
            int levelStreak = 0;


            string question = "";
            string answer = "";

            do
            {
                Console.Clear();
                if (level == 0) level = 1;
                Console.WriteLine("You have: " + player.lives + " lives left.");
                Console.ReadLine();
                switch (level)
                {
                    case 1:
                        question = "Who is the original creator of Minecraft?";
                        answer = "notch";
                        if (showQuestion(question, answer, 3)) { level = levelUp(level, player.lives); levelStreak++; }
                        else { level = levelFail(level, player.lives); player.lives--; levelStreak = 0; }
                        break;
                    case 2:
                        question = "In what year was Minecraft 1.0 originally released?";
                        answer = "2011";
                        if (showQuestion(question, answer, 3)) { level = levelUp(level, player.lives); levelStreak++; }
                        else { level = levelFail(level, player.lives); player.lives--; levelStreak = 0; }
                        break;
                    case 3:
                        question = "What year is right now?";
                        answer = "2021";
                        if (showQuestion(question, answer, 3)) { level = levelUp(level, player.lives); levelStreak++; }
                        else { level = levelFail(level, player.lives); player.lives--; levelStreak = 0; }
                        break;
                    case 4:
                        question = "De que color es el cielo?";
                        answer = "azul";
                        if (showQuestion(question, answer, 3)) { level = levelUp(level, player.lives); levelStreak++; }
                        else { level = levelFail(level, player.lives); player.lives--; levelStreak = 0; }
                        break;
                    default:
                        break;
                }
                if (lives == -1)
                {
                    level = 1;
                    Console.WriteLine("You Lost the Game! Please restart to try again!");
                    Console.WriteLine("Press any key to restart...");
                    Console.ReadLine();
                }
                if (levelStreak == 3) { lives++; levelStreak = 0; }

            } while (true);
        }

        static bool showQuestion(string question, string answer, int gLimit)
        {
            int gCount = 0;
            string guess = "";
            bool fail = false;
            do
            {
                if (gCount < gLimit)
                {
                    Console.Clear();
                    Console.Write("Intento: " + (gCount + 1) + " | " + question + ": ");
                    guess = Console.ReadLine();
                    gCount++;
                }
                else fail = true;

            } while (guess != answer && !fail);

            if (fail) return false;
            else return true;
        }

        static int levelUp(int level, int lives)
        {
            level++;
            string rightAnswer = "You're right! Lets keep going...";
            Console.WriteLine(rightAnswer);
            Console.ReadLine();
            return level;
        }

        static int levelFail(int level, int lives)
        {
            level--;
            string wrongAnswer = "Im sorry.. You Lose! - [" + lives + " lives left]";
            Console.WriteLine(wrongAnswer);
            Console.ReadLine();
            return level;
        }
    }
}
