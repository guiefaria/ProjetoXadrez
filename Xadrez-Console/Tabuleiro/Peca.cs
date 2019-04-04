namespace tabuleiro
{
    class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int Qtdovimentos { get; set; }
        public Tabuleiro Tabuleiro { get; protected set; }

        public Peca(Posicao posicao, Cor cor , Tabuleiro tabuleiro)
        {
            Posicao = posicao;
            Cor = cor;
            Qtdovimentos = 0;
            Tabuleiro = tabuleiro;
        }
    }
}
