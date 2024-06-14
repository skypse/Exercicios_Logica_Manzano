using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Autor: Gabriel do Amaral Alves
// Data: 14/06/24
/* Enunciado: Elaborar um programa que possibilite calcular a área total de uma residência (sala, cozinha,
banheiro, quartos, área de serviço, quintal, garagem, etc.). O programa deve solicitar a entrada do
nome, a largura e o comprimento de um determinado cômodo. Em seguida, deve apresentar a área do cômodo lido e também uma mensagem solicitando do usuário a confirmação de continuar
calculando novos cômodos. Caso o usuário responda “NAO”, o programa deve apresentar o valor
total acumulado da área residencial.*/

namespace Exercicio_PAG_46_1_K_Manzano
{
    internal class Exercicio_1_K_Manzano
    {
        public static void Main(string[] args)
        {
            string continuar = "SIM"; // só para começar com loop

            double areaTotal = 0;

            while (continuar.ToUpper() == "SIM")
            {
                // dados do cômodo
                Console.Write("Digite o nome do cômodo: ");
                string nome = Console.ReadLine();

                Console.Write("Digite a largura do cômodo em metros: ");
                double largura = Convert.ToDouble(Console.ReadLine());

                Console.Write("Digite o comprimento do cômodo em metros: ");
                double comprimento = Convert.ToDouble(Console.ReadLine());

                // área do cômodo
                double area = largura * comprimento;
                Console.WriteLine($"Área do cômodo {nome}: {area} metros quadrados");

                // acumular na área total
                areaTotal += area;

                // deseja continuar
                Console.Write("Deseja calcular mais um cômodo? (Digite 'SIM' para continuar ou qualquer outra coisa para sair): ");
                continuar = Console.ReadLine().ToUpper();
            }

            // área total da residência
            Console.WriteLine($"Área total da residência: {areaTotal} metros quadrados");
        }
    }
}
