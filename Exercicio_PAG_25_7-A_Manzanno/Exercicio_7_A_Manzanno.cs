using System;
using System.Globalization;
// Autor: Gabriel do Amaral Alves
// Data: 04/06/24
// Enunciado: 7-A) Ler uma temperatura em graus Celsius e apresentá-la convertida em graus Fahrenheit.
// A fórmula de conversão é F = (9 * C + 160) / 5, sendo F a temperatura em Fahrenheit e C a temperatura em Celsius.

namespace Exercicio_PAG_25_7_A_Manzanno
{
    internal class Exercicio_7_A_Manzanno
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Programa que lê temperatura em Celsius, e converte para Fahrenheit");

            // Entrada Temperatura
            Console.Write("Digite a temperatura em Celsius: ");
            string? inputTemperatura = Console.ReadLine();

            // Checando se o inputTemperatura está NULL ou Vázio
            if (string.IsNullOrWhiteSpace(inputTemperatura)) 
            {
                Console.WriteLine("Nenhum campo pode ser NULO");
            }
            // Converter 'string' para double | setando padrão de separação de números para '.'
            else if (double.TryParse(inputTemperatura, NumberStyles.Float, CultureInfo.InvariantCulture, out double celsius))
            {
               double fahrenheit = (9 * celsius + 160) / 5;
                Console.WriteLine($"Sua temperatura em Fahrenheit é: {fahrenheit}");
            }
            else
            {
                Console.WriteLine("Entradas inválidas. Por favor, insira valores numéricos.");
            }
        }
    }
}
