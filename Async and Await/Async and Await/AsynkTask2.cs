using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Async_and_Await.Async_and_Await
{
    class AsynkTask2
    {
        public delegate void mymethod2(string a);
        static void Main(string[] args)
        {
            mymethod2 obj = new mymethod2(print);
            IAsyncResult tag = obj.BeginInvoke("Hello World",null, null);
            //IAsyncResult tag = obj.BeginInvoke(null, null);
            Console.WriteLine("I am not completed yet");
            obj.EndInvoke(tag);
            Console.WriteLine("Execution Over");
            Console.ReadLine();
        }

        public static void print(string param)
        {
            Thread.Sleep(3000);
            Console.WriteLine("Hello World");
        }

    }
}
