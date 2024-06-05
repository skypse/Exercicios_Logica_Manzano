using System;
using System.Globalization;
// Autor: Gabriel do Amaral Alves
// Data: 05/06/24
// Enunciado: 7-H) Elaborar um programa que calcule e apresente o volume de uma caixa retangular, 
// por meio da fórmula VOLUME <- COMPRIMENTO * LARGURA * ALTURA.

namespace CalculoVolumeCaixa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Solicitar os valores ao usuário
            Console.Write("Escreva o comprimento da caixa retangular: ");
            string? inputComprimento = Console.ReadLine();

            Console.Write("Escreva a largura da caixa retangular: ");
            string? inputLargura = Console.ReadLine();

            Console.Write("Escreva a altura da caixa retangular: ");
            string? inputAltura = Console.ReadLine();

            // Checando se algum campo está vazio
            if (string.IsNullOrWhiteSpace(inputComprimento) || string.IsNullOrWhiteSpace(inputLargura) ||
                string.IsNullOrWhiteSpace(inputAltura))
            {
                Console.WriteLine("Não pode haver nenhum campo nulo");
            }
            // Convertendo string para double
            else if (double.TryParse(inputComprimento, NumberStyles.Float, CultureInfo.InvariantCulture, out double comprimento) &&
                     double.TryParse(inputLargura, NumberStyles.Float, CultureInfo.InvariantCulture, out double largura) &&
                     double.TryParse(inputAltura, NumberStyles.Float, CultureInfo.InvariantCulture, out double altura))
            {
                // Calculando o volume
                double volume = comprimento * largura * altura;

                // Exibindo o resultado
                Console.WriteLine($"O volume é: {volume} unidades cúbicas");
            }
            else
            {
                Console.WriteLine("Entradas inválidas. Por favor, insira valores numéricos válidos.");
            }
        }
    }
}
