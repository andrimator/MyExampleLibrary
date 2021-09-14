using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyExampleLibrary
{
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
