using System;
using System.Globalization;
// Autor: Gabriel do Amaral Alves
// Data: 04/06/24
// Enunciado: 7-B) Ler uma temperatura em graus Fahrenheit e apresentá-la convertida em graus Celsius.
// A fórmula de conversão é C = (F - 32) * (5/9) , sendo F a temperatura em Fahrenheit e C a temperatura em Celsius.


namespace Exercicio_PAG_25_7_B_Manzanno
{
    internal class Exercicio_7_B_Manzanno
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Programa que lê temperatura em Fahrenheit, e converte para Celsius");

            // Entrada Temperatura
            Console.Write("Digite a temperatura em Fahrenheit: ");
            string? inputTemperatura = Console.ReadLine();

            // Checando se o inputTemperatura está NULL ou Vázio
            if (string.IsNullOrWhiteSpace(inputTemperatura))
            {
                Console.WriteLine("Nenhum campo pode ser NULO");
            }
            // Converter 'string' para double | setando padrão de separação de números para '.'
            else if (double.TryParse(inputTemperatura, NumberStyles.Float, CultureInfo.InvariantCulture, out double fahrenheit))
            {
                double celsius = ((fahrenheit - 32d) * (5d/9d));
                Console.WriteLine($"Sua temperatura em Celsius é: {celsius}");
            }
            else
            {
                Console.WriteLine("Entradas inválidas. Por favor, insira valores numéricos.");
            }
        }
    }
}
