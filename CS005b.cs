// Programa base C#
using System;
using System.IO;

namespace arquivo
{
    class arquivo {         
        static void Main(string[] args)
        {
		string texto = File.ReadAllText("arq.csv");
		texto = texto.Replace("\r", "");
		var itens = texto.Split('\n');
		var i = 0;
		decimal soma = 0.0m;
		string[] cols;
		foreach(string item in itens){
			i++;
			if( item != "" ){
				Console.WriteLine($"{i} - {item}");
				cols = (item.ToString()).Split(';');
				if( i > 1 ){
					soma = soma + Convert.ToDecimal(cols[3]);
					}
				}
			}
		Console.WriteLine($"Soma - {soma}");
        }
    }
}