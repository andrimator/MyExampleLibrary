using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyExampleLibrary
{
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
            set {
                if (value == "A" || value == "B" || value == "C" || value == "D")
                {
                    rating = value;
                }
                else rating = "Empty";
            }
        }
    }
}
