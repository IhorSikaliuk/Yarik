using System;
using System.Threading;

namespace Yarik
{
    class Program
    {
        static void Main(string[] args)
        {
            var target = "Hello World!";
            var i = 0;
            while (i < target.Length)
            {
                var symbol = RandomSymbol();
                Console.Write(symbol);
                Thread.Sleep(30);
                if (symbol == target[i])
                    i++;
                else
                    Backspace();
            }

            Console.ReadKey();
        }

        static char RandomSymbol()
        {
            var symbol = (char) ((new Random().Next()) % 95 + 32);
            return symbol;
        }

        static void Backspace()
        {
            Console.Write("\b \b");
        }
    }
}
