using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Autor: Gabriel do Amaral Alves
// Data: 14/06/24
/* Enunciado: Apresentar todos os valores numéricos inteiros ímpares situados na faixa de 0 a 20. Para verificar
se o número é ímpar, efetuar dentro da malha a verificação lógica desta condição com a instrução
se, perguntando se o número é ímpar; sendo, mostre-o; não sendo, passe para o próximo passo.*/

namespace Exercicio_PAG_66_1_E_Manzano
{
    internal class Exercicio_1_E_Manzano
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Números ímpares de 0 até 20:");

            for (int contadora = 1; contadora <= 20; contadora++)
            {
                if (contadora % 2 != 0)
                {
                    Console.WriteLine("Números ímpares: " + contadora);
                }
            }
        }
    }
}
