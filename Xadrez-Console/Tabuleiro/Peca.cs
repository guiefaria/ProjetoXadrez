namespace tabuleiro
{
    class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int Qtdovimentos { get; set; }
        public Tabuleiro Tabuleiro { get; protected set; }

        public Peca(Cor cor , Tabuleiro tabuleiro)
        {
            Posicao = null;
            Cor = cor;
            Qtdovimentos = 0;
            Tabuleiro = tabuleiro;
        }
    }
}
