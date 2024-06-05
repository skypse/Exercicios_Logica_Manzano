using System;
using System.Globalization;
// Autor: Gabriel do Amaral Alves
// Data: 05/06/24
// Enunciado: 1-A) Elaborar um programa de computador que efetue a leitura de quatro valores inteiros (variáveis A, B, C e D).
// Ao final o programa deve apresentar o resultado do produto (variável P) do primeiro com o terceiro valor,
// e o resultado da soma (variável S) do segundo com o quarto valor.

namespace Exercicio_PAG_26_3._10_1_A_Manzano
{
    internal class Exercicio_1_A_Manzano
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa que efetua a leitura de quatro valores inteiros (A, B, C e D) e apresenta como resultado final o produto do primeiro com o terceiro valor e a soma do segundo com o quarto valor.");

            // Solicitar os valores ao usuário
            Console.Write("Digite o valor de A: ");
            string? inputA = Console.ReadLine();

            Console.Write("Digite o valor de B: ");
            string? inputB = Console.ReadLine();

            Console.Write("Digite o valor de C: ");
            string? inputC = Console.ReadLine();

            Console.Write("Digite o valor de D: ");
            string? inputD = Console.ReadLine();

            // Checando se algum campo está vazio
            if (string.IsNullOrWhiteSpace(inputA) || string.IsNullOrWhiteSpace(inputB) ||
                string.IsNullOrWhiteSpace(inputC) || string.IsNullOrWhiteSpace(inputD))
            {
                Console.WriteLine("Não pode haver nenhum campo nulo");
            }
            // Convertendo string para int
            else if (int.TryParse(inputA, NumberStyles.Integer, CultureInfo.InvariantCulture, out int A) &&
                     int.TryParse(inputB, NumberStyles.Integer, CultureInfo.InvariantCulture, out int B) &&
                     int.TryParse(inputC, NumberStyles.Integer, CultureInfo.InvariantCulture, out int C) &&
                     int.TryParse(inputD, NumberStyles.Integer, CultureInfo.InvariantCulture, out int D))
            {
                // Calculando o produto do primeiro com o terceiro valor (P)
                int produtoP = A * C;

                // Calculando a soma do segundo com o quarto valor (S)
                int somaS = B + D;

                // Exibindo os resultados
                Console.WriteLine($"O produto de A e C (P) é: {produtoP}");
                Console.WriteLine($"A soma de B e D (S) é: {somaS}");
            }
            else
            {
                Console.WriteLine("Entradas inválidas. Por favor, insira valores numéricos inteiros.");
            }
        }
    }
}
