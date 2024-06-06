using System;
// Autor: Gabriel do Amaral Alves
// Data: 06/06/24
/* Enunciado: 4-G) Efetuar a leitura de quatro números inteiros e apresentar os números que são divisíveis por 2 e 3.*/

namespace Exercicio_PAG_41_4_G_Manzano
{
    internal class Exercicio_4_G_Manzano
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Progrma que lê quatros numeros e apresenta se são divisíveis por 2 e 3");

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
                Console.WriteLine("Não pode haver um campo nulo.");
            }
            else if (double.TryParse(inputA, out double numero01) &&
                    double.TryParse(inputB, out double numero02) &&
                    double.TryParse(inputC, out double numero03) &&
                    double.TryParse(inputD, out double numero04))
            {
                if (numero01 % 2 == 0 && numero01 % 3 == 0)
                {
                    Console.WriteLine($"{numero01} é divisível por 2 e por 3");
                }
                else
                {
                    Console.WriteLine($"{numero01} não é divisível por 2 e por 3");
                }

                if (numero02 % 2 == 0 && numero02 % 3 == 0)
                {
                    Console.WriteLine($"{numero02} é divisível por 2 e por 3");
                }
                else
                {
                    Console.WriteLine($"{numero02} não é divisível por 2 e por 3");
                }

                if (numero03 % 2 == 0 && numero03 % 3 == 0)
                {
                    Console.WriteLine($"{numero03} é divisível por 2 e por 3");
                }
                else
                {
                    Console.WriteLine($"{numero03} não é divisível por 2 e por 3");
                }

                if (numero04 % 2 == 0 && numero04 % 3 == 0)
                {
                    Console.WriteLine($"{numero03} é divisível por 2 e por 3");
                }
                else
                {
                    Console.WriteLine($"{numero04} não é divisível por 2 e por 3");
                }
            }
            else
            {
                Console.WriteLine("Entradas inválidas. Por favor, insira valores numéricos válidos.");
            }
        }
    }
}
