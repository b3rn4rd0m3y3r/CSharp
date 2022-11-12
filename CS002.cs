// Programa base C#
using System;

namespace HelloWorld
{
    class Hello {         
        static void Main(string[] args)
        {
		var frase = "123456789#ABCDEFGHI#JKLMNOPQR#";
		Console.WriteLine(frase.Substring(10,4));
		Console.WriteLine(frase.Substring(20,6));
		var itens = frase.Split('#');
		Console.WriteLine(itens[0]);
        }
    }
}