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

namespace Exercicio_PAG_25_7_D_Manzano
{
    internal class Exercicio_7_D_Manzano
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Programa que efetua o calculo de quanto combustível gasta em uma viagem!");

            // Tempo Gasto
            Console.Write("Digite o tempo gasto (em horas): ");
            string? inputTempoGasto = Console.ReadLine();

            // Velocidade Média
            Console.Write("Digite a velocidade média (em km/h): ");
            string? inputVelocidadeMedia = Console.ReadLine();

            // Checando se os inputs estão vazios
            if (string.IsNullOrWhiteSpace(inputTempoGasto) || (string.IsNullOrWhiteSpace(inputVelocidadeMedia)))
            {
                Console.WriteLine("Não pode haver campo nulo");
            }
            // Convertendo 'string' para 'double'| setando padrão para utilizar o separador como '.'
            else if (double.TryParse(inputTempoGasto, NumberStyles.Float, CultureInfo.InvariantCulture, out double tempo_Gasto) &&
                    (double.TryParse(inputVelocidadeMedia, NumberStyles.Float, CultureInfo.InvariantCulture, out double velocidade_Media)))
            {
                // Distancia percorrida
                double distancia_Percorrida = tempo_Gasto * velocidade_Media;

                // Litros usados
                double litros_Usados = distancia_Percorrida / 12;

                Console.WriteLine($"A velocidade média é de: {velocidade_Media:F2} KM/H");
                Console.WriteLine($"O tempo gasto foi de: {tempo_Gasto:F2} Horas");
                Console.WriteLine($"A distância percorrida foi de: {distancia_Percorrida:F2} Horas");
                Console.WriteLine($"A quantidade de litros usados foi: {litros_Usados:F2}L");
            }
            else
            {
                Console.WriteLine("Entradas inválidas. Por favor, insira valores numéricos.");
            }
        }
    }
}
