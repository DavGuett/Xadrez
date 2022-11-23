namespace Xadrez.Xadrez;
using Tabuleiro;

public class Rei : Peca
{
    public Rei(Tabuleiro tab, Cor cor) : base(tab, cor)
    {
        
    }

    public override string ToString()
    {
        return "R";
    }
}