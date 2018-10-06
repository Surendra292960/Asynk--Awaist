using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Async_and_Await.Async_and_Await
{
    class Anonymous
    {
        public delegate void AnonymousFun();
        static void Main(string[] args)
        {
            AnonymousFun fun = delegate ()
            {
                Console.WriteLine("Anonymous function called");
            };
            fun();
            Console.ReadLine();
        }
    }
}
