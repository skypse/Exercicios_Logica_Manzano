using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Autor: Gabriel do Amaral Alves
// Data: 14/06/24
/* Enunciado: Elaborar um programa que apresente no final o somatório dos valores pares existentes na faixa de
1 até 500.*/

namespace Exercicio_PAG_66_1_D_Manzano
{
    internal class Exercicio_1_D_Manzano
    {
        public static void Main(string[] args)
        {
            int somatorio = 0;

            for (int i = 1; i <= 500; i++)
            {
                if (i % 2 == 0)
                {
                    somatorio += i;
                }
            }
            Console.WriteLine($"O somatório dos valores pares de 1 até 500 é: {somatorio}");
        }
    }
}
