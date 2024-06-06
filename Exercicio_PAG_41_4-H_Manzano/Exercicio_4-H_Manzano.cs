using System;
using System.Diagnostics.Metrics;
// Autor: Gabriel do Amaral Alves
// Data: 06/06/24
/* Enunciado: 4-H) Efetuar a leitura de cinco números inteiros e identificar o maior e o menor valores.*/

namespace Exercicio_PAG_41_4_H_Manzano
{
    internal class Exercicio_4_H_Manzano
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Progrma que lê quatros numeros e apresenta se são divisíveis por 2 e 3");

            // Solicitar os valores ao usuário
            Console.Write("Digite o valor de A: ");
            string? inputA = Console.ReadLine();

            Console.Write("Digite o valor de B: ");
            string? inputB = Console.ReadLine();

            Console.Write("Digite o valor de C: ");
            string? inputC = Console.ReadLine();

            Console.Write("Digite o valor de D: ");
            string? inputD = Console.ReadLine();

            Console.Write("Digite o valor de D: ");
            string? inputE = Console.ReadLine();

            // Checando se algum campo está vazio
            if (string.IsNullOrWhiteSpace(inputA) || string.IsNullOrWhiteSpace(inputB) ||
                string.IsNullOrWhiteSpace(inputC) || string.IsNullOrWhiteSpace(inputD) ||
                string.IsNullOrWhiteSpace(inputE))
            {
                Console.WriteLine("Não pode haver um campo nulo.");
            }
            // Convertendo string para int
            else if (int.TryParse(inputA, out int numero01) &&
                    int.TryParse(inputB, out int numero02) &&
                    int.TryParse(inputC, out int numero03) &&
                    int.TryParse(inputD, out int numero04) &&
                    int.TryParse(inputE, out int numero05))
            {
                // Encontrar o menor número entre os 5
                int menor = numero01;
                if (numero02 < menor)
                {
                    menor = numero02;
                }
                if (numero03 < menor)
                {
                    menor = numero04;
                }
                if (numero04 < menor)
                {
                    menor = numero05;
                }
                if (numero05 < menor)
                {
                    menor = numero05;
                }

                // Encontrar o maior número entre os 5
                int maior = numero01;
                if (numero02 > menor)
                {
                    menor = numero02;
                }
                if (numero03 > menor)
                {
                    menor = numero04;
                }
                if (numero04 > menor)
                {
                    menor = numero05;
                }
                if (numero05 > menor)
                {
                    menor = numero05;
                }
            }
        }
    }
}
