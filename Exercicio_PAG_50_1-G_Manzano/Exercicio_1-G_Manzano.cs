using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Autor: Gabriel do Amaral Alves
// Data: 14/06/24
/* Enunciado: Elaborar um programa que apresente como resultado o valor do fatorial dos valores ímpares
situados na faixa numérica de 1 a 10.*/

namespace Exercicio_PAG_50_1_G_Manzano
{
    internal class Exercicio_1_G_Manzano
    {
        public static void Main(string[] args)
        {
            int contadora = 1;
            int fatorial = 1;
            int anterior = 1;

            do
            {
                int impar = contadora % 2;

                if (impar != 0)
                {
                    anterior = fatorial;
                    fatorial *= contadora;
                    Console.WriteLine($"{anterior} * {contadora} = {fatorial}");
                }

                contadora++;
            } while (contadora <= 10);
        }
    }
}
