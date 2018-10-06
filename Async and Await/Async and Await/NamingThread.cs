using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Async_and_Await.Async_and_Await
{
    public class NamingThread
    {
        public void Thread1()
        {
            Thread t = Thread.CurrentThread;
            Console.WriteLine(t.Name + " is running");
        }
    }

    public class ThreadExample8
    {
        static void Main(string[] args)
        {
            NamingThread mt = new NamingThread();
            Thread t1 = new Thread(new ThreadStart(mt.Thread1));
            Thread t2 = new Thread(new ThreadStart(mt.Thread1));
            Thread t3 = new Thread(new ThreadStart(mt.Thread1));

            t1.Name = "Playe1";
            t2.Name = "Playe2";
            t3.Name = "Playe3";

            t1.Start();
            t2.Start();
            t3.Start();
            Console.ReadLine();
        }
    }
}
