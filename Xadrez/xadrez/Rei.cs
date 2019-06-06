﻿using Tabuleiro;

namespace xadrez
{
    class Rei : Peca
    {
        public Rei(Board tab, Cor cor) : base(tab, cor) {

        }

        public override string ToString()
        {
            return "R";
        }
    }
}
