using Projeto.Xadrez.CamadaTabuleiro;
using Projeto.Xadrez.CamadaXadrez;

namespace Projeto.Xadrez;

public class Tela
{
    public static void ImprimirPartida(PartidaXadrez partida)
    {
        ImprimirTabuleiro(partida.Tabuleiro);
        Console.WriteLine();
        ImprimirPecasCapturadas(partida);
        Console.WriteLine();
        Console.WriteLine("Turno: " + partida.Turno);
        if (!partida.Terminada)
        {
            Console.WriteLine("Aguardando jogada: " + partida.JogadorAtual);
            if (partida.Xeque)
            {
                Console.WriteLine("XEQUE!");
            }
        }
        else
        {
            Console.WriteLine("XEQUEMATE!");
            Console.WriteLine("Vencedor: " + partida.JogadorAtual);
        }
    }

    public static void ImprimirTabuleiro(Tabuleiro tabuleiro, bool[,] posicoesPossiveis)
    {
        var fundoOriginal = Console.BackgroundColor;
        var fundoAlterado = ConsoleColor.DarkGray;

        for (var i = 0; i < tabuleiro.Linhas; i++)
        {
            Console.Write(8 - i + " ");

            for (var j = 0; j < tabuleiro.Colunas; j++)
            {
                if (posicoesPossiveis[i, j])
                    Console.BackgroundColor = fundoAlterado;
                else
                    Console.BackgroundColor = fundoOriginal;

                ImprimirPeca(tabuleiro.Peca(i, j));
                Console.BackgroundColor = fundoOriginal;
            }

            Console.WriteLine();
        }

        Console.WriteLine("  a b c d e f g h");
        Console.BackgroundColor = fundoOriginal;
    }

    public static PosicaoXadrez LerPosicaoXadrez()
    {
        var s = Console.ReadLine();
        var coluna = s[0];
        var linha = int.Parse(s[1] + "");
        return new PosicaoXadrez(coluna, linha);
    }

    private static void ImprimirTabuleiro(Tabuleiro tabuleiro)
    {
        for (var i = 0; i < tabuleiro.Linhas; i++)
        {
            Console.Write(8 - i + " ");

            for (var j = 0; j < tabuleiro.Colunas; j++)
                ImprimirPeca(tabuleiro.Peca(i, j));

            Console.WriteLine();
        }

        Console.WriteLine("  a b c d e f g h");
    }

    private static void ImprimirPecasCapturadas(PartidaXadrez partida)
    {
        Console.WriteLine("Peças capturadas:");
        Console.Write("Brancas: ");
        ImprimirConjunto(partida.PecasCapturadas(Cor.Branca));
        Console.WriteLine();
        Console.Write("Pretas: ");
        var consoleColor = Console.ForegroundColor;
        Console.ForegroundColor = ConsoleColor.Yellow;
        ImprimirConjunto(partida.PecasCapturadas(Cor.Preta));
        Console.ForegroundColor = consoleColor;
        Console.WriteLine();
    }

    private static void ImprimirConjunto(HashSet<Peca> conjunto)
    {
        Console.Write("[");

        foreach (var peca in conjunto)
            Console.Write(peca + " ");

        Console.Write("]");
    }

    private static void ImprimirPeca(Peca peca)
    {
        if (peca == null)
        {
            Console.Write("- ");
            return;
        }

        if (peca.Cor == Cor.Branca)
        {
            Console.Write(peca);
        }
        else
        {
            var consoleColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(peca);
            Console.ForegroundColor = consoleColor;
        }

        Console.Write(" ");
    }
}