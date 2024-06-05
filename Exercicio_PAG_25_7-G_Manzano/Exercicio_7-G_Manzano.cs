using System;
using System.Globalization;
// Autor: Gabriel do Amaral Alves
// Data: 05/06/24
// Enunciado: 7-G) Ler quatro números inteiros e apresentar o resultado da adição e multiplicação, baseando-se na
// utilização do conceito da propriedade distributiva. Ou seja, se forem lidas as variáveis A, B, C, e D,
// devem ser somadas e multiplicadas A com B, A com C e A com D. Depois B com C, B com D e por fim
// C com D. Perceba que será necessário efetuar seis operações de adição e seis operações de
// multiplicação e apresentar doze resultados de saída.

namespace Exercicio_PAG_25_7_G_Manzano
{
    internal class Exercicio_7_G_Manzano
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa que lê quatro números, e apresenta o resultado da adição e multiplicação");

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
                Console.WriteLine("Não pode haver nenhum campo nulo");
            }
            // Convertendo string para int
            else if (int.TryParse(inputA, NumberStyles.Integer, CultureInfo.InvariantCulture, out int A) &&
                     int.TryParse(inputB, NumberStyles.Integer, CultureInfo.InvariantCulture, out int B) &&
                     int.TryParse(inputC, NumberStyles.Integer, CultureInfo.InvariantCulture, out int C) &&
                     int.TryParse(inputD, NumberStyles.Integer, CultureInfo.InvariantCulture, out int D))
            {
                // Realizando as operações e apresentando os resultados
                // Primeiro chamamos o 'X' e o 'Y' que representa os nomes exemplo = "A + B"
                // Depois Chamamos o 'X' e 'Y' que representará os números exemplo = 1 + 1
                // Exibindo = A + B = 2
                ApresentarResultados("A", "B", A, B);
                ApresentarResultados("A", "C", A, C);
                ApresentarResultados("A", "D", A, D);
                ApresentarResultados("B", "C", B, C);
                ApresentarResultados("B", "D", B, D);
                ApresentarResultados("C", "D", C, D);
            }
            else
            {
                Console.WriteLine("Entradas inválidas. Por favor, insira valores numéricos inteiros.");
            }
            // Função para fazer soma e multiplicação
            static void ApresentarResultados(string nomeX, string nomeY, int x, int y)
            {
                int resultadoSoma = x + y;
                int resultadoMultiplicacao = x * y;

                Console.WriteLine("-------------------------------------------------------");
                Console.WriteLine($"A soma de {nomeX} + {nomeY} = {resultadoSoma}");
                Console.WriteLine($"A multiplicação de {nomeX} * {nomeY} = {resultadoMultiplicacao}");
            }
        }
    }
}
