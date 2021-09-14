using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyExampleLibrary
{
    class ClassesAndObjectsTests
    {
        static void ClassesObjsTestsMainMethod()
        {

            Console.Write("Enter your nickname: ");
            string nick = Console.ReadLine();
            

            Player player = new Player(nick, 15, 8);



            Console.WriteLine(player.name);
            Console.ReadLine();

        }
    }
}
