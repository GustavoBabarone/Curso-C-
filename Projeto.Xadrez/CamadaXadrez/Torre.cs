using Projeto.Xadrez.CamadaTabuleiro;

namespace Projeto.Xadrez.CamadaXadrez;

public class Torre : Peca
{
    public Torre(Tabuleiro tabuleiro, Cor cor) : base(tabuleiro, cor)
    {
    }

    public override string ToString() => "T";

    public override bool[,] MovimentosPossiveis()
    {
        var matriz = new bool[Tabuleiro.Linhas, Tabuleiro.Colunas];

        var posicao = new Posicao(0, 0);

        // acima
        posicao.DefinirValores(Posicao.Linha - 1, Posicao.Coluna);
        while (Tabuleiro.PosicaoValida(posicao) && PodeMover(posicao))
        {
            matriz[posicao.Linha, posicao.Coluna] = true;
            var peca = Tabuleiro.Peca(posicao);

            if (peca != null && peca.Cor != Cor)
                break;

            posicao.Linha = posicao.Linha - 1;
        }

        // abaixo
        posicao.DefinirValores(Posicao.Linha + 1, Posicao.Coluna);
        while (Tabuleiro.PosicaoValida(posicao) && PodeMover(posicao))
        {
            matriz[posicao.Linha, posicao.Coluna] = true;
            var peca = Tabuleiro.Peca(posicao);

            if (peca != null && peca.Cor != Cor)
                break;

            posicao.Linha = posicao.Linha + 1;
        }

        // direita
        posicao.DefinirValores(Posicao.Linha, Posicao.Coluna + 1);
        while (Tabuleiro.PosicaoValida(posicao) && PodeMover(posicao))
        {
            matriz[posicao.Linha, posicao.Coluna] = true;
            var peca = Tabuleiro.Peca(posicao);

            if (peca != null && peca.Cor != Cor)
                break;

            posicao.Coluna = posicao.Coluna + 1;
        }

        // esquerda
        posicao.DefinirValores(Posicao.Linha, Posicao.Coluna - 1);
        while (Tabuleiro.PosicaoValida(posicao) && PodeMover(posicao))
        {
            matriz[posicao.Linha, posicao.Coluna] = true;
            var peca = Tabuleiro.Peca(posicao);

            if (peca != null && peca.Cor != Cor)
                break;

            posicao.Coluna = posicao.Coluna - 1;
        }

        return matriz;
    }

    private bool PodeMover(Posicao posicao)
    {
        var peca = Tabuleiro.Peca(posicao);
        return peca == null || peca.Cor != Cor;
    }
}