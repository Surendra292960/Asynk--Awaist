using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Async_and_Await.Async_and_Await
{
    class AbortThread1
    {
        public void thread1()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(200);
            }
        }
    }

    public class ThreadExample5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start of Main");

            AbortThread1 mt = new AbortThread1();
            Thread t1 = new Thread(new ThreadStart(mt.thread1));
            Thread t2 = new Thread(new ThreadStart(mt.thread1));
            t1.Start();
            t2.Start();
            //try
            //{
                t1.Abort();
                t2.Abort();
            //}
            //catch(ThreadAbortException e)
            //{
            //    Console.WriteLine(e.ToString());
            //}
            //Console.WriteLine("End of Main");
            Console.Read();
        }
    }
}
