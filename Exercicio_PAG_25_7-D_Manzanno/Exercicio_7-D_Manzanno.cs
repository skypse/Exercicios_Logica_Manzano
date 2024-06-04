using System;
using System.Globalization;
// Autor: Gabriel do Amaral Alves
// Data: 04/06/24
// Enunciado: d) Efetuar o cálculo da quantidade de litros de combustível gasta em uma viagem, utilizando um 
//             automóvel que faz 12 Km por litro. Para obter o cálculo, o usuário deve fornecer o tempo gasto 
//             (TEMPO) e a velocidade média (VELOCIDADE) durante a viagem. Desta forma, será possível obter a 
//             distância percorrida com a fórmula DISTANCIA  TEMPO * VELOCIDADE. Possuindo o valor da 
//             distância, basta calcular a quantidade de litros de combustível utilizada na viagem com a fórmula 
//             LITROS_USADOS  DISTANCIA / 12. Ao final, o programa deve apresentar os valores da velocidade 
//             média (VELOCIDADE), tempo gasto na viagem (TEMPO), a distancia percorrida (DISTANCIA) e a 
//             quantidade de litros (LITROS_USADOS) utilizada na viagem.

namespace Exercicio_PAG_25_7_D_Manzanno
{
    internal class Exercicio_7_D_Manzanno
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Programa que efetua o calculo de quanto combustível gasta em uma viagem!");

            // Tempo Gasto
            Console.WriteLine("Digite o tempo gasto: ");
            string? inputTempoGasto = Console.ReadLine();

            // Velocidade Média
            Console.WriteLine("Digite o tempo gasto: ");
            string? inputVelocidadeMedia = Console.ReadLine();

            // Checando se os inputs estão vazios
            if (string.IsNullOrWhiteSpace(inputTempoGasto) && (string.IsNullOrWhiteSpace(inputVelocidadeMedia)))
            {
                Console.WriteLine("Não pode haver campo nulo");
            }
            // Convertendo 'string' para 'double'| setando padrão para utilizar o separador como '.'
            else if (double.TryParse(inputTempoGasto, NumberStyles.Float, CultureInfo.InvariantCulture, out double tempoGasto) &&
                    (double.TryParse(inputVelocidadeMedia, NumberStyles.Float, CultureInfo.InvariantCulture, out double velocidadeMedia)))
            {
                 
            }
        }
    }
}
