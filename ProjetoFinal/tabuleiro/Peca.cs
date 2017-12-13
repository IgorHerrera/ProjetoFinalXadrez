namespace tabuleiro
{
    abstract class Peca
    {
        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; }
        public int quantMoves { get; protected set; }
        public Tabuleiro tab { get; protected set; }

        public Peca(Tabuleiro tab, Cor cor)
        {
            this.posicao = null;
            this.tab = tab;
            this.cor = cor;
            this.quantMoves = 0;
        }

        public void incrementarQuantMoves()
        {
            quantMoves++;
        }

        public bool existeMovesPossiveis()
        {
            bool[,] mat = movesPossiveis();
            for (int i=0; i<tab.linhas; i++)
            {
                for (int j=0; j<tab.colunas; j++)
                {
                    if (mat[i,j])
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool podeMoverPara(Posicao pos)
        {
            return movesPossiveis()[pos.linha, pos.coluna];
        }

        public abstract bool[,] movesPossiveis();

    }
}
