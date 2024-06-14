using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Autor: Gabriel do Amaral Alves
// Data: 14/06/24
/* Enunciado: Elaborar um programa que possibilite calcular a área total de uma residência (sala, cozinha,
banheiro, quartos, área de serviço, quintal, garagem, etc.). O programa deve solicitar a entrada do
nome, a largura e o comprimento de um determinado cômodo. Em seguida, deve apresentar a área
do cômodo lido e também uma mensagem solicitando do usuário a confirmação de continuar
calculando novos cômodos. Caso o usuário responda “NAO”, o programa deve apresentar o valor
total acumulado da área residencial.*/

namespace Exercicio_PAG_50_1_H_Manzano
{
    internal class Exercicio_1_H_Manzano
    {
        public static void Main(string[] args)
        {
            string comodo;
            string opcao;
            double largura, comprimento, total, soma = 0;

            do
            {
                // cômodo
                Console.Write("Digite o nome do cômodo: ");
                comodo = Console.ReadLine();

                // largura do cômodo
                Console.Write("Digite o valor da largura (em metros): ");
                largura = Convert.ToDouble(Console.ReadLine());

                // comprimento do cômodo
                Console.Write("Digite o valor do comprimento (em metros): ");
                comprimento = Convert.ToDouble(Console.ReadLine());

                // área do cômodo
                total = largura * comprimento;
                soma += total;

                // exibe a área do cômodo
                Console.WriteLine($"A área do cômodo {comodo} é de {total} metros quadrados.");
                Console.Write("Deseja continuar? S - Sim / N - Não: ");
                opcao = Console.ReadLine().ToUpper();

            } while (opcao == "S");

            // área total da residência
            Console.WriteLine($"A área total da residência é de {soma} metros quadrados.");
        }
    }
}
