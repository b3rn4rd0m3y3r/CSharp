// Programa base C#
using System;

namespace entrada
{
    class entrada {         
        static void Main(string[] args)
        {
		Console.WriteLine("Seu nome: ");
		var nome = Console.ReadLine();
		Console.WriteLine($"Hello {nome}");
        }
    }
}