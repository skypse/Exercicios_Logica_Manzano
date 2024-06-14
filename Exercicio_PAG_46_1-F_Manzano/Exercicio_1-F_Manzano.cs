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

namespace Exercicio_PAG_46_1_F_Manzano
{
    internal class Exercicio_1_F_Manzano
    {
        public static void Main(string[] args)
        {
            int baseValue, expoente, resultado;
            resultado = 1;

            Console.Write("Digite o valor da base: ");
            baseValue = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor do expoente: ");
            expoente = int.Parse(Console.ReadLine());

            int i = 1;
            while (i <= expoente)
            {
                resultado *= baseValue;
                i++;
            }

            Console.WriteLine("O resultado de " + baseValue + " elevado a " + expoente + " é: " + resultado);
        }
    }
}
