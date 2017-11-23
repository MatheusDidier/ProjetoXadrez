using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xadrez_console.tabuleiro
{
    abstract class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor{ get; protected set; }
        public int QuantidadeMovimento { get; protected set; }
        public Tabuleiro Tabuleiro { get; protected set; }

        public Peca(Tabuleiro tabuleiro, Cor cor)
        {
            this.Posicao = null;
            this.Tabuleiro = tabuleiro;
            this.Cor = cor;
            this.QuantidadeMovimento = 0;
        }

        public abstract bool[,] movimentosPossiveis();
        

        public void incrementarQtdMovimentos()
        {
            QuantidadeMovimento++;
        }

        public void decrementarQtdMovimentos()
        {
            QuantidadeMovimento--;
        }

        public bool existeMovimentosPossiveis()
        {
            bool[,] mat = movimentosPossiveis();
            for (int i = 0; i < Tabuleiro.Linha; i++)
            {
                for (int j = 0; j < Tabuleiro.Coluna; j++)
                {
                    if (mat[i, j])
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool movimentoPossivel(Posicao pos)
        {
            return movimentosPossiveis()[pos.Linha, pos.Coluna];
        }
         


    }
}
