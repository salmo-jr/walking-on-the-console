using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Walking
{
    class Cenario
    {
        public String Chao { set; get; }
        public Byte Tamanho { set; get; }

        public Cenario(String chao, Byte tamanho)
        {
            this.Chao = chao;
            this.Tamanho = tamanho;
        }

        public void imprime(Player p)
        {
            Console.Clear();
            Console.WriteLine();

            // IMPRIME A PRIMEIRA LINHA
            if (p.Pulando)
            {
                for (Byte i = 0; i < p.Posicao; i++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine(p.Aparencia);
            }
            else
            {
                Console.WriteLine();
            }

            // IMPRIME SEGUNDA LINHA
            for (Byte i = 0; i < p.Posicao; i++)
            {
                Console.Write(Chao);
            }

            if (p.Pulando) Console.Write(Chao);
            else Console.Write(p.Aparencia);

            for (Byte i = 0; i < (Tamanho - p.Posicao); i++)
            {
                Console.Write(Chao);
            }
        }
    }
}
