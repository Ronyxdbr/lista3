/*-------------------------------------------------------------------
Questão 5: Sistema de Recompensas Diárias com Limites e Bônus
Contextualização
Em um jogo online, os jogadores ganham recompensas diárias por logarem consecutivamente. 
A cada dia consecutivo, o valor da recompensa aumenta, mas há um limite diário. Além disso, 
se o jogador atingir certos marcos de dias, recebe bônus adicionais.
Comando
Crie um programa em C# que:
1. Pergunte ao jogador por quantos dias consecutivos ele logou no jogo.
2. Pergunte qual é a recompensa inicial em moedas no primeiro dia.
3. Pergunte qual é o incremento da recompensa a cada dia consecutivo.
4. (Opcional) Pergunte se o jogador deseja considerar bônus por marcos de dias 
(Sim/Não). Se sim, pergunte a cada quantos dias consecutivos há um bônus e qual o 
valor do bônus.
O programa deve calcular e exibir o total de moedas acumuladas pelo jogador, incluindo os 
bônus se aplicável.
@Lista: 03 - Laços de repetição
@Autor: Milton Roney de Oliveira Nobre
@Data: 02/09/2024
---------------------------------------------------------------------*/

using System;
using System.Threading.Channels;
class Program
{
    public static void Main(String[] args)
    {
        double dias, recompensa, incremento, i = 0;
        string? bonus;
        Console.WriteLine("Dias consecutivos: ");
        double.TryParse(Console.ReadLine(), out dias);
        Console.WriteLine("Recompensa inicial: ");
        double.TryParse(Console.ReadLine(), out recompensa);
        Console.WriteLine("Incremento diário: ");
        double.TryParse(Console.ReadLine(), out incremento);
        Console.WriteLine("Bônus por marco de dia? (S/N): ");
        bonus = System.Console.ReadLine();
        
        System.Console.WriteLine(recompensa + );

        Console.WriteLine($"{100 + cura + pontos} Pontos");
        Console.WriteLine("\nPressione ENTER para fechar");
        Console.ReadLine();
    }
}