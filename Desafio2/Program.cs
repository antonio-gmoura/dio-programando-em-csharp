using System;

namespace Desafio6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            long r;
            for (int p = 2; p <= n; p+=2)
            {
                r = (p * p);
                Console.WriteLine($"{p}^2 = {r}");
            }
        }
    }
}
