using System;
using static System.Runtime.InteropServices.JavaScript.JSType;
// Autor: Gabriel do Amaral Alves
// Data: 06/06/24
/* Enunciado: 4-I) Elaborar um programa que efetue a leitura de um número inteiro e apresentar uma mensagem
informando se o número é par ou ímpar. */

namespace Exercicio_PAG_41_4_I_Manzano
{
    internal class Exercicio_4_I_Manzano
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Progrma que lê quatros numeros e apresenta se são divisíveis por 2 e 3");

            // Solicitar os valores ao usuário
            Console.Write("Digite um número: ");
            string? inputA = Console.ReadLine();

            // Checando se algum campo está vazio
            if (string.IsNullOrWhiteSpace(inputA))
            {
                Console.WriteLine("Não pode haver um campo nulo.");
            }
            // Convertendo string para int
            else if (int.TryParse(inputA, out int numero))
            {
                if (numero % 2 == 0)
                {
                    Console.WriteLine("O número digitado é Par");
                }
                else
                {
                    Console.WriteLine("O número digitado é Ímpar");
                }
            }
        }
    }
}
