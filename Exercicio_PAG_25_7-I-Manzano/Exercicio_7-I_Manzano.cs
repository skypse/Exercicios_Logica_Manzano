using System;
using System.Globalization;
// Autor: Gabriel do Amaral Alves
// Data: 05/06/24
// Enunciado: Ler dois inteiros (variáveis A e B) e imprimir o resultado do quadrado da diferença do primeiro valor pelo segundo.

namespace Exercicio_PAG_25_7_I_Manzano
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa que imprimir o resultado do quadrado da diferença do primeiro valor pelo segundo.");

            // Solicitar os valores ao usuário
            Console.Write("Digite o primeiro valor (A): ");
            string? inputA = Console.ReadLine();

            Console.Write("Digite o segundo valor (B): ");
            string? inputB = Console.ReadLine();

            // Checando se algum campo está vazio
            if (string.IsNullOrWhiteSpace(inputA) || string.IsNullOrWhiteSpace(inputB))
            {
                Console.WriteLine("Não pode haver nenhum campo nulo");
            }
            // Convertendo string para int
            else if (int.TryParse(inputA, NumberStyles.Integer, CultureInfo.InvariantCulture, out int A) &&
                     int.TryParse(inputB, NumberStyles.Integer, CultureInfo.InvariantCulture, out int B))
            {
                // Calculando o quadrado da diferença
                int potenciacao = (A - B) * (A - B);

                // Exibindo o resultado
                Console.WriteLine($"O resultado do quadrado da diferença entre {A} e {B} é: {potenciacao}");
            }
            else
            {
                Console.WriteLine("Entradas inválidas. Por favor, insira valores numéricos inteiros.");
            }
        }
    }
}
