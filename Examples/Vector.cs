using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyExampleLibrary
{
    class Vector3D
    {
        public double x = 0;
        public double y = 0;
        public double z = 0;



        public void CheckPos()
        {
            Console.WriteLine(x + "" + y + "" + z);
        }
    }

    class Vector2D
    {
        public double x = 0;
        public double y = 0;

        public void CheckPos()
        {
            Console.WriteLine("X: " + x + ", Y: " + y);
        }
    }
}
