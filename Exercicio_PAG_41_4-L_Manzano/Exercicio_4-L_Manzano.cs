using System;
// Autor: Gabriel do Amaral Alves
// Data: 06/06/24
/* Enunciado: 4-L) Elaborar um programa que efetue a leitura do nome e do sexo de uma pessoa, apresentando com
saída uma das seguintes mensagens: "Ilmo Sr.", se o sexo informado como masculino, ou a
mensagem "Ilma Sra.", para o sexo informado como feminino. Apresente também junto da
mensagem de saudação o nome previamente informado. */

namespace Exercicio_PAG_41_4_L_Manzano
{
    internal class Exercicio_4_L_Manzano
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Programa que lê o nome e o sexo de uma pessoa e apresenta uma saudação personalizada.");

            // Solicitar valores ao usuário:
            Console.Write("Digite o nome: ");
            string? nome = Console.ReadLine();


            Console.Write("Digite o sexo (M para masculino, F para feminino): ");
            string? sexo = Console.ReadLine();

            // Checando se algum campo está vazio
            if (!string.IsNullOrWhiteSpace(nome) && (!string.IsNullOrWhiteSpace(sexo)))
            {
                if (sexo == "M")
                {
                    Console.WriteLine($"Ilmo Sr. {nome}");
                }
                else if (sexo == "F")
                {
                    Console.WriteLine($"Ilma Sra. {nome}");
                }
                else
                {
                   Console.WriteLine("Sexo informado inválido. Por favor, insira 'M' para masculino ou 'F' para feminino.");
                }
            }
            else
            {
                Console.WriteLine("Nome ou sexo não pode ser nulo ou vazio.");
            }
        }
    }
}
