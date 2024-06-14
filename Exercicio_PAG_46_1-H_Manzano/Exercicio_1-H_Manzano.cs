using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Autor: Gabriel do Amaral Alves
// Data: 14/06/24
/* Enunciado: Elaborar um programa que apresente os valores de conversão de graus Celsius em Fahrenheit, de
10 em 10 graus, iniciando a contagem em 10 graus Celsius e finalizando em 100 graus Celsius. O
programa deve apresentar os valores das duas temperaturas. A fórmula de conversão
é
5
9 +160
=
C
F , sendo F a temperatura em Fahrenheit e C a temperatura em Celsius.*/

namespace Exercicio_PAG_46_1_H_Manzano
{
    internal class Exercicio_1_H_Manzano
    {
        public static void Main(string[] args)
        {
            int celsius = 10;
            double fahrenheit;

            Console.WriteLine("Celsius\tFahrenheit");

            while (celsius <= 100)
            {
                fahrenheit = (9.0 / 5.0) * celsius + 32;
                Console.WriteLine(celsius + "ºC\t " + fahrenheit + "ºF");
                celsius += 10;
            }
        }
    }
}
