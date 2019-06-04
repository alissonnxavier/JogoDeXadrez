using System;
using Tabuleiro;

namespace Xadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Posicao p = new Posicao(3, 4);

            Console.WriteLine("Posiçoes: " + p);

            Console.ReadLine();
        }
    }
}
