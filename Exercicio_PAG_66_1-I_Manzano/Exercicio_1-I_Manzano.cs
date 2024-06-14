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

namespace Exercicio_PAG_66_1_I_Manzano
{
    internal class Exercicio_1_I_Manzano
    {
        public static void Main(string[] args)
        {
            int resultado = 0, valor = 1;

            for (int contadora = 1; contadora <= 15; contadora++)
            {
                resultado += valor;
                valor = resultado - valor;
                Console.WriteLine(resultado);
            }
        }
    }
}
