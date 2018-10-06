using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Async_and_Await.Async_and_Await
{
    class TaskCancel
    {
        static CancellationTokenSource tokenSource = new CancellationTokenSource();
        public static void Main(string[] args)
        {
            TaskTest();
            System.Console.WriteLine("main thread is not blocked");
            var input = Console.ReadLine();
            if (input == "stop")
            {
                tokenSource.Cancel();
                System.Console.WriteLine("task stopped");
            }
            Console.ReadLine();
        }
        private static async void TaskTest()
        {
            try
            {
                await Task.Delay(5000, tokenSource.Token);
            }
            catch (TaskCanceledException e)
            {
                //cancel task will throw out a exception, just catch it, do nothing.
            }
            System.Console.WriteLine("task done");
        }
    }
}
