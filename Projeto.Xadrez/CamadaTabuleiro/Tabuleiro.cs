namespace Projeto.Xadrez.CamadaTabuleiro;

public class Tabuleiro
{
    public int Linhas { get; }
    public int Colunas { get; }
    private readonly Peca[,] _pecas;

    public Tabuleiro(int linhas, int colunas)
    {
        Linhas = linhas;
        Colunas = colunas;
        _pecas = new Peca[Linhas, Colunas];
    }

    public Peca Peca(int linha, int coluna)
    {
        return _pecas[linha, coluna];
    }

    public Peca Peca(Posicao posicao)
    {
        return _pecas[posicao.Linha, posicao.Coluna];
    }

    public void ColocarPeca(Peca peca, Posicao posicao)
    {
        if (ExistePeca(posicao))
        {
            throw new TabuleiroException("Já existe uma peça nessa posição!");
        }

        _pecas[posicao.Linha, posicao.Coluna] = peca;
        peca.Posicao = posicao;
    }

    public Peca RetirarPeca(Posicao posicao)
    {
        var peca = Peca(posicao);

        if (peca == null)
        {
            return null;
        }

        peca.Posicao = null;
        _pecas[posicao.Linha, posicao.Coluna] = null;
        return peca;
    }

    public bool PosicaoValida(Posicao posicao)
    {
        if (posicao.Linha < 0 || posicao.Linha >= Linhas ||
            posicao.Coluna < 0 || posicao.Coluna >= Colunas)
        {
            return false;
        }

        return true;
    }

    private bool ExistePeca(Posicao posicao)
    {
        ValidarPosicao(posicao);
        return Peca(posicao) != null;
    }

    private void ValidarPosicao(Posicao posicao)
    {
        if (!PosicaoValida(posicao))
        {
            throw new TabuleiroException("Posição inválida!");
        }
    }
}