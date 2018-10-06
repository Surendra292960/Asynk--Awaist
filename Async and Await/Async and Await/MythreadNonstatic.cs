using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Async_and_Await.Async_and_Await
{
   public class MythreadNonstatic
    {
        public static void Thread1()
        {
            for(int i=0;i<10; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
    public class ThreadExample
    {
        public static void Main()
        {
            MythreadNonstatic mt = new MythreadNonstatic();
            Thread t1 = new Thread(new ThreadStart(Async_and_Await.MythreadNonstatic.Thread1));
            Thread t2 = new Thread(new ThreadStart(Async_and_Await.MythreadNonstatic.Thread1));
            t1.Start();
            t2.Start();

            Console.Read();
        }
    }
}
