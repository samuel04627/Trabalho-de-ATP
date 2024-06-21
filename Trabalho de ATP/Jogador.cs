using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_de_ATP
{
    internal class Jogador
    {
        public string cor;
        public Peao[] peoes;

        public Jogador(string cor)
        {
            Peao[] peoes = new Peao[4];
            for( int i = 0; i < 4; i++)
            {
                peoes[i] = new Peao(cor);
            }
            this.peoes = peoes;
            this.cor = cor;
        }
    }
}
