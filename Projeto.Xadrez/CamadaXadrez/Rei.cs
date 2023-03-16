using Projeto.Xadrez.CamadaTabuleiro;

namespace Projeto.Xadrez.CamadaXadrez;

public class Rei : Peca
{
    private readonly PartidaXadrez _partida;

    public Rei(Tabuleiro tabuleiro, Cor cor, PartidaXadrez partida) : base(tabuleiro, cor)
    {
        _partida = partida;
    }

    public override string ToString() => "R";

    public override bool[,] MovimentosPossiveis()
    {
        var matriz = new bool[Tabuleiro.Linhas, Tabuleiro.Colunas];

        var posicao = new Posicao(0, 0);

        // acima
        posicao.DefinirValores(Posicao.Linha - 1, Posicao.Coluna);
        if (Tabuleiro.PosicaoValida(posicao) && PodeMover(posicao))
        {
            matriz[posicao.Linha, posicao.Coluna] = true;
        }

        // ne
        posicao.DefinirValores(Posicao.Linha - 1, Posicao.Coluna + 1);
        if (Tabuleiro.PosicaoValida(posicao) && PodeMover(posicao))
        {
            matriz[posicao.Linha, posicao.Coluna] = true;
        }

        // direita
        posicao.DefinirValores(Posicao.Linha, Posicao.Coluna + 1);
        if (Tabuleiro.PosicaoValida(posicao) && PodeMover(posicao))
        {
            matriz[posicao.Linha, posicao.Coluna] = true;
        }

        // se
        posicao.DefinirValores(Posicao.Linha + 1, Posicao.Coluna + 1);
        if (Tabuleiro.PosicaoValida(posicao) && PodeMover(posicao))
        {
            matriz[posicao.Linha, posicao.Coluna] = true;
        }

        // abaixo
        posicao.DefinirValores(Posicao.Linha + 1, Posicao.Coluna);
        if (Tabuleiro.PosicaoValida(posicao) && PodeMover(posicao))
        {
            matriz[posicao.Linha, posicao.Coluna] = true;
        }

        // so
        posicao.DefinirValores(Posicao.Linha + 1, Posicao.Coluna - 1);
        if (Tabuleiro.PosicaoValida(posicao) && PodeMover(posicao))
        {
            matriz[posicao.Linha, posicao.Coluna] = true;
        }

        // esquerda
        posicao.DefinirValores(Posicao.Linha, Posicao.Coluna - 1);
        if (Tabuleiro.PosicaoValida(posicao) && PodeMover(posicao))
        {
            matriz[posicao.Linha, posicao.Coluna] = true;
        }

        // no
        posicao.DefinirValores(Posicao.Linha - 1, Posicao.Coluna - 1);
        if (Tabuleiro.PosicaoValida(posicao) && PodeMover(posicao))
        {
            matriz[posicao.Linha, posicao.Coluna] = true;
        }

        // #jogadaespecial roque
        if (QteMovimentos == 0 && !_partida.Xeque)
        {
            // #jogadaespecial roque pequeno
            var posT1 = new Posicao(Posicao.Linha, Posicao.Coluna + 3);
            if (TesteTorreParaRoque(posT1))
            {
                var p1 = new Posicao(Posicao.Linha, Posicao.Coluna + 1);
                var p2 = new Posicao(Posicao.Linha, Posicao.Coluna + 2);

                if (Tabuleiro.Peca(p1) == null && Tabuleiro.Peca(p2) == null)
                {
                    matriz[Posicao.Linha, Posicao.Coluna + 2] = true;
                }
            }

            // #jogadaespecial roque grande
            var posT2 = new Posicao(Posicao.Linha, Posicao.Coluna - 4);
            if (TesteTorreParaRoque(posT2))
            {
                var p1 = new Posicao(Posicao.Linha, Posicao.Coluna - 1);
                var p2 = new Posicao(Posicao.Linha, Posicao.Coluna - 2);
                var p3 = new Posicao(Posicao.Linha, Posicao.Coluna - 3);

                if (Tabuleiro.Peca(p1) == null && Tabuleiro.Peca(p2) == null && Tabuleiro.Peca(p3) == null)
                {
                    matriz[Posicao.Linha, Posicao.Coluna - 2] = true;
                }
            }
        }

        return matriz;
    }

    private bool PodeMover(Posicao posicao)
    {
        var peca = Tabuleiro.Peca(posicao);
        return peca == null || peca.Cor != Cor;
    }

    private bool TesteTorreParaRoque(Posicao posicao)
    {
        var peca = Tabuleiro.Peca(posicao);
        return peca != null && peca is Torre && peca.Cor == Cor && peca.QteMovimentos == 0;
    }
}