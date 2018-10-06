using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Async_and_Await.Async_and_Await
{
   public  class SleepThread1
    {
        public void Thread1()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
                //Thread.Sleep(3000);
                Thread.SpinWait(3000);
            }
        }
    }

    public class ThreadExample4
    {
        static void Main(string[] args)
        {
            SleepThread1 mt = new SleepThread1();
            Thread t1 = new Thread(new ThreadStart(mt.Thread1));
            Thread t2 = new Thread(new ThreadStart(mt.Thread1));
            t1.Start();
            t2.Start();
            Console.ReadLine();
        }
    }
}
