using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xadrez_console.tabuleiro;

namespace xadrez_console.xadrez
{
    class PosicaoXadrez
    {
        public char Coluna { get; set; }
        public int Linha { get; set; }

        public PosicaoXadrez(char Coluna, int Linha)
        {
            this.Coluna = Coluna;
            this.Linha = Linha;
        }

        public override string ToString()
        {
            return "" + this.Coluna + this.Linha;
        }

        public Posicao toPosicao()
        {
            return new Posicao(8 - this.Linha, this.Coluna - 'a');
        }
    }
}
