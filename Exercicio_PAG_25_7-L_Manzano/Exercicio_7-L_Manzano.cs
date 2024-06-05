using System;
using System.Globalization;
// Autor: Gabriel do Amaral Alves
// Data: 05/06/24
// Enunciado: 7-l) Elaborar um programa que efetue a leitura de três valores (A, B e C) e apresente como resultado final a soma dos quadrados dos três valores lidos.
namespace Exercicio_PAG_25_7_L_Manzano
{
    internal class Exercicio_7_L_Manzano
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa que efetua a leitura de três valores (A, B e C) e apresente como resultado final a soma dos quadrados dos três valores lidos");
            // Solicitar os valores ao usuário
            Console.Write("Digite o valor de A: ");
            string? inputA = Console.ReadLine();

            Console.Write("Digite o valor de B: ");
            string? inputB = Console.ReadLine();

            Console.Write("Digite o valor de C: ");
            string? inputC = Console.ReadLine();

            // Checando se algum campo está vazio
            if (string.IsNullOrWhiteSpace(inputA) || string.IsNullOrWhiteSpace(inputB) || string.IsNullOrWhiteSpace(inputC))
            {
                Console.WriteLine("Não pode haver nenhum campo nulo");
            }
            // Convertendo string para double
            else if (double.TryParse(inputA, NumberStyles.Float, CultureInfo.InvariantCulture, out double A) &&
                     double.TryParse(inputB, NumberStyles.Float, CultureInfo.InvariantCulture, out double B) &&
                     double.TryParse(inputC, NumberStyles.Float, CultureInfo.InvariantCulture, out double C))
            {
                // Calculando a soma dos quadrados
                double somaDosQuadrados = (A * A) + (B * B) + (C * C);

                // Exibindo o resultado
                Console.WriteLine($"A soma dos quadrados de A, B e C é: {somaDosQuadrados}");
            }
            else
            {
                Console.WriteLine("Entradas inválidas. Por favor, insira valores numéricos válidos.");
            }
        }
    }
}
