using Projeto.Xadrez.CamadaTabuleiro;
using Projeto.Xadrez.CamadaXadrez;

namespace Projeto.Xadrez
{
    class Program
    {
        static void ExecutarJogo()
        {
            try
            {
                var partida = new PartidaXadrez();

                while (!partida.Terminada)
                {
                    try
                    {
                        Console.Clear();
                        Tela.ImprimirPartida(partida);

                        Console.WriteLine();
                        Console.Write("Origem: ");

                        var origem = Tela.LerPosicaoXadrez().ToPosicao();
                        partida.ValidarPosicaoDeOrigem(origem);

                        var posicoesPossiveis = partida.Tabuleiro.Peca(origem).MovimentosPossiveis();

                        Console.Clear();
                        Tela.ImprimirTabuleiro(partida.Tabuleiro, posicoesPossiveis);

                        Console.WriteLine();
                        Console.Write("Destino: ");

                        var destino = Tela.LerPosicaoXadrez().ToPosicao();
                        partida.ValidarPosicaoDeDestino(origem, destino);

                        partida.RealizaJogada(origem, destino);
                    }
                    catch (TabuleiroException e)
                    {
                        Console.WriteLine(e.Message);
                        Console.ReadLine();
                    }
                }

                Console.Clear();
                Tela.ImprimirPartida(partida);
            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            ExecutarJogo();
            Console.WriteLine("\nProjeto Jogo de Xadrez!");
        }
    }
}