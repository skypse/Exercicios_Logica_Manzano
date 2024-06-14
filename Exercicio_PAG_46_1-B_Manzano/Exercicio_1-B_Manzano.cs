using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Autor: Gabriel do Amaral Alves
// Data: 14/06/24
/* Enunciado: Apresentar o total da soma obtida dos cem primeiros números inteiros (1+2+3+4+...+98+99+100).*/

namespace Exercicio_PAG_46_1_B_Manzano
{
    internal class Exercicio_1_B_Manzano
    {
        public static void Main(string[] args)
        {
            int contadora = 1, acumuladora = 0;

            while (contadora < 101)
            {
                acumuladora += contadora;
                contadora++;
            }
            Console.WriteLine($"A soma total foi: {acumuladora}");
        }
    }
}
