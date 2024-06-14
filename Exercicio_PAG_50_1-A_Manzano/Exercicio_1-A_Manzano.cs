using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Autor: Gabriel do Amaral Alves
// Data: 14/06/24
/* Enunciado: Apresentar os quadrados dos números inteiros de 15 a 200.*/

namespace Exercicio_PAG_50_1_A_Manzano
{
    internal class Exercicio_1_A_Manzano
    {
        public static void Main(string[]args)
        {
            int contadora = 15;

            do
            {
                Console.WriteLine(contadora * contadora);
                contadora++;
            } while (contadora < 201);
        }
    }
}
