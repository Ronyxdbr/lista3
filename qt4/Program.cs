/*-------------------------------------------------------------------
Questão 4: Jornada do Herói com Pontos de Vida e Itens de Cura
Contextualização
O herói de um jogo atravessa várias fases, ganhando ou perdendo pontos de vida. Além disso,
em algumas fases, o herói pode usar itens de cura para recuperar pontos de vida.
Comando
Desenvolva um programa em C# que:
1. Pergunte ao jogador quantas fases ele deseja jogar.
2. Para cada fase, pergunte quantos pontos de vida o herói ganhou ou perdeu (valores
positivos indicam ganho e negativos indicam perda).
3. Para cada fase, pergunte se o herói usou um item de cura (Sim/Não). Se sim, pergunte
quantos pontos de cura foram usados.
O programa deve calcular e mostrar a vida total do herói ao final da jornada, considerando que
ele começa com 100 pontos de vida.
@Lista: 03 - Laços de repetição
@Autor: Milton Roney de Oliveira Nobre
@Data: 02/09/2024
---------------------------------------------------------------------*/

using System;
class Program
{
    public static void Main(String[] args)
    {
        double pontos, fases, i = 0, cura = 0;
        string? item;
        Console.WriteLine("Número de fases: ");
        double.TryParse(Console.ReadLine(), out fases);
        System.Console.WriteLine("Pontos por fase: ");
        double.TryParse(Console.ReadLine(), out pontos);
        while (i < fases)
        {

            Console.WriteLine($"Usou itens de cura? ({i + 1}ª fase): ");
            item = Console.ReadLine();

            if (item == "S" || item == "s")
            {
                System.Console.WriteLine("Quantos pontos de cura?");
                double.TryParse(Console.ReadLine(), out cura);
                cura = cura + cura;
            }
            if (item == "N" || item == "n")
            {
                cura = cura + 0;
            }
            i++;
        }

        Console.WriteLine($"{100 + cura + pontos} Pontos");
        Console.WriteLine("\nPressione ENTER para fechar");
        Console.ReadLine();
    }
}