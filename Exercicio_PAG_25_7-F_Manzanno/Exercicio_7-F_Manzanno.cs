using System;
using System.Globalization;
using System.Runtime.Intrinsics.X86;
// Autor: Gabriel do Amaral Alves
// Data: 05/06/24
// Enunciado: 7-f) Ler dois valores (inteiros, reais ou caracteres) para as variáveis A e B, e efetuar a troca dos valores de
// forma que a variável A passe a possuir o valor da variável B e a variável B passe a possuir o valor da
// variável A. Apresentar os valores trocados

namespace Exercicio_PAG_25_7_F_Manzanno
{
    internal class Exercicio_7_F_Manzanno
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Programa que 2 valores e troca entre variáveis");
            // Vlaor1
            Console.Write("Digite um valor para a variável 'A': ");
            string? valorA = Console.ReadLine();
            // Valor2
            Console.Write("Digite um valor para a variável 'B': ");
            string? valorB = Console.ReadLine();

            // Checando se está vázio
            if (string.IsNullOrWhiteSpace(valorA) ||
                (string.IsNullOrWhiteSpace(valorB)))
            {
                Console.WriteLine("Não pode haver nenhum campo nulo");
            }
            else
            {
                // Trocando valores
                string? troca = valorA;
                valorA = valorB;
                valorB = troca;

                // Exibindo
                Console.WriteLine($"Valor da variável 'A' é: {valorA}");
                Console.WriteLine($"Valor da variável 'B' é: {valorB}");
            }
        }
    }
}
