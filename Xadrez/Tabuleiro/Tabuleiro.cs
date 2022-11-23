namespace Xadrez.Tabuleiro;

public class Tabuleiro
{
    public int linhas { get; set; }
    public int colunas { get; set; }
    private Peca[,] _pecas;

    public Tabuleiro(int linhas, int colunas)
    {
        this.linhas = linhas;
        this.colunas = colunas;
        _pecas = new Peca[linhas, colunas];
    }

    public Peca peca(int linhas, int colunas)
    {
        return _pecas[linhas, colunas];
    }
}