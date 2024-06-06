using System;
using System.Globalization;
// Autor: Gabriel do Amaral Alves
// Data: 06/06/24
/* Enunciado: 4-E) Efetuar a leitura de três valores (variáveis A, B e C) e efetuar o cálculo da equação completa de
segundo grau, apresentando as duas raízes, se para os valores informados for possível efetuar o
referido cálculo. Lembre-se de que a variável A deve ser diferente de zero..*/

namespace Exercicio_PAG_41_4_E_Manzano
{
    internal class Exercicio_4_E_Manzano
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa que calcula as raízes de uma equação do segundo grau.");

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
                Console.WriteLine("Não pode haver um campo nulo.");
            }
            // Convertendo string para double
            else if (double.TryParse(inputA, NumberStyles.Float, CultureInfo.InvariantCulture, out double A) &&
                     double.TryParse(inputB, NumberStyles.Float, CultureInfo.InvariantCulture, out double B) &&
                     double.TryParse(inputC, NumberStyles.Float, CultureInfo.InvariantCulture, out double C))
            {
                if (A == 0)
                {
                    Console.WriteLine("O valor de A deve ser diferente de zero para que a equação seja do segundo grau.");
                }
                else
                {
                    // Calculando o (delta)
                    double delta = B * B - 4 * A * C;

                    if (delta < 0)
                    {
                        Console.WriteLine("A equação não possui raízes reais.");
                    }
                    else
                    {
                        // Calculando as raízes
                        double raizDelta = Math.Sqrt(delta);
                        double x1 = (-B + raizDelta) / (2 * A);
                        double x2 = (-B - raizDelta) / (2 * A);

                        // Exibindo as raízes
                        Console.WriteLine($"As raízes da equação são: x1 = {x1:F2} e x2 = {x2:F2}");
                    }
                }
            }
            else
            {
                Console.WriteLine("Entradas inválidas. Por favor, insira valores numéricos válidos.");
            }
        }
    }
}