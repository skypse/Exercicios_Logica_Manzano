using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Autor: Gabriel do Amaral Alves
// Data: 14/06/24
/* Enunciado: Elaborar um programa que apresente como resultado o valor do fatorial dos valores ímpares
situados na faixa numérica de 1 a 10.*/

namespace Exercicio_PAG_66_1_K_Manzano
{
    internal class Exercicio_1_K_Manzano
    {
        public static void Main(string[] args)
        {
            for (int contadora = 1; contadora <= 10; contadora++)
            {
                if (contadora % 2 == 1)
                {
                    int resultado = 1;
                    for (int contadora2 = 1; contadora2 <= contadora; contadora2++)
                    {
                        resultado *= contadora2;
                    }
                    Console.WriteLine(contadora + "! = " + resultado);
                }
            }
        }
    }
}
