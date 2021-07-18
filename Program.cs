using System;

namespace RPS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to rock paper scissors");
            var g = new Game();
            g.Start();
        }
    }
}
