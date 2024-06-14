using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Autor: Gabriel do Amaral Alves
// Data: 14/06/24
/* Enunciado: Elaborar um programa que efetue a leitura de valores positivos inteiros até que um valor negativo
seja informado. Ao final devem ser apresentados o maior e o menor valores informados pelo
usuário.*/

namespace Exercicio_PAG_46_1_L_Manzano
{
    internal class Exercicio_1_L_Manzano
    {
        public static void Main(string[] args)
        {
            int maior = int.MinValue;
            int menor = int.MaxValue;

            Console.WriteLine("Digite valores inteiros positivos (digite um número negativo para parar):");

            int valor = 0;
            while (true)
            {
                Console.Write("Digite um número: ");
                valor = Convert.ToInt32(Console.ReadLine());

                if (valor < 0)
                {
                    break; // caso for negativo, sai do loop
                }

                // atualizar o maior e o menor valor conforme a necessidade
                if (valor > maior)
                {
                    maior = valor;
                }
                if (valor < menor)
                {
                    menor = valor;
                }
            }

            // verifica se algum valor foi digitado antes de mostrar os resultados
            if (maior == int.MinValue && menor == int.MaxValue)
            {
                Console.WriteLine("Nenhum valor positivo foi informado.");
            }
            else
            {
                Console.WriteLine($"Maior valor informado: {maior}");
                Console.WriteLine($"Menor valor informado: {menor}");
            }
        }
    }
}
