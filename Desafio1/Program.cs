using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            while(N-- > 0)
            {
                int val = Convert.ToInt32(Console.ReadLine());
                int newval = (int)Math.Sqrt(val);
                int resposta = val - newval;
                Console.WriteLine(resposta);
            }
        }
    }
}
