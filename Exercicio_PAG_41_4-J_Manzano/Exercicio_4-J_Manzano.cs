using System;
using System.Drawing;
// Autor: Gabriel do Amaral Alves
// Data: 06/06/24
/* Enunciado: 4-J) Elaborar um programa que efetue a leitura de um valor que esteja entre a faixa de 1 a 9. Após a leitura do valor fornecido pelo usuário, o programa deverá indicar uma de duas mensagens: "O
valor está na faixa permitida", caso o usuário forneça o valor nesta faixa, ou a mensagem "O valor
está fora da faixa permitida", caso o usuário forneça valores menores que 1 ou maiores que 9. */
namespace Exercicio_PAG_41_4_J_Manzano
{
    internal class Exercicio_4_J_Manzano
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Programa que verifica se um valor está na faixa de 1 a 9.");

            // Solicitar o valor ao usuário
            Console.Write("Digite um valor entre 1 e 9: ");
            string? input = Console.ReadLine();

            // Checando se algum campo está vazio
            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Não pode haver campos nulos");
            }
            // Convertendo string para int
            else if (int.TryParse(input, out int valor))
            {
                // Verificar se o valor está na faixa permitida
                if (valor >= 1 && valor <= 9)
                {
                    Console.WriteLine("O valor está na faixa permitida.");
                }
                else
                {
                    Console.WriteLine("O valor está fora da faixa permitida.");
                }
            }
            else
            {
                Console.WriteLine("Entrada inválida. Por favor, insira um número inteiro.");
            }
        }
    }
}
