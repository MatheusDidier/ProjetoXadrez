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

            Console.WriteLine(pos.toPosicao());

            Console.WriteLine("A - B = " + ('a' - 'b'));
            Console.WriteLine("A - C = " + ('c' - 'a'));
            Console.ReadKey();
            
            
        }
    }
}
