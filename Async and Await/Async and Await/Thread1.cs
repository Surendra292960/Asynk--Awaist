using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Async_and_Await.Async_and_Await
{
    class Thread1
    {
        static void Main(string[] args)
        {
            Thread t = Thread.CurrentThread;
            t.Name = "Main Thread";
            Console.WriteLine(t.Name);
            Console.WriteLine("Current executing thread is: " + Thread.CurrentThread);
            Console.Read();
        }
    }
}
