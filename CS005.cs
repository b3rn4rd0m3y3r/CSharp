// Programa base C#
using System;
using System.IO;

namespace arquivo
{
    class arquivo {         
        static void Main(string[] args)
        {
		string texto = File.ReadAllText("arq.csv");
		Console.WriteLine(texto);
        }
    }
}