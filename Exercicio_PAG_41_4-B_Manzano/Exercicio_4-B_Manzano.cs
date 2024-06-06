using System;
using System.Globalization;
// Autor: Gabriel do Amaral Alves
// Data: 06/06/24
/* Enunciado: 4-B) Efetuar a leitura de um valor inteiro positivo ou negativo e apresentar o número lido como sendo um
valor positivo, ou seja, o programa deverá apresentar o módulo de um número fornecido. Lembre-se
de verificar se o número fornecido é menor que zero; sendo, multiplique-o por -1..*/

namespace Exercicio_PAG_41_4_B_Manzano
{
    internal class Exercicio_4_B_Manzano
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Programa que transforma um valor negativo em positivo e se for positivo só exibe");

            // Solicitar os valores ao usuário
            Console.WriteLine("Digite um valor inteiro (positivo ou negativo): ");
            string? inputValor  = Console.ReadLine();

            // Checando se algum campo está vazio
            if (string.IsNullOrWhiteSpace(inputValor))
            {
                Console.WriteLine("Não pode haver campos nulos");
            }
            // Convertendo de string para int
            else if (int.TryParse(inputValor, NumberStyles.Integer, CultureInfo.InvariantCulture, out int numero1))
            {
                if (numero1 < 0)
                {
                    int calculo = numero1 * -1;
                    Console.WriteLine($"Aqui está seu valor negativo, transformado em positivo: {calculo}");
                }
                else 
                {
                    Console.WriteLine($"Seu valor positivo é: {numero1}");
                }
            }
            else
            {
                Console.WriteLine("Entradas inválidas. Por favor, insira valores numéricos inteiros.");
            }
        }
    }
}
