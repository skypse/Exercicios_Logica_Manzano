using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Autor: Gabriel do Amaral Alves
// Data: 14/06/24
/* Enunciado: Elaborar um programa que apresente como resultado o valor de uma potência de uma base
qualquer elevada a um expoente qualquer, ou seja, de B E, em que B é o valor da base e E o valor
do expoente. Observe que neste exercício não pode ser utilizado o operador de exponenciação do
portuguol (^).*/

namespace Exercicio_PAG_66_1_H_Manzano
{
    internal class Exercicio_1_H_Manzano
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor da base: ");
            int valor = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o valor do expoente: ");
            int expoente = Convert.ToInt32(Console.ReadLine());

            int resultado = 1;

            for (int contadora = 1; contadora <= expoente; contadora++)
            {
                resultado *= valor;
            }
            Console.WriteLine(valor + " ^ " + expoente + " = " + resultado);
        }
    }
}
