using Xadrez;
using Xadrez.Tabuleiro;
using Xadrez.Xadrez;


try
{
    Tabuleiro tab = new Tabuleiro(8, 8);
    tab.ColocarPeca(new Rei(tab, Cor.Branca), new Posicao(0, 0));
    tab.ColocarPeca(new Torre(tab, Cor.Amarela), new Posicao(4, 5));
    Tela.ImprimirTabuleiro(tab);
}
catch (TabuleiroException e)
{
    Console.WriteLine(e.Message);
}
