using System;
// Autor: Gabriel do Amaral Alves
// Data: 06/06/24
/* Enunciado: 4-F) Efetuar a leitura de três valores (variáveis A, B e C) e apresentá-los dispostos em ordem crescente.*/

namespace Exercicio_PAG_41_4_F_Manzano
{
    internal class Exercicio_4_F_Manzano
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa que lê três valores e os apresenta em ordem crescente.");

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
            else if (double.TryParse(inputA, out double A) &&
                     double.TryParse(inputB, out double B) &&
                     double.TryParse(inputC, out double C))
            {
                // ordenando os valores
                double[] valores = { A, B, C };
                Array.Sort(valores);

                // exibindo os valores em ordem crescente
                Console.WriteLine("Os valores em ordem crescente são: ");
                foreach (var valor in valores)
                {
                    Console.WriteLine(valor);
                }
            }
            else
            {
                Console.WriteLine("Entradas inválidas. Por favor, insira valores numéricos válidos.");
            }
        }
    }
}
