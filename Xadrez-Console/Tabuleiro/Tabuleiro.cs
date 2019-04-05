namespace tabuleiro
{
    class Tabuleiro
    {
        public int LinhasTabuleiro{ get; set; }
        public int ColunasTabuleiro { get; set; }
        private Peca[,] pecas;

        public Tabuleiro(int linhasTabuleiro, int colunasTabuleiro)
        {
            LinhasTabuleiro = linhasTabuleiro;
            ColunasTabuleiro = colunasTabuleiro;
            pecas = new Peca[linhasTabuleiro, colunasTabuleiro];
        }

        public Peca peca(int linha, int coluna)
        {
            return pecas[linha, coluna];
        }

        public Peca peca(Posicao pos)
        {
            return pecas[pos.Linha, pos.Coluna];
        }

        public void ColocarPeca(Peca peca, Posicao pos)
        {
            if (existePeca(pos))
            {
                throw new TabuleiroException("Já existe uma peça nessa posição! ");
            }
            {
                pecas[pos.Linha, pos.Coluna] = peca;
                peca.Posicao = pos;
            }
        }

        //Verifica se já não possui uma peça na posição e retorna mensagem de que a posição esteja ocupada, caso esteja de fato
        public bool existePeca(Posicao pos)
        {
            ValidarPosicao(pos);
            return peca(pos) != null;
        }

        //Verificar se a posição é válida
        public bool PosicaoValida(Posicao pos)
        {
            if(pos.Linha<0 || pos.Linha>=LinhasTabuleiro || pos.Coluna < 0 || pos.Linha >= ColunasTabuleiro)
            {
                return false;
            }else
            return true;
        }

        //Exceção para caso a posição não seja válida
        public void ValidarPosicao(Posicao pos)
        {
            if (!PosicaoValida(pos))
            {
                throw new TabuleiroException("Posição inválida! ");
            }
        }
    }
}
