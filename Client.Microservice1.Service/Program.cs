using System;
using System.Threading;

namespace Client.Microservice1.Service
{
    class Program
    {
        // ReSharper disable once FunctionNeverReturns
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("Hello, Microservice1!");
                Thread.Sleep(1000);
            }
        }
    }
}
