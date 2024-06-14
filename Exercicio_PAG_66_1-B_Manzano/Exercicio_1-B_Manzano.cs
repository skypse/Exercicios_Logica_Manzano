using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Autor: Gabriel do Amaral Alves
// Data: 14/06/24
/* Enunciado: Apresentar os resultados de uma tabuada de multiplicar (de 1 até 10) de um número qualquer.*/

namespace Exercicio_PAG_66_1_B_Manzano
{
    internal class Exercicio_1_B_Manzano
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Apresentar os resultados de uma tabuada de multiplicar (de 1 até 10) de um número qualquer.");
            Console.WriteLine("Digite um valor: ");
            int valor = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Multiplicando {valor} pelos números de 0 a 10");
            for (int contadora = 0; contadora <= 10; contadora++)
            {
                int resultado = valor * contadora;
                Console.WriteLine(valor + " * " + contadora + " = " + resultado);
            }
        }
    }
}
