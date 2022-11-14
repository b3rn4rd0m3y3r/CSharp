// Programa base C#
using System;

namespace entrada
{
    class entrada {         
        static void Main(string[] args)
        {
		Console.WriteLine("Sua idade: ");
		var idade = Console.ReadLine();
		Console.WriteLine($"Você tem {idade} anos.");
		
		Console.WriteLine("Sua idade: ");
		int vIdade = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine($"Você tem {vIdade} anos.");
        }
    }
}