using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyExampleLibrary.MiniGuessGame
{
    class Player
    {
        public int lives = 3;
        public int xp = 0;

        public Player(int aLives, int aXp)
        {
            lives = aLives;
            xp = aXp;
        }

    }
}
