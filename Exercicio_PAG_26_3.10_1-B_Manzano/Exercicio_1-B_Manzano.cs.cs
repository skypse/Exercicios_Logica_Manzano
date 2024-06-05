using System;
using System.Globalization;
// Autor: Gabriel do Amaral Alves
// Data: 05/06/24
// Enunciado: 1-B) Ler o valor correspondente ao salário mensal (variável SM) de um trabalhador e também o valor do
// percentual de reajuste (variável PR) a ser atribuído. Apresentar o valor do novo salário (variável NS).

namespace Exercicio_PAG_26_3._10_1_B_Manzano
{
    internal class Exercicio_1_B_Manzano
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Programa que lê o salário de um trabalhador junto com o percentual de reajuste, e apresenta o novo salário");
            Console.WriteLine("-----------------------------------------------------------------");

            // Solicitar os valores ao usuário
            Console.Write("Digite o seu salário mensal: R$");
            string? inputSalarioMensal = Console.ReadLine();

            Console.Write("Digite o percentual de reajuste: ");
            string? inputPercentualReajuste = Console.ReadLine();

            // Checando se algum campo está vázio
            if (string.IsNullOrWhiteSpace(inputPercentualReajuste) ||
                (string.IsNullOrWhiteSpace(inputPercentualReajuste)))
            {
                Console.WriteLine("Não pode haver nenhum campo nulo");
            }
            // Convertendo string para double
            else if (double.TryParse(inputSalarioMensal, NumberStyles.Float, CultureInfo.InvariantCulture, out double salarioMensal) &&
                    (double.TryParse(inputPercentualReajuste, NumberStyles.Float, CultureInfo.InvariantCulture, out double percentualReajuste)))
            {
                double novoSalario = salarioMensal + (percentualReajuste * salarioMensal / 100);

                // Formatando para exibir 2 casas somente
                string salarioNovoFormatado = novoSalario.ToString("F2");

                Console.WriteLine($"O novo salário é: R${salarioNovoFormatado}");
            }
            else
            {
                Console.WriteLine("Entradas inválidas. Por favor, insira valores numéricos inteiros.");
            }
        }
    }
}
