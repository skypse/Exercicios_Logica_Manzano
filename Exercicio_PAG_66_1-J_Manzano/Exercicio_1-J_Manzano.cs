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

namespace Exercicio_PAG_66_1_J_Manzano
{
    internal class Exercicio_1_J_Manzano
    {
        public static void Main(string[] args)
        {
            int celsius = 0, fahrenheit = 0;

            for (int contadora = 1; contadora <= 10; contadora++)
            {
                celsius += 10;
                fahrenheit = (9 * celsius + 160) / 5;
                Console.WriteLine("Graus Celsius: " + celsius + "ºC | Graus Fahrenheit: " + fahrenheit + "ºF");
            }
        }
    }
}
