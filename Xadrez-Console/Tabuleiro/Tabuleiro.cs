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

        public void ColocarPeca(Peca peca, Posicao pos)
        {
            pecas[pos.Linha, pos.Coluna] = peca;
            peca.Posicao = pos;
        }
    }
}
