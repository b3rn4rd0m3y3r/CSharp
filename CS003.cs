// Programa base C#
namespace Processos
{
	using System;
	using System.Data;
	using System.Diagnostics;
	using System.Linq;
	using System.Management;
	class Processos {         
		static void Main(string[] args)
		{
		Process[] processCollection = Process.GetProcesses().OrderBy(m=>m.ProcessName).ToArray();  
		var nomeP = "";
		var idP = 0;
		var pgmP = "";
		var pgsmP = "";
		foreach (Process p in processCollection)  
		{  
			nomeP = p.ProcessName;
			idP = p.Id;
			pgmP = (p.PagedMemorySize64).ToString();
			pgsmP = (p.PagedSystemMemorySize64).ToString();
			if( String.Compare(nomeP, "svchost") != 0  ){
				Console.WriteLine($"{nomeP} - {idP} - {pgmP} - {pgsmP}");  
				}
			} 

		}
	}
    }