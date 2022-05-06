using System;
using System.Collections.Generic;

namespace _10_nomes
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nomes = new string[10];

            for(int i = 0; i < nomes.Length; i++)
            {
                Console.WriteLine("insira um nome");
                nomes[i] = Console.ReadLine();
            }

            for(int i = 0; i < nomes.Length; i++)
            {
                Console.WriteLine($"os nomes da sua lista são: {nomes[i]} ");
            }
            




        }
    }
}
