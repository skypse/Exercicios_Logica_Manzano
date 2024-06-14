using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Autor: Gabriel do Amaral Alves
// Data: 14/06/24
/* Enunciado: Escreva um programa que apresente a série de Fibonacci até o décimo quinto termo. A série de
Fibonacci é formada pela seqüência: 1, 1, 2, 3, 5, 8, 13, 21, 34, ..., etc. Esta série se caracteriza
pela soma de um termo atual com o seu anterior subseqüente, para que seja formado o próximo
valor da seqüência. Portanto começando com os números 1, 1 o próximo termo é 1+1=2, o próximo
é 1+2=3, o próximo é 2+3=5, o próximo 3+5=8, etc.*/

namespace Exercicio_PAG_46_1_G_Manzano
{
    internal class Exercicio_1_G_Manzano
    {
        public static void Main(string[] args)
        {
            int numero1 = 0;
            int numero2 = 1;
            int resultado;
            int contador = 0;

            Console.WriteLine(numero2);

            while (contador < 8)
            {
                resultado = numero1 + numero2;
                numero1 = numero2;
                numero2 = resultado;
                Console.WriteLine(resultado);
                contador++;
            }
        }
    }
}
