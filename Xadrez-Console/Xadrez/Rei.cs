using System;
using System.Collections.Generic;
using System.Text;
using tabuleiro;

namespace Xadrez
{
    class Rei : Peca
    {
        public Rei(Tabuleiro tabuleiro, Cor cor):base(cor, tabuleiro)
        {

        }

        public override string ToString()
        {
            return "R";
        }
    }
}
