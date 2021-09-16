using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyExampleLibrary
{
    class AsyncAwaitTasks
    {
        public static void Initialize()
        {
            AsyncTest1();
            Console.ReadLine();
        }
        static async void AsyncTest1()
        {
            int i = 0;

            await Task.Run(() => 
            {
                i = 3;

            
            });

            Console.WriteLine(i);
        }
    }
}
