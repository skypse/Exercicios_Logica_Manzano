using System;
// Autor: Gabriel do Amaral Alves
// Data: 06/06/24
/* Enunciado: 4-K) Elaborar um programa que efetue a leitura de um determinado valor inteiro, e efetue a sua
apresentação, caso o valor não seja maior que três.*/

namespace Exercicio_PAG_41_4_K_Manzano
{
    internal class Exercicio_4_K_Manzano
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Programa que lê um valor inteiro e o apresenta se não for maior que três.");

            // Solicitar o valor ao usuário
            Console.Write("Digite um valor inteiro: ");
            string? input = Console.ReadLine();

            // Checando se algum campo está vazio
            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Não pode haver campos nulos");
            }
            // Convertendo string para int
            else if (int.TryParse(input, out int valor)) 
            {
                if (valor <= 3)
                {
                    Console.WriteLine($"O valor fornecido é: {valor}");
                }
                else
                {
                    Console.WriteLine("O valor fornecido é maior que três.");
                }
            }
            else
            {
                Console.WriteLine("Entrada inválida. Por favor, insira um número inteiro.");
            }
        }
    }
}
