// Programa base C#
using System;

namespace HelloWorld
{
    class Hello {         
        static void Main(string[] args)
        {
		var obj = (Prop1: "propriedade1", Prop2: "propriedade2");
		Console.WriteLine(obj);
		Console.WriteLine($"Propriedade 1 {obj.Prop1}");
        }
    }
}