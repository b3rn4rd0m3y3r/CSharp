// Programa base C#
using System;

namespace HelloWorld
{
    class Hello {         
        static void Main(string[] args)
        {
		var frase = "123456789#ABCDEFGHI#JKLMNOPQR#STUVWXYZ";
		//Console.WriteLine(frase.Substring(10,4));
		//Console.WriteLine(frase.Substring(20,6));
		var itens = frase.Split('#');
		var i = 0;
		foreach(string item in itens){
			i = i + 1;
			Console.WriteLine($"{i.ToString()}:{item}");
			}
        }
    }
}