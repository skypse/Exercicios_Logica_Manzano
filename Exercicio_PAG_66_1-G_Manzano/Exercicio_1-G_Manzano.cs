using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Autor: Gabriel do Amaral Alves
// Data: 14/06/24
/* Enunciado: Apresentar os resultados das potências de 3, variando do expoente 0 até o expoente 15. Deve ser
considerado que qualquer número elevado a zero é 1, e elevado a 1 é ele próprio. Observe que
neste exercício não pode ser utilizado o operador de exponenciação do portuguol (^).*/

namespace Exercicio_PAG_66_1_G_Manzano
{
    internal class Exercicio_1_G_Manzano
    {
        public static void Main(string[] args)
        {
            int valor = 3;
            int resultado = 1;

            Console.WriteLine($"{valor} ^ 0 = {resultado}");

            for (int contadora = 1; contadora <= 15; contadora++)
            {
                resultado *= valor;
                Console.WriteLine($"{valor} ^ {contadora} = {resultado}");
            }
        }
    }
}
