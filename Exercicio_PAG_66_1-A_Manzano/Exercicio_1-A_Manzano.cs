using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Autor: Gabriel do Amaral Alves
// Data: 14/06/24
/* Enunciado: Apresentar os quadrados dos números inteiros de 15 a 200.*/

namespace Exercicio_PAG_66_1_A_Manzano
{
    internal class Exercicio_1_A_Manzano
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Calculando as potências de 15 até 200");

            for (int contadora = 15; contadora < 201; contadora++)
            {
                int resultado = contadora * contadora;
                Console.WriteLine($"{contadora} ^ 2 = {resultado}");
            }
        }
    }
}
