/*
 * Created by SharpDevelop.
 * User: marco
 * Date: 26/02/2022
 * Time: 11:15
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace SaldoCreditoEspecial
{
	class Program
	{
		public static void Main(string[] args)
		{
			float porcento;
			float resultado; 
		
			Console.WriteLine("Escreva seu saldo médio: ");
			float saldo = float.Parse (Console.ReadLine());
			
			if (saldo < 201){
			Console.WriteLine("Seu saldo está baixo para ter crédito especial ");
			}

			else if (saldo >= 200 & saldo <= 400){
			porcento = (saldo * 20/100);
			resultado = (saldo + porcento);
			Console.WriteLine("Crédito especial: " + porcento);
		    Console.WriteLine();
			Console.WriteLine("Seu crédito especial junto com o saldo, o total é de: " + resultado);
			}
			
			else if (saldo >= 401 & saldo <= 600){
			porcento = (saldo * 30/100);
			resultado = (saldo + porcento);
			Console.WriteLine("Crédito especial: " + porcento);
			Console.WriteLine();
			Console.WriteLine("Seu crédito especial junto com o saldo, o total é de: " + resultado);
							
			}
		
			else {
				porcento = (saldo * 40/100);
				resultado = (saldo + porcento);
				Console.WriteLine("Crédito especial: " + porcento);
				Console.WriteLine("Seu crédito especial junto com o saldo, o total é de: " + resultado);
							
					
			}
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}