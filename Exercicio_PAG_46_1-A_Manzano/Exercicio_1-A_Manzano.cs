using System;
// Autor: Gabriel do Amaral Alves
// Data: 14/06/24
/* Enunciado: Apresentar os resultados de uma tabuada de multiplicar (de 1 até 10) de um número qualquer. */

namespace Exercicio_PAG_46_1_A_Manzano
{
    internal class Exercicio_1_A_Manzano
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite um número: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            int contadora = 1;

            while (contadora < 11) 
            {
                Console.WriteLine(numero + " X " + contadora + " = " + (numero * contadora));
                contadora++;
            }
        }
    }
}
