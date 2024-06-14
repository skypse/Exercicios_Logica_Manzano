using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Autor: Gabriel do Amaral Alves
// Data: 14/06/24
/* Enunciado: Apresentar os resultados das potências de 3, variando do expoente 0 até o expoente 15. Deve ser 
considerado que qualquer número elevado a zero é 1, e elevado a 1 é ele próprio. Observe que 
neste exercício não pode ser utilizado o operador de exponenciação do portuguol (^). */

namespace Exercicio_PAG_46_1_E_Manzano
{
    internal class Exercicio_1_E_Manzano
    {
        public static void Main(string[] args)
        {
            int potencia = 1;
            int expoente = 0;

            while (expoente <= 15)
            {
                Console.WriteLine("3 elevado a " + expoente + " é " + potencia);
                potencia *= 3;
                expoente++;
            }
        }
    }
}
