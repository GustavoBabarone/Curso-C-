namespace Projeto.Xadrez.CamadaTabuleiro;

public class Posicao
{
    public int Linha { get; set; }
    public int Coluna { get; set; }

    public Posicao(int linha, int coluna)
    {
        DefinirValores(linha, coluna);
    }

    public void DefinirValores(int linha, int coluna)
    {
        Linha = linha;
        Coluna = coluna;
    }

    public override string ToString()
    {
        return Linha + ", " + Coluna;
    }
}