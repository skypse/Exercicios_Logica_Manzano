using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Autor: Gabriel do Amaral Alves
// Data: 14/06/24
/* Enunciado: Apresentar o total da soma obtida dos cem primeiros números inteiros (1+2+3+4+...+98+99+100).*/

namespace Exercicio_PAG_66_1_C_Manzano
{
    internal class Exercicio_1_C_Manzano
    {
        public static void Main(string[] args)
        {
            int soma = 0;

            for (int acumuladora = 1; acumuladora <= 100; acumuladora++)
            {
                soma += acumuladora;
            }

            Console.WriteLine($"A soma dos cem primeiros números inteiros é: {soma}");
        }
    }
}
