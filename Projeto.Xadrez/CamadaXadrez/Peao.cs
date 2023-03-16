using Projeto.Xadrez.CamadaTabuleiro;

namespace Projeto.Xadrez.CamadaXadrez;

public class Peao : Peca
{
    private readonly PartidaXadrez _partida;

    public Peao(Tabuleiro tabuleiro, Cor cor, PartidaXadrez partida) : base(tabuleiro, cor)
    {
        _partida = partida;
    }

    public override string ToString() => "P";

    public override bool[,] MovimentosPossiveis()
    {
        var matriz = new bool[Tabuleiro.Linhas, Tabuleiro.Colunas];

        var posicao = new Posicao(0, 0);

        if (Cor == Cor.Branca)
        {
            posicao.DefinirValores(Posicao.Linha - 1, Posicao.Coluna);
            if (Tabuleiro.PosicaoValida(posicao) && Livre(posicao))
            {
                matriz[posicao.Linha, posicao.Coluna] = true;
            }

            posicao.DefinirValores(Posicao.Linha - 2, Posicao.Coluna);
            var p2 = new Posicao(Posicao.Linha - 1, Posicao.Coluna);
            if (Tabuleiro.PosicaoValida(p2) && Livre(p2) && Tabuleiro.PosicaoValida(posicao) && Livre(posicao) && QteMovimentos == 0)
            {
                matriz[posicao.Linha, posicao.Coluna] = true;
            }

            posicao.DefinirValores(Posicao.Linha - 1, Posicao.Coluna - 1);
            if (Tabuleiro.PosicaoValida(posicao) && ExisteInimigo(posicao))
            {
                matriz[posicao.Linha, posicao.Coluna] = true;
            }

            posicao.DefinirValores(Posicao.Linha - 1, Posicao.Coluna + 1);
            if (Tabuleiro.PosicaoValida(posicao) && ExisteInimigo(posicao))
            {
                matriz[posicao.Linha, posicao.Coluna] = true;
            }

            // #jogadaespecial en passant
            if (Posicao.Linha == 3)
            {
                var esquerda = new Posicao(Posicao.Linha, Posicao.Coluna - 1);
                if (Tabuleiro.PosicaoValida(esquerda) && ExisteInimigo(esquerda) && Tabuleiro.Peca(esquerda) == _partida.VulneravelEnPassant)
                {
                    matriz[esquerda.Linha - 1, esquerda.Coluna] = true;
                }

                var direita = new Posicao(Posicao.Linha, Posicao.Coluna + 1);
                if (Tabuleiro.PosicaoValida(direita) && ExisteInimigo(direita) && Tabuleiro.Peca(direita) == _partida.VulneravelEnPassant)
                {
                    matriz[direita.Linha - 1, direita.Coluna] = true;
                }
            }
        }
        else
        {
            posicao.DefinirValores(Posicao.Linha + 1, Posicao.Coluna);
            if (Tabuleiro.PosicaoValida(posicao) && Livre(posicao))
            {
                matriz[posicao.Linha, posicao.Coluna] = true;
            }

            posicao.DefinirValores(Posicao.Linha + 2, Posicao.Coluna);
            var p2 = new Posicao(Posicao.Linha + 1, Posicao.Coluna);
            if (Tabuleiro.PosicaoValida(p2) && Livre(p2) && Tabuleiro.PosicaoValida(posicao) && Livre(posicao) && QteMovimentos == 0)
            {
                matriz[posicao.Linha, posicao.Coluna] = true;
            }

            posicao.DefinirValores(Posicao.Linha + 1, Posicao.Coluna - 1);
            if (Tabuleiro.PosicaoValida(posicao) && ExisteInimigo(posicao))
            {
                matriz[posicao.Linha, posicao.Coluna] = true;
            }

            posicao.DefinirValores(Posicao.Linha + 1, Posicao.Coluna + 1);
            if (Tabuleiro.PosicaoValida(posicao) && ExisteInimigo(posicao))
            {
                matriz[posicao.Linha, posicao.Coluna] = true;
            }

            // #jogadaespecial en passant
            if (Posicao.Linha == 4)
            {
                var esquerda = new Posicao(Posicao.Linha, Posicao.Coluna - 1);
                if (Tabuleiro.PosicaoValida(esquerda) && ExisteInimigo(esquerda) && Tabuleiro.Peca(esquerda) == _partida.VulneravelEnPassant)
                {
                    matriz[esquerda.Linha + 1, esquerda.Coluna] = true;
                }

                var direita = new Posicao(Posicao.Linha, Posicao.Coluna + 1);
                if (Tabuleiro.PosicaoValida(direita) && ExisteInimigo(direita) && Tabuleiro.Peca(direita) == _partida.VulneravelEnPassant)
                {
                    matriz[direita.Linha + 1, direita.Coluna] = true;
                }
            }
        }

        return matriz;
    }

    private bool ExisteInimigo(Posicao posicao)
    {
        var peca = Tabuleiro.Peca(posicao);
        return peca != null && peca.Cor != Cor;
    }

    private bool Livre(Posicao posicao)
    {
        return Tabuleiro.Peca(posicao) == null;
    }
}