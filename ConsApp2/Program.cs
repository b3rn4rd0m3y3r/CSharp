﻿internal class Program
{
    public Program()
    {
    }

    private static void Main(string[] args)
    {
        string texto = File.ReadAllText("arq.csv");
        texto = texto.Replace("\r", "");
        var itens = texto.Split('\n');
        var i = 0;
        foreach (string item in itens)
        {
            i++;
            if (item != "")
            {
                Console.WriteLine($"{i} - {item}");
            }
        }
    }
}