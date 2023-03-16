namespace Projeto.Xadrez.CamadaTabuleiro;

public abstract class Peca
{
    public Tabuleiro Tabuleiro { get; protected set; }
    public Cor Cor { get; protected set; }
    public Posicao Posicao { get; set; }
    public int QteMovimentos { get; protected set; }

    public Peca(Tabuleiro tabuleiro, Cor cor)
    {
        Tabuleiro = tabuleiro;
        Cor = cor;
        Posicao = null;
        QteMovimentos = 0;
    }

    public void IncrementarQteMovimentos() => QteMovimentos++;

    public void DecrementarQteMovimentos() => QteMovimentos--;

    public bool ExisteMovimentosPossiveis()
    {
        var matriz = MovimentosPossiveis();

        for (var i = 0; i < Tabuleiro.Linhas; i++)
        {
            for (var j = 0; j < Tabuleiro.Colunas; j++)
            {
                if (matriz[i, j])
                {
                    return true;
                }
            }
        }

        return false;
    }

    public bool MovimentoPossivel(Posicao posicao)
    {
        return MovimentosPossiveis()[posicao.Linha, posicao.Coluna];
    }

    public abstract bool[,] MovimentosPossiveis();
}