// Programa base C#
using System;

namespace HelloWorld
{
    class Hello {         
        static void Main(string[] args)
        {
		var date = DateTime.Now;
		Console.WriteLine(date);
		Console.WriteLine($"Data e Hora: {date}");
        }
    }
}