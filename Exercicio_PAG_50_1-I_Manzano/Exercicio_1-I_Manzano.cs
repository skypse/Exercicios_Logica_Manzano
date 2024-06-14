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

namespace Exercicio_PAG_50_1_I_Manzano
{
    internal class Exercicio_1_I_Manzano
    {
        public static void Main(string[] args)
        {
            int total = 0;
            int quantidadeValores = 0;
            int valor;
            int maior = int.MinValue;
            int menor = int.MaxValue;
            Console.WriteLine("Seleciona o maior e menor número, em um loop.");
            do
            {
                Console.Write("Insira um valor (valor negativo para sair): ");
                valor = Convert.ToInt32(Console.ReadLine());

                if (valor >= 0)
                {
                    if (quantidadeValores == 0)
                    {
                        maior = valor;
                        menor = valor;
                    }
                    else
                    {
                        if (valor > maior)
                        {
                            maior = valor;
                        }
                        if (valor < menor)
                        {
                            menor = valor;
                        }
                    }

                    total += valor;
                    quantidadeValores++;
                }

            } while (valor >= 0);

            if (quantidadeValores > 0)
            {
                Console.WriteLine($"O maior valor informado foi: {maior}");
                Console.WriteLine($"O menor valor informado foi: {menor}");
            }
            else
            {
                Console.WriteLine("Nenhum valor positivo foi informado.");
            }
        }
    }
}
