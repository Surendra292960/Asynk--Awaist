using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Async_and_Await.Async_and_Await
{
    public class MyThread
    {
        public static void Thread1()
        {
            Console.WriteLine("task one");
        }

        public static void Thread2()
        {
            Console.WriteLine("task two");
        }
    }

    public class ThreadExample3
    {
        static void Main(string[] args)
        {
            Thread t1 = new Thread(new ThreadStart(MyThread.Thread1));
            Thread t2 = new Thread(new ThreadStart(MyThread.Thread2));
            t1.Start();
            t2.Start();
            Console.Read();
        }
    }
}
