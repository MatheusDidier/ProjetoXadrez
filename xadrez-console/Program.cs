using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xadrez_console.tabuleiro;
using xadrez_console.xadrez;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            PosicaoXadrez pos = new PosicaoXadrez('a', 1);
            Tabuleiro tab = new Tabuleiro(8, 8);
            tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(3, 5));
            tab.colocarPeca(new Torre(tab, Cor.Branca), new Posicao(1, 4));
            Tela.imprimirTabuleiro(tab);


            
            Console.ReadKey();
            
            
        }
    }
}
