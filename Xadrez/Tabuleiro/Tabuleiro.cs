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

    public Peca peca(Posicao pos)
    {
        return _pecas[pos.Linha, pos.Coluna];
    }

    public bool ExistePeca(Posicao pos)
    {
        ValidarPosicao(pos);
        return peca(pos) != null;
    }

    public void ColocarPeca(Peca peca, Posicao posicao)
    {
        if (ExistePeca(posicao))
        {
            throw new TabuleiroException("Já existe uma peça nessa posição");
        }
        _pecas[posicao.Linha, posicao.Coluna] = peca;
        peca.posicao = posicao;
    }

    public bool PosicaoValida(Posicao pos)
    {
        if (pos.Linha < 0 || pos.Linha > linhas || pos.Coluna < 0 || pos.Coluna >= colunas)
        {
            return false;
        }

        return true;
    }

    public void ValidarPosicao(Posicao pos)
    {
        if (!PosicaoValida(pos))
        {
            throw new TabuleiroException("Posição Inválida");
        }
    }
}