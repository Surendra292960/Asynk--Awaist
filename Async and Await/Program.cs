using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Async_and_Await
{
    class Program
    {
        public static void Main()
            {
                Task<int> task = HandleFileAsync();
                Console.WriteLine("Please wait patiently " + "while I do something important.");
                string line = Console.ReadLine();
                Console.WriteLine("You entered (asynchronous logic): " + line);
                task.Wait();
                var x = task.Result;
                Console.WriteLine("Count: " + x);

                Console.WriteLine("[DONE]");
                Console.ReadLine();
            }
            static async Task<int> HandleFileAsync()
            {
                string file = @"g:\\AsynkAwait.txt";
                Console.WriteLine("HandleFile enter");
                int count = 0;
                using (StreamReader reader = new StreamReader(file))
                {
                    string v = await reader.ReadToEndAsync();
                    count += v.Length;
                    for (int i = 0; i < 10000; i++)
                    {
                        int x = v.GetHashCode();
                        if (x == 0)
                        {
                            count--;
                        }
                    }
                }
                Console.WriteLine("HandleFile exit");
                return count;
            }
    }
}
