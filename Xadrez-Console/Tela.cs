using System;
using System.Collections.Generic;
using System.Text;
using tabuleiro;

namespace Xadrez_Console
{
    class Tela
    {
        public static void ImprimirTabuleiro(Tabuleiro tabuleiro)
        {
            for(int i = 0; i < tabuleiro.ColunasTabuleiro; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < tabuleiro.LinhasTabuleiro; j++)
                {
                    if (tabuleiro.peca(i,j)==null)
                    {
                        Console.Write(" - ");
                    }
                    else
                    {
                        Console.Write(tabuleiro.peca(i,j));
                    }  
                }
            }
            Console.WriteLine();
        }
    }
}
