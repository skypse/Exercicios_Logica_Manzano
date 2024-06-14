using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Autor: Gabriel do Amaral Alves
// Data: 14/06/24
/* Enunciado: Apresentar todos os números divisíveis por 4 que sejam menores que 200. Para verificar se o
número é divisível por 4, efetuar dentro da malha a verificação lógica desta condição com a
instrução se, perguntando se o número é divisível; sendo, mostre-o; não sendo, passe para o
próximo passo. A variável que controlará o contador deve ser iniciada com o valor 1.*/

namespace Exercicio_PAG_66_1_F_Manzano
{
    internal class Exercicio_1_F_Manzano
    {
        public static void Main(string[] args)
        {
            for (int contadora = 1; contadora <= 200; contadora++)
            {
                if (contadora % 4 == 0)
                {
                    Console.WriteLine(contadora);
                }
            }
        }
    }
}
