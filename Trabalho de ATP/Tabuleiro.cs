using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_de_ATP
{
    internal class Tabuleiro
    {
        Jogador[] jogadores;
        int[] casasSeguras = {0,8,13,21,26,34,39,47,52,53,54,55,56,57 };

        public Tabuleiro(int quantidadeJogadores)
        {
            string[] cor = { "Amarelo", "Vermelho", "Azul", "Verde" };
            Jogador[] jogadores = new Jogador[quantidadeJogadores];
            for (int i =0; i< quantidadeJogadores; i++)
            {
                jogadores[i] = new Jogador(cor[i]);
            }
            
        }
 

    }
}
