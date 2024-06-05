using System;
using System.Globalization;
// Autor: Gabriel do Amaral Alves
// Data: 05/06/24
// Enunciado: 7-E) Efetuar o cálculo e a apresentação do valor de uma prestação em atraso, utilizando a fórmula:
// PRESTACAO VALOR + (VALOR * TAXA/100) * TEMPO).


namespace Exercicio_PAG_25_7_E_Manzanno
{
    internal class Exercicio_7_E_Manzanno
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Programa que apresenta o valor de uma prestação em atraso");
            // Prestacao
            Console.Write("Digite o valor da sua prestação: R$");
            string? inputValorPrestacao = Console.ReadLine();
            // Atraso
            Console.Write("Digite o tempo de atraso em dias: ");
            string? inputAtraso = Console.ReadLine();
            // Taxa
            Console.Write("Digite a porcentagem da sua taxa: ");
            string? inputTaxa = Console.ReadLine();

            // Checando se está vázio
            if (string.IsNullOrWhiteSpace(inputValorPrestacao) ||
                (string.IsNullOrWhiteSpace(inputAtraso))       ||
                (string.IsNullOrWhiteSpace(inputTaxa)))
            {
                Console.WriteLine("Não pode haver nenhum campo nulo");
            }
            // Convertendo string para double/int
            else if(double.TryParse(inputValorPrestacao, NumberStyles.Float, CultureInfo.InvariantCulture, out double prestacao_valor) && 
                int.TryParse(inputAtraso,out int atraso) && int.TryParse(inputTaxa, out int taxa))
            {
                double prestacao = prestacao_valor + (prestacao_valor * taxa / 100) * atraso;
                Console.WriteLine($"O valor da sua prestacação fica em R$: {prestacao}");
            }
        }
    }
}
