// Programa base C#
namespace Argumentos
{
	using System;

	class Argumentos {         
		static void Main(string[] args){
		int i = 0;
		foreach (string arg in args){  
			i++;
			Console.WriteLine($"{i} - {arg}");  
			} 
		}
	}
    }