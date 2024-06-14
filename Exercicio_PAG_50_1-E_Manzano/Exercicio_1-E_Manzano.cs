using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Autor: Gabriel do Amaral Alves
// Data: 14/06/24
/* Enunciado: Elaborar um programa que efetue a leitura de 15 valores numéricos inteiros e no final apresente o
total do somatório da fatorial de cada valor lido.*/

namespace Exercicio_PAG_50_1_E_Manzano
{
    internal class Exercicio_1_E_Manzano
    {
        public static void Main(string[] args)
        {
            int somaDosFatorias = 0, contadora = 1, fatorial = 1;

            do
            {
                Console.WriteLine("Digite um valor inteiro");
                int valor = Convert.ToInt32(Console.ReadLine());

                for (int j = 2; j < valor; j++)
                {
                    fatorial *= j;
                }
                somaDosFatorias += fatorial;
                contadora++;
            } while (contadora < 16);
        }
    }
}
