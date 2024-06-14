using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Autor: Gabriel do Amaral Alves
// Data: 14/06/24
/* Enunciado: Elaborar um programa que apresente os resultados da soma e da média aritmética dos valores
pares situados na faixa numérica de 50 a 70.*/

namespace Exercicio_PAG_46_1_J_Manzano
{
    internal class Exercicio_1_J_Manzano
    {
        public static void Main(string[] args)
        {
            double media, soma = 0;
            int contadora = 50;

            while (contadora < 71)
            {
                if (contadora % 2 == 0)
                {
                    soma += contadora;
                    Console.WriteLine(contadora);
                }
                contadora++;
            }
            Console.WriteLine("------------------------------");
            media = soma / 11;
            Console.WriteLine($"A soma é: {soma}");
            Console.WriteLine($"A média é: {media}");
        }
    }
}
