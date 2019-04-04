using System;
using System.Collections.Generic;
using System.Text;
using tabuleiro;

namespace Xadrez
{
    class Torre : Peca
    {
        public Torre(Tabuleiro tabuleiro, Cor cor) : base(cor,tabuleiro)
        {

        }

        public override string ToString()
        {
            return "T";
        }
    }
}
