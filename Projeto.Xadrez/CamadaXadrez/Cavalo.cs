using Projeto.Xadrez.CamadaTabuleiro;

namespace Projeto.Xadrez.CamadaXadrez;

public class Cavalo : Peca
{
    public Cavalo(Tabuleiro tabuleiro, Cor cor) : base(tabuleiro, cor)
    {
    }

    public override string ToString() => "C";

    public override bool[,] MovimentosPossiveis()
    {
        var matriz = new bool[Tabuleiro.Linhas, Tabuleiro.Colunas];

        var posicao = new Posicao(0, 0);

        posicao.DefinirValores(Posicao.Linha - 1, Posicao.Coluna - 2);
        if (Tabuleiro.PosicaoValida(posicao) && PodeMover(posicao))
        {
            matriz[posicao.Linha, posicao.Coluna] = true;
        }

        posicao.DefinirValores(Posicao.Linha - 2, Posicao.Coluna - 1);
        if (Tabuleiro.PosicaoValida(posicao) && PodeMover(posicao))
        {
            matriz[posicao.Linha, posicao.Coluna] = true;
        }

        posicao.DefinirValores(Posicao.Linha - 2, Posicao.Coluna + 1);
        if (Tabuleiro.PosicaoValida(posicao) && PodeMover(posicao))
        {
            matriz[posicao.Linha, posicao.Coluna] = true;
        }

        posicao.DefinirValores(Posicao.Linha - 1, Posicao.Coluna + 2);
        if (Tabuleiro.PosicaoValida(posicao) && PodeMover(posicao))
        {
            matriz[posicao.Linha, posicao.Coluna] = true;
        }

        posicao.DefinirValores(Posicao.Linha + 1, Posicao.Coluna + 2);
        if (Tabuleiro.PosicaoValida(posicao) && PodeMover(posicao))
        {
            matriz[posicao.Linha, posicao.Coluna] = true;
        }

        posicao.DefinirValores(Posicao.Linha + 2, Posicao.Coluna + 1);
        if (Tabuleiro.PosicaoValida(posicao) && PodeMover(posicao))
        {
            matriz[posicao.Linha, posicao.Coluna] = true;
        }

        posicao.DefinirValores(Posicao.Linha + 2, Posicao.Coluna - 1);
        if (Tabuleiro.PosicaoValida(posicao) && PodeMover(posicao))
        {
            matriz[posicao.Linha, posicao.Coluna] = true;
        }

        posicao.DefinirValores(Posicao.Linha + 1, Posicao.Coluna - 2);
        if (Tabuleiro.PosicaoValida(posicao) && PodeMover(posicao))
        {
            matriz[posicao.Linha, posicao.Coluna] = true;
        }

        return matriz;
    }

    private bool PodeMover(Posicao posicao)
    {
        var peca = Tabuleiro.Peca(posicao);
        return peca == null || peca.Cor != Cor;
    }
}