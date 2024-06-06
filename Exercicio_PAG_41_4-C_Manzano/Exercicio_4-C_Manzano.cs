using System;
using System.Globalization;
// Autor: Gabriel do Amaral Alves
// Data: 06/06/24
/* Enunciado: 4-C) Ler quatro valores referentes a quatro notas escolares de um aluno e imprimir uma mensagem
dizendo que o aluno foi aprovado, se o valor da média escolar for maior ou igual a 5. Se o aluno não
foi aprovado, indicar uma mensagem informando esta condição. Apresentar junto das mensagens o
valor da média do aluno para qualquer condição.*/

namespace Exercicio_PAG_41_4_C_Manzano
{
    internal class Exercicio_4_C_Manzano
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Programa que lê notas do aluno e fala se foi aprovado ou não");

            // Solicitar os valores ao usuário
            Console.WriteLine("Digite a primeira nota do aluno: ");
            string? inputNota01 = Console.ReadLine();

            Console.WriteLine("Digite a primeira nota do aluno: ");
            string? inputNota02 = Console.ReadLine();

            Console.WriteLine("Digite a primeira nota do aluno: ");
            string? inputNota03 = Console.ReadLine();

            Console.WriteLine("Digite a primeira nota do aluno: ");
            string? inputNota04 = Console.ReadLine();

            // Checando se algum campo está vazio
            if (string.IsNullOrWhiteSpace(inputNota01) || (string.IsNullOrWhiteSpace(inputNota02)) ||
               (string.IsNullOrWhiteSpace(inputNota03)) || (string.IsNullOrWhiteSpace(inputNota04)))
            {
                Console.WriteLine("Não pode haver campos nulos");
            }
            // Convertendo de string para float
            else if (double.TryParse(inputNota01, NumberStyles.Float, CultureInfo.InvariantCulture, out double nota1) &&
                     double.TryParse(inputNota02, NumberStyles.Float, CultureInfo.InvariantCulture, out double nota2) &&
                     double.TryParse(inputNota03, NumberStyles.Float, CultureInfo.InvariantCulture, out double nota3) &&
                     double.TryParse(inputNota04, NumberStyles.Float, CultureInfo.InvariantCulture, out double nota4))
            {
                // Calculando a média das notas
                double media = (nota1 + nota2 + nota3 + nota4) / 4;
                if (media >= 5)
                {
                    Console.WriteLine($"O aluno foi aprovado com a média: {media:F2}");
                }
                else
                {
                    Console.WriteLine($"O aluno não foi aprovado. Média: {media:F2}");
                }
            }
            else
            {
                Console.WriteLine("Entradas inválidas. Por favor, insira valores numéricos válidos.");
            }
        }

    }
}
