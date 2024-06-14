using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Autor: Gabriel do Amaral Alves
// Data: 14/06/24
/* Enunciado: Elaborar um programa que apresente no final o somatório dos valores pares existentes na faixa de
1 até 500.*/

namespace Exercicio_PAG_50_1_B_Manzano
{
    internal class Exercicio_1_B_Manzano
    {
        public static void Main(string[] args)
        {
            int contadora = 1, acumuladora = 0;
            do
            {
                if (contadora % 2 == 0)
                {
                    acumuladora += contadora;
                }
                contadora++;
            } while (contadora < 501);
            Console.WriteLine($"A soma dos números pares é: {acumuladora}");
        }
    }
}
