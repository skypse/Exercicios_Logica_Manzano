using System;
using System.Globalization;
// Autor: Gabriel do Amaral Alves
// Data: 05/06/24
/* Enunciado: 1-C) Em uma eleição sindical concorreram ao cargo de presidente três candidatos (A, B e C). Durante a 
apuração dos votos foram computados votos nulos e votos em branco, além dos votos válidos para 
cada candidato. Deve ser criado um programa de computador que efetue a leitura da quantidade de 
votos válidos para cada candidato, além de efetuar também a leitura da quantidade de votos nulos e 
votos em branco. Ao final o programa deve apresentar o número total de eleitores, considerando votos 
válidos, nulos e em branco; o percentual correspondente de votos válidos em relação à quantidade de 
eleitores; o percentual correspondente de votos válidos do candidato A em relação à quantidade de 
eleitores; o percentual correspondente de votos válidos do candidato B em relação à quantidade de 
eleitores; o percentual correspondente de votos válidos do candidato C em relação à quantidade de 
eleitores; o percentual correspondente de votos nulos em relação à quantidade de eleitores; e por último 
o percentual correspondente de votos em branco em relação à quantidade de eleitores.*/

namespace Exercicio_PAG_26_3._10_1_C_Manzano
{
    internal class Exercicio_1_C_Manzano
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Programa que faz eleição sindical");
            Console.WriteLine("-----------------------------------------------------------------");

            // Solicitar os valores ao usuário
            Console.Write("Digite a quantidade de votos do Canditado A: ");
            string? inputVotosCandidatoA = Console.ReadLine();

            Console.Write("Digite a quantidade de votos do Canditado B: ");
            string? inputVotosCandidatoB = Console.ReadLine();

            Console.Write("Digite a quantidade de votos do Canditado C: ");
            string? inputVotosCandidatoC = Console.ReadLine();

            Console.Write("Digite a quantidade de votos nulos: ");
            string? inputVotosNulo = Console.ReadLine();

            Console.Write("Digite a quantidade de votos brancos: ");
            string? inputVotosBranco = Console.ReadLine();

            // Checando se algum campo está vázio
            if (string.IsNullOrWhiteSpace(inputVotosCandidatoA) || (string.IsNullOrWhiteSpace(inputVotosCandidatoB)) ||
               (string.IsNullOrWhiteSpace(inputVotosCandidatoC) || (string.IsNullOrWhiteSpace(inputVotosNulo)) ||
               (string.IsNullOrWhiteSpace(inputVotosBranco))))
            {
                Console.WriteLine("Não pode haver nenhum campo nulo");
            }
            // Convertendo string para int
            else if (int.TryParse(inputVotosCandidatoA, NumberStyles.Integer, CultureInfo.InvariantCulture, out int votosCanditatoA) &&
                    (int.TryParse(inputVotosCandidatoB, NumberStyles.Integer, CultureInfo.InvariantCulture, out int votosCanditatoB)) &&
                    (int.TryParse(inputVotosCandidatoC, NumberStyles.Integer, CultureInfo.InvariantCulture, out int votosCanditatoC)) &&
                    (int.TryParse(inputVotosNulo, NumberStyles.Integer, CultureInfo.InvariantCulture, out int votosNulo)) &&
                    (int.TryParse(inputVotosBranco, NumberStyles.Integer, CultureInfo.InvariantCulture, out int votosBranco)))
            {
                // Total votos
                double totalVotos = votosCanditatoA + votosCanditatoB + votosCanditatoC + votosNulo + votosBranco;

                // Percentual A
                double percentualCanditatoA = (votosCanditatoA / totalVotos) * 100;

                // Percentual B
                double percentualCanditatoB = (votosCanditatoB / totalVotos) * 100;

                // Percentual C
                double percentualCanditatoC = (votosCanditatoC / totalVotos) * 100;

                // Percentual Votos Válidos
                double percentualVotosValidos = ((votosCanditatoA + votosCanditatoB + votosCanditatoC) / totalVotos) * 100d;

                // Percentual Votos Nulos
                double percentualVotosNulo = (votosNulo / totalVotos) * 100;

                // Percentual Votos Brancos
                double percentualVotosBranco = (votosBranco / totalVotos) * 100;

                Console.WriteLine("-----------------------------------------------------------------");
                Console.WriteLine($"O número total de eleitores: {totalVotos}");
                Console.WriteLine($"Percentual de votos válidos: {percentualVotosValidos:F2}%");
                Console.WriteLine($"Percentual de votos válidos do candidato A: {percentualCanditatoA:F2}%");
                Console.WriteLine($"Percentual de votos válidos do candidato B: {percentualCanditatoB:F2}%");
                Console.WriteLine($"Percentual de votos válidos do candidato C: {percentualCanditatoC:F2}%");
                Console.WriteLine($"Percentual de votos nulos: {percentualVotosNulo:F2}%");
                Console.WriteLine($"Percentual de votos em branco: {percentualVotosBranco:F2}%");
                Console.WriteLine("-----------------------------------------------------------------");
            }
            else
            {
                Console.WriteLine("Entradas inválidas. Por favor, insira valores numéricos inteiros.");
            }
        }
    }
}
