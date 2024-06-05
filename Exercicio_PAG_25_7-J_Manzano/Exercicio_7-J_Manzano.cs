using System;
using System.Globalization;
// Autor: Gabriel do Amaral Alves
// Data: 05/06/24
// Enunciado: 7-J) Elaborar um programa que efetue a apresentação do valor da conversão em real de um valor lido em dólar.
// O programa deve solicitar o valor da cotação do dólar e também a quantidade de dólares disponível com o usuário, para que seja apresentado o valor em moeda brasileira.

namespace Exercicio_PAG_25_7_J_Manzano
{
    internal class Exercicio_7_J_Manzano
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa que apresenta o valor da conversal em real de um valor lido em dólar");

            // Solicitar os valores ao usuário
            Console.Write("Digite a cotação do dólar: ");
            string? inputCotacao = Console.ReadLine();

            Console.Write("Digite a quantidade de dólares disponíveis: ");
            string? inputDolares = Console.ReadLine();

            // Checando se algum campo está vazio
            if (string.IsNullOrWhiteSpace(inputCotacao) || string.IsNullOrWhiteSpace(inputDolares))
            {
                Console.WriteLine("Não pode haver nenhum campo nulo");
            }
            // Convertendo string para double
            else if (double.TryParse(inputCotacao, NumberStyles.Float, CultureInfo.InvariantCulture, out double cotacao) &&
                     double.TryParse(inputDolares, NumberStyles.Float, CultureInfo.InvariantCulture, out double dolares))
            {
                // Calculando o valor em reais
                double valorEmReais = cotacao * dolares;

                // Exibindo o resultado
                Console.WriteLine($"O valor em reais é: R$ {valorEmReais.ToString("F2", CultureInfo.InvariantCulture)}");
            }
            else
            {
                Console.WriteLine("Entradas inválidas. Por favor, insira valores numéricos válidos.");
            }
        }
    }
}
