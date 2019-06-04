

namespace Tabuleiro
{
    class Peca
    {
        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; }
        public int qtsMovimentos { get; protected set; }
        public Board tab { get; protected set; }

        public Peca(Posicao posicao, Board tab, Cor cor) {
            this.posicao = posicao;
            this.tab = tab;
            this.cor = cor;
            this.qtsMovimentos = 0;
        }
    }
}
