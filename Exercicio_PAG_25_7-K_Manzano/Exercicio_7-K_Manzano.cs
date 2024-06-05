using System;
using System.Globalization;
// Autor: Gabriel do Amaral Alves
// Data: 05/06/24
// Enunciado: 7-K) Elaborar um programa que efetue a apresentação do valor da conversão em dólar de um valor lido em real.
// O programa deve solicitar o valor da cotação do dólar e também a quantidade de reais disponível com o usuário, para que seja apresentado o valor em moeda americana.
namespace Exercicio_PAG_25_7_K_Manzano
{
    internal class Exercicio_7_K_Manzano
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa que apresenta o valor da conversão em dólar de um valor lido em real");
            // Solicitar os valores ao usuário
            Console.Write("Digite a cotação do dólar: ");
            string? inputCotacao = Console.ReadLine();

            Console.Write("Digite a quantidade de reais disponíveis: ");
            string? inputReais = Console.ReadLine();

            // Checando se algum campo está vazio
            if (string.IsNullOrWhiteSpace(inputCotacao) || string.IsNullOrWhiteSpace(inputReais))
            {
                Console.WriteLine("Não pode haver nenhum campo nulo");
            }
            // Convertendo string para double
            else if (double.TryParse(inputCotacao, NumberStyles.Float, CultureInfo.InvariantCulture, out double cotacao) &&
                     double.TryParse(inputReais, NumberStyles.Float, CultureInfo.InvariantCulture, out double reais))
            {
                // Calculando o valor em dólares
                double valorEmDolares = reais / cotacao;

                // Exibindo o resultado
                Console.WriteLine($"O valor em dólares é: $ {valorEmDolares.ToString("F2", CultureInfo.InvariantCulture)}");
            }
            else
            {
                Console.WriteLine("Entradas inválidas. Por favor, insira valores numéricos válidos.");
            }
        }
    }
}
