using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Async_and_Await.Async_and_Await
{
   public class PriorityThread
    {
        public void Thread1()
        {
            Thread t = Thread.CurrentThread;
            Console.WriteLine(t.Name + "is running");
        }
    }

    public class ThreadExample7
    {
        public static void Main(string[] args)
        {
            PriorityThread mt = new PriorityThread();

            Thread t1 = new Thread(new ThreadStart(mt.Thread1));
            Thread t2 = new Thread(new ThreadStart(mt.Thread1));
            Thread t3 = new Thread(new ThreadStart(mt.Thread1));
            t1.Name = "Player1";
            t2.Name = "Player2";
            t3.Name = "Player3";

            t3.Priority = ThreadPriority.Highest;
            t2.Priority = ThreadPriority.Normal;
            t1.Priority = ThreadPriority.Lowest;

            t1.Start();
            t2.Start();
            t3.Start();
            Console.ReadLine();
        }
    }
}
