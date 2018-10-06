using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Async_and_Await.Async_and_Await
{
    //used to create local function
    //with delegate that can passed as an argument
    class Lambda
    {
        delegate int Square(int num);

        static void Main(string[] args)
        {
            Square GetSquare = x => x * x;
            int j = GetSquare(5);
            Console.WriteLine("Square:"+j);
            Console.ReadLine();
        }
    }
}
