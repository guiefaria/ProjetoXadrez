using System;
using tabuleiro;
using Xadrez;

namespace Xadrez_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            //PosicaoXadrez pos = new PosicaoXadrez('a', 1);
           // Console.WriteLine(pos.toPosicao());

            Tabuleiro tab = new Tabuleiro(8, 8);
            try {
                tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 1));
                tab.ColocarPeca(new Rei(tab, Cor.Preta), new Posicao(0, 2));
                Tela.ImprimirTabuleiro(tab);


            Console.WriteLine(tab);
            }catch(TabuleiroException tb)
            {
                Console.WriteLine(tb.Message);
            }
            
        }
    }
}
