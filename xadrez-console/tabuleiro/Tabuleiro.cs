using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xadrez_console.tabuleiro
{
    class Tabuleiro
    {
        public int Linha { get; set; }
        public int Coluna { get; set; }
        private Peca[,] pecas;

        public Tabuleiro(int linha, int coluna)
        {
            this.Linha = linha;
            this.Coluna = coluna;
            pecas = new Peca[linha, coluna];
        }

        public Peca peca(int i, int j)
        {
            return pecas[i, j];
        }


    }
}
