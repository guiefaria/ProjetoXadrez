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
            for(int i = 0; i < tabuleiro.LinhasTabuleiro; i++)
            { 
                Console.Write(8 - i + " ");
                for (int j = 0; j < tabuleiro.ColunasTabuleiro; j++)
                {
                    if (tabuleiro.peca(i,j)==null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        Tela.imprimirPeca(tabuleiro.peca(i, j));
                    }  

                }
                Console.WriteLine();
            }
           Console.WriteLine("  a b c d e f g h");

        }

        public static void imprimirPeca(Peca peca){
            if(peca.Cor == Cor.Branca)
            {
                Console.WriteLine(peca + " ");
            }
            else
            {
                ConsoleColor aux = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(peca + " ");
                Console.ForegroundColor = aux;
            }
                
        }

    }
}
