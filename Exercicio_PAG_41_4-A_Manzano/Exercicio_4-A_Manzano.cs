using System;
using System.Globalization;
// Autor: Gabriel do Amaral Alves
// Data: 06/06/24
/* Enunciado: 4-A) Ler dois valores numéricos inteiros e apresentar o resultado da diferença do maior pelo menor valor..*/

namespace Exercicio_PAG_41_4_A_Manzano
{
    internal class Exercicio_4_A_Manzano
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa que lê dois valores inteiros e apresenta a diferença do maior pelo menor valor.");

            // Solicitar os valores ao usuário
            Console.Write("Digite o primeiro valor: ");
            string? inputValor1 = Console.ReadLine();

            Console.Write("Digite o segundo valor: ");
            string? inputValor2 = Console.ReadLine();

            // Checando se algum campo está vazio
            if (string.IsNullOrWhiteSpace(inputValor1) || string.IsNullOrWhiteSpace(inputValor2))
            {
                Console.WriteLine("Não pode haver um campo nulo");
            }
            // Convertendo string para int
            else if (int.TryParse(inputValor1, NumberStyles.Integer, CultureInfo.InvariantCulture, out int valor1) &&
                     int.TryParse(inputValor2, NumberStyles.Integer, CultureInfo.InvariantCulture, out int valor2))
            {
                // Calculando a diferença entre o maior e o menor valor
                int diferenca;
                if (valor1 > valor2)
                {
                    diferenca = valor1 - valor2;
                }
                else
                {
                    diferenca = valor2 - valor1;
                }
                Console.WriteLine($"A diferença entre o maior e o menor valor é: {diferenca}");
            }
            else
            {
                Console.WriteLine("Entradas inválidas. Por favor, insira valores numéricos inteiros.");
            }
        }
    }
}
