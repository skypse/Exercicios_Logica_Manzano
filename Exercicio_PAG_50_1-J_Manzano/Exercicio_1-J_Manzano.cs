using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Autor: Gabriel do Amaral Alves
// Data: 14/06/24
/* Enunciado: Elaborar um programa que apresente o resultado inteiro da divisão de dois números quaisquer.
Para a elaboração do programa, não utilizar em hipótese alguma o conceito do operador aritmético
DIV. A solução deve ser alcançada com a utilização de looping. Ou seja, o programa deve
apresentar como resultado (quociente) quantas vezes o divisor cabe no dividendo..*/

namespace Exercicio_PAG_50_1_J_Manzano
{
    internal class Exercicio_1_J_Manzano
    {
        public static void Main(string[] args)
        {
            int dividendo, divisor, quociente;

            Console.Write("Digite o dividendo (número a ser dividido): ");
            dividendo = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o divisor (número pelo qual dividir): ");
            divisor = Convert.ToInt32(Console.ReadLine());

            // verifica se o divisor é diferente de zero
            if (divisor != 0)
            {
                quociente = 0;
                while (dividendo >= divisor)
                {
                    dividendo -= divisor;  // subtrai o divisor do dividendo
                    quociente++;           // incrementa o quociente
                }

                // exibe o resultado da divisão
                Console.WriteLine($"O quociente da divisão é: {quociente}");
            }
            else
            {
                Console.WriteLine("Não é possível dividir por zero.");
            }
        }
    }
}
