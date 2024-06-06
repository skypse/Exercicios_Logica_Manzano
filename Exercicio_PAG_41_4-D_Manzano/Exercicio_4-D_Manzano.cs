using System;
using System.Globalization;
// Autor: Gabriel do Amaral Alves
// Data: 06/06/24
/* Enunciado: 4-D) Ler quatro valores referentes a quatro notas escolares de um aluno e imprimir uma mensagem
dizendo que o aluno foi aprovado, se o valor da média escolar for maior ou igual a 7. Se o valor da
média for menor que 7, solicitar a nota de exame, somar com o valor da média e obter nova média.
Se a nova média for maior ou igual a 5, apresentar uma mensagem dizendo que o aluno foi
aprovado em exame. Se o aluno não foi aprovado, indicar uma mensagem informando esta
condição. Apresentar com as mensagens o valor da média do aluno, para qualquer condição.*/

namespace Exercicio_PAG_41_4_D_Manzano
{
    internal class Exercicio_4_D_Manzano
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa que lê quatro notas escolares e verifica se o aluno foi aprovado.");

            // Solicitar as notas ao usuário
            Console.Write("Digite a primeira nota: ");
            string? inputNota1 = Console.ReadLine();

            Console.Write("Digite a segunda nota: ");
            string? inputNota2 = Console.ReadLine();

            Console.Write("Digite a terceira nota: ");
            string? inputNota3 = Console.ReadLine();

            Console.Write("Digite a quarta nota: ");
            string? inputNota4 = Console.ReadLine();

            // Checando se algum campo está vazio
            if (string.IsNullOrWhiteSpace(inputNota1) || string.IsNullOrWhiteSpace(inputNota2) ||
                string.IsNullOrWhiteSpace(inputNota3) || string.IsNullOrWhiteSpace(inputNota4))
            {
                Console.WriteLine("Não pode haver um campo nulo.");
            }
            // Convertendo string para double
            else if (double.TryParse(inputNota1, NumberStyles.Float, CultureInfo.InvariantCulture, out double nota01) &&
                     double.TryParse(inputNota2, NumberStyles.Float, CultureInfo.InvariantCulture, out double nota02) &&
                     double.TryParse(inputNota3, NumberStyles.Float, CultureInfo.InvariantCulture, out double nota03) &&
                     double.TryParse(inputNota4, NumberStyles.Float, CultureInfo.InvariantCulture, out double nota04))
            {
                // média notas
                double media = (nota01 + nota02 + nota03 + nota04) / 4;

                // aprovado
                if (media >= 7)
                {
                    Console.WriteLine($"O aluno foi aprovado com a média {media:F2}");
                }
                else
                {
                    // solicita nova média
                    Console.WriteLine("O aluno caiu na recuperação, adicione mais alguma nota de prova");
                    Console.Write("Digite a nota do exame: ");
                    string? inputNotaExame = Console.ReadLine();

                    if (double.TryParse(inputNotaExame, NumberStyles.Float, CultureInfo.InvariantCulture, out double notaExame))
                    {
                        // nova média
                        double novaMedia = (media + notaExame) / 2;

                        // verificar nova média
                        if (novaMedia >= 5)
                        {
                            Console.WriteLine($"O aluno foi aprovado em exame com a média {novaMedia:F2}");
                        }
                        else
                        {
                            Console.WriteLine($"O aluno não foi aprovado. Média após exame: {novaMedia:F2}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Entrada inválida para a nota do exame. Por favor, insira um valor numérico válido.");
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