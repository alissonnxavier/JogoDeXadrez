using System;
using Tabuleiro;

namespace Xadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Board tab = new Board(8, 8);

            Tela.imprimirTabuleiro(tab);
        }
    }
}
