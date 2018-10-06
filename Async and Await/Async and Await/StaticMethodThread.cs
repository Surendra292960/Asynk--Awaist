using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Async_and_Await.Async_and_Await
{
    public class StaticMethodThread
    {
        public static void Thread1()
        {
            for (int i =  0; i<10; i++)
            {
                Console.WriteLine(i);
            }
        }
    }

    public class ThreadExample2
    {
        static void Main(string[] args)
        {
            Thread t1 = new Thread(new ThreadStart(StaticMethodThread.Thread1));
            Thread t2 = new Thread(new ThreadStart(StaticMethodThread.Thread1));
            t1.Start();
            t2.Start();
            Console.ReadLine();
        }
    }
}
