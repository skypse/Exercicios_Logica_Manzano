using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Autor: Gabriel do Amaral Alves
// Data: 14/06/24
/* Enunciado: Elaborar um programa que efetue a leitura sucessiva de valores numéricos e apresente no final o
total do somatório, a média aritmética e o total de valores lidos. O programa deve fazer as leituras
dos valores enquanto o usuário estiver fornecendo valores positivos. Ou seja, o programa deve
parar quando o usuário fornecer um valor negativo. Não se esqueça que o usuário pode entrar
como primeiro número um número negativo, portanto, cuidado com a divisão por zero no cálculo da
média.*/

namespace Exercicio_PAG_50_1_F_Manzano
{
    internal class Exercicio_1_F_Manzano
    {
        public static void Main(string[] args)
        {
            int contadora = 0;
            double numero;
            double soma = 0;
            double media;
            double converter;

            do
            {
                Console.WriteLine("Quando um número negativo for digitado será desativado o loop");
                Console.Write("Digite um número: ");
                numero = Convert.ToDouble(Console.ReadLine());
                soma += numero;

                if (numero < 0)
                {
                    converter = numero * (-1);
                    soma += converter;
                }

                contadora++;
            } while (numero >= 0);

            contadora--;

            if (contadora > 0)
            {
                media = soma / contadora;
            }
            else
            {
                media = 0;
            }

            Console.WriteLine("A soma de todos os números é: " + soma);
            Console.WriteLine("A média aritmética é: " + media);
            Console.WriteLine("A quantidade de números digitados foi: " + contadora);
        }
    }
}
