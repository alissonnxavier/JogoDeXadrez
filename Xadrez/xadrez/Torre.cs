﻿using Tabuleiro;

namespace xadrez
{
    class Torre : Peca
    {
        public Torre(Board tab, Cor cor) : base(tab, cor) {

        }

        public override string ToString()
        {
            return "T";
        }
    }
}
