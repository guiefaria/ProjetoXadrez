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
    }
}
