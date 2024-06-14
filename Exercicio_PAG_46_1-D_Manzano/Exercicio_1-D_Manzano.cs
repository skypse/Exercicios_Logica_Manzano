using System;
// Autor: Gabriel do Amaral Alves
// Data: 14/06/24
/* Enunciado: Apresentar todos os valores numéricos inteiros ímpares situados na faixa de 0 a 20. Para verificar 
se o número é ímpar, efetuar dentro da malha a verificação lógica desta condição com a instrução 
se, perguntando se o número é ímpar; sendo, mostre-o; não sendo, passe para o próximo passo */

namespace Exercicio_PAG_46_1_D_Manzano
{
    internal class Exercicio_1_D_Manzano
    {
        public static void Main(string[] args)
        {
            int contadora = 1;

            while (contadora <= 19)
            {
                if (contadora % 2 != 0)
                {
                    Console.WriteLine(contadora);
                }
                contadora++;
            }
        }
    }
}
