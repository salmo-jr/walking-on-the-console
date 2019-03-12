using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Walking
{
    class Player
    {
        public Byte Posicao { set; get; }
        public String Aparencia { set; get; }
        public String FacingRight { set; get; }
        public String FacingLeft { set; get; }
        public Boolean Pulando { set; get; }

        public Player(String right, String left)
        {
            Posicao = 0;
            FacingRight = right;
            FacingLeft = left;
            Aparencia = FacingRight;
            Pulando = false;
        }

        public void pula()
        {
            Console.Beep(234, 100);
        }

        public void anda(Boolean direcao, Byte limite)
        {
            if (direcao)
            {
                if (Posicao < limite)
                {
                    Posicao++;
                    Aparencia = FacingRight;
                }
            }
            else
            {
                if (Posicao > 0)
                {
                    Posicao--;
                    Aparencia = FacingLeft;
                }
            }
        }
    }
}
