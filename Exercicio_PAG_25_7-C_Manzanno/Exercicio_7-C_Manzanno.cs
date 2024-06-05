using System;
using System.Globalization;
// Autor: Gabriel do Amaral Alves
// Data: 04/06/24
// Enunciado: 7-C) Calcular e apresentar o valor do volume de uma lata de óleo, utilizando a fórmula:
// Volume* Raio * Altura


namespace Exercicio_PAG_25_7_C_Manzanno
{
    internal class Exercicio_7_C_Manzanno
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Programa que calcula e apresenta o valor do volume da lata");

            // Raio LATA
            Console.Write("Digite o raio da lata: ");
            string? inputRaioLata = Console.ReadLine();

            // Altura Lata
            Console.Write("Digite a altura da lata: ");
            string? inputAlturaLata = Console.ReadLine();

            // Checando se o input está NULL ou VÁZIO
            if (string.IsNullOrWhiteSpace(inputRaioLata) || string.IsNullOrWhiteSpace(inputAlturaLata))
            {
                Console.WriteLine("Não pode haver campos NULOS");
            }
            // Convertendo 'string' para 'double' | Aceitando o '.' invez da ','
            else if (double.TryParse(inputRaioLata, NumberStyles.Float, CultureInfo.InvariantCulture, out double raioLata) &&
                    double.TryParse(inputAlturaLata, NumberStyles.Float, CultureInfo.InvariantCulture, out double alturaLata))
            {
                // Deixando o raio elevado ao 2
                double raioAoQuadrado = raioLata * raioLata;

                // Calculando o volume
                double volume = 3.14 * raioAoQuadrado * alturaLata;
                Console.WriteLine($"O volume da lata é: {volume}cm³");
                

            }
            else
            {
                Console.WriteLine("Entradas inválidas. Por favor, insira valores numéricos.");
            }
        }
    }
}
