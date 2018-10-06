using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Async_and_Await.Async_and_Await
{
    public class JoinThread
    {
        public void Thread1()
        {
            for(int i=0; i<10; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(200);
            }
        }
    }

    public class ThreadExample6
    {
        static void Main(string[] args)
        {

            JoinThread mt = new JoinThread();

            Thread t1 = new Thread(new ThreadStart(mt.Thread1));
            Thread t2 = new Thread(new ThreadStart(mt.Thread1));
            Thread t3 = new Thread(new ThreadStart(mt.Thread1));

            t1.Start();
            t2.Start();
            t2.Join();
            t3.Start();

            Console.ReadLine();
        }
    }
}
