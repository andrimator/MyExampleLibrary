using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyExampleLibrary.Objects
{
    class Cock
    {
        public float size = 0;
        public string color = "default";
        public string name = "unnamed";

        public Cock () //Empty constructor
        {

        }

        public bool isBig() //Object Method - Determines if your cock is big
        {
            if(size > 30) return true;
            return false;
        }

        public bool isHuge() //Object Method - Determines if your cock is huge
        {
            if (size > 50) return true;
            return false;
        }

        public Cock (float aSize, string aColor, string aName) //3 argument constructor
        {
            size = aSize;
            color = aColor;
            name = aName;
            Console.WriteLine("Un nuevo Cock ha sido creado con éxito.");
        }
    }
    class Game
    {
        public string title;
        public string developer;
        private string rating;

        public Game(string aTitle, string aDev, string aRate)
        {
            title = aTitle;
            developer = aDev;
            rating = aRate;
        }

        public string Rating
        {
            get { return rating; }
            set
            {
                if (value == "A" || value == "B" || value == "C" || value == "D")
                {
                    rating = value;
                }
                else rating = "Empty";
            }
        }
    }
    class Player
    {
        public string name;
        public int age;
        public int health;

        public Player(string aName, int aAge, int aHealth)
        {
            name = aName;
            age = aAge;
            health = aHealth;
        }
    }
}
