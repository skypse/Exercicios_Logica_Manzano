using System;
// Autor: Gabriel do Amaral Alves
// Data: 14/06/24
/* Enunciado: Elaborar um programa que apresente no final o somatório dos valores pares existentes na faixa de 
1 até 500. */

namespace Exercicio_PAG_46_1_C_Manzano
{
    internal class Exercicio_1_C_Manzano
    {
        public static void Main(string[] args)
        {
            int contadora = 1, soma = 0;

            while (contadora <= 500)
            {
                if (contadora % 2 == 0)
                {
                    soma = + contadora;
                    Console.WriteLine(soma);
                }
                contadora++;
            }
        }
    }
}
