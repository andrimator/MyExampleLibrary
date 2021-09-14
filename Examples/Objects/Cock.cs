using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyExampleLibrary
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
}
