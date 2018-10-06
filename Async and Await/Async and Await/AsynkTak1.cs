using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Async_and_Await.Async_and_Await
{
    class AsynkTak1
    {
        public delegate void mymethod();
        static void Main(string[] args)
        {
            mymethod inv = new mymethod(print);
            inv.BeginInvoke(null, null); //Asynchronous calling
            Console.WriteLine("I am Back");
            Console.Read();
        }

        public static void print()
        {
            Thread.Sleep(1000);
            Console.WriteLine("Hello World");
        }
    }
}
