using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Autor: Gabriel do Amaral Alves
// Data: 14/06/24
/* Enunciado: Apresentar o total da soma obtida dos cem primeiros números inteiros (1+2+3+4+...+98+99+100).*/

namespace Exercicio_PAG_46_1_C_Manzano
{
    internal class Exercicio_1_C_Manzano
    {
        public static void Main(string[] args)
        {
            int contadora = 1, acumuladora = 0;

            while (contadora < 501)
            {
                if (contadora % 2 == 0)
                {
                    acumuladora += contadora;
                }
                contadora++;
            }
            Console.WriteLine($"Somatório dos valores pares existentes na faixa de 1 até 500: {acumuladora}");
        }
    }
}
