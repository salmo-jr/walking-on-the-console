using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Walking
{
    class Program
    {
        const byte limite = 60;
        const string chao = "_";

        static void Main(string[] args)
        {
            Player p = new Player("p", "q");
            ConsoleKey tecla;

            imprime(p);

            do {
                tecla = Console.ReadKey().Key;

                switch (tecla)
                {
                    case ConsoleKey.LeftArrow:
                        // ANDA PARA ESQUERDA
                        p.anda(false, limite);
                        imprime(p);
                        break;
                    case ConsoleKey.RightArrow:
                        // ANDA PARA DIREITA
                        p.anda(true, limite);
                        imprime(p);
                        break;
                    case ConsoleKey.UpArrow:
                        // PULA
                        p.Pulando = true;
                        imprime(p);
                        p.pula();
                        p.Pulando = false;
                        imprime(p);
                        break;
                    default:
                        imprime(p);
                        break;
                }
            } while (tecla != ConsoleKey.Escape);
        }

        static void imprime(Player p)
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
                Console.Write(chao);
            }

            if (p.Pulando) Console.Write(chao);
            else Console.Write(p.Aparencia);

            for (Byte i = 0; i < (limite - p.Posicao); i++)
            {
                Console.Write(chao);
            }
        }
    }
}
