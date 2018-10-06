using System;
using System.Threading;
using System.Threading.Tasks;

namespace Async_and_Await.Async_and_Await
{
    class AsAndAwait
    {
        static void Main(string[] args)
        {
            Method();
            Console.WriteLine("Main Thread");
            Console.ReadLine();
        }
        public static async void Method()
        {
            await Task.Run(new Action(LongTask));
            await Task.Run(new Action(DoTask));
            Console.WriteLine("New Thread");
        }
        public static void LongTask()
        {
            Console.WriteLine("LongTask is in processing...........");
            Thread.Sleep(3000); 
        }
        public static void DoTask()
        {
            Console.WriteLine("DoTask is in processing...........");
            Thread.Sleep(3000);
        }
    }
}
