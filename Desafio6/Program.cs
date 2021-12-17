using System;

namespace Desafio6
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            x += (x % 2 == 0 ? 2 : 1);
            Console.WriteLine(x);
        }
    }
}
