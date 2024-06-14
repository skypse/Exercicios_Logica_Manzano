using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Autor: Gabriel do Amaral Alves
// Data: 14/06/24
/* Enunciado: Elaborar um programa que efetue a leitura de 10 valores numéricos e apresente no final o total do
somatório e a média aritmética dos valores lidos.*/

namespace Exercicio_PAG_46_1_I_Manzano
{
    internal class Exercicio_1_I_Manzano
    {
        public static void Main(string[] args)
        {
            double numero, media, soma = 0;
            int contador = 0;

            while (contador < 10)
            {
                Console.Write("Digite um número (total de 10): ");
                numero = double.Parse(Console.ReadLine());
                soma += numero;
                contador++;
            }

            media = soma / 10;

            Console.WriteLine("Soma: " + soma);
            Console.WriteLine("Média: " + media);
        }
    }
    }
}
