/*-------------------------------------------------------------------
Questão 3: Gerenciamento de Inventário com Limite e Tipos de
Itens
Contextualização
Em um RPG, o jogador gerencia um inventário com diferentes tipos de itens, cada um com sua
quantidade específica. O inventário tem um limite máximo de itens que pode conter.
Comando:
Crie um programa em C# que:
1. Pergunte ao jogador quantos tipos diferentes de itens ele deseja armazenar no
inventário.
2. Para cada tipo de item, pergunte o nome do item e quantos itens desse tipo ele possui.
3. Pergunte ao jogador qual é a capacidade máxima do inventário.
O programa deve calcular e mostrar a quantidade total de itens no inventário e verificar se está
dentro da capacidade máxima, informando se está excedido ou não.
@Lista: 03 - Laços de repetição
@Autor: Milton Roney de Oliveira Nobre
@Data: 27/08/2024
---------------------------------------------------------------------*/

using System;
class Program
{
    public static void Main(String[] args)
    {
        int tipos, missao, dificuldade, inimigos, i = 0;
        Console.WriteLine("Missões completadas: ");
        int.TryParse(Console.ReadLine(), out missao);

        while (i < missao)
        {
            Console.WriteLine("teste");
            Console.WriteLine($"Dificuldade (missão {i + 1}):\n1 - Fácil (50 pontos por inimigos)\n2 - Médio (100 pontos por inimigos\n3 - Difícil (150 pontos por inimigo)");
            int.TryParse(Console.ReadLine(), out dificuldade);
            Console.WriteLine($"Inimigos derrotados (missão {i + 1}): ");
            int.TryParse(Console.ReadLine(), out inimigos);

            if (dificuldade == 1)
            {
                pontos = pontos + (inimigos * 50);
            }
            else if (dificuldade == 2)
            {
                pontos = pontos + (inimigos * 100);
            }
            else if (dificuldade == 3)
            {
                pontos = pontos + (inimigos * 150);
            }
            i++;
        }

        Console.WriteLine($"{pontos} Pontos");
        Console.WriteLine("\nPressione ENTER para fechar");
        Console.ReadLine();
    }
}