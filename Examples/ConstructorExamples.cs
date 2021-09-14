using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyExampleLibrary.Objects;

namespace MyExampleLibrary
{
    /*Using:
     * Objects.cs
     */

    class ConstructorExamples
    {
        static void ConstructorExamplesMethod()
        {

            Game Halo = new Game("Halo", "Xbox", "A");

            VectorTestings();
           

        }


        static void VectorTestings()
        {
            Vector2D playerPosition = new Vector2D();
            playerPosition.x = 5;

            playerPosition.CheckPos();

            Console.ReadLine();
        }

        static void CreateNewCock()
        {
            Console.Write("Choose your cock's name: ");
            string cockName = Console.ReadLine();
            Console.Write("Choose your cock's size: ");
            float cockSize = Convert.ToInt32(Console.ReadLine());
            Console.Write("Choose your cock's color: ");
            string cockColor = Console.ReadLine();

            Cock userCock = new Cock(cockSize, cockColor, cockName);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Here are your cock details: ");
            Console.WriteLine("\nName: " + userCock.name + ". Size: " + userCock.size + "cm. Color: " + userCock.color);


            if (userCock.isBig() && !userCock.isHuge()) Console.WriteLine("Holy fuck your cock is big!");
            if (userCock.isHuge()) Console.WriteLine("HOLY FUCK YOUR COCK IS HUGE!!");

            Console.ReadLine();
        }
    }
}
