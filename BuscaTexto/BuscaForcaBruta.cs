using System;
using System.Collections.Generic;

namespace BuscaTexto {
    class BuscaForcaBruta {
        public static List<int> ForcaBruta(String palavra, String texto) {
            List<int> posicoes = new List<int>();
            int i, j, aux;
            int tamanhoPalavra = palavra.Length;
            int tamanhoTexto = texto.Length;

            for (i = 0; i <= tamanhoTexto - tamanhoPalavra; i++) {
                aux = i;
                for (j = 0; j < tamanhoPalavra && aux < tamanhoTexto; j++) {
                    if (palavra[j] != '?' && texto[aux] != palavra[j])
                        break;
                    aux++;
                }
                if (j == tamanhoPalavra)
                    posicoes.Add(i);
            }
            return posicoes;
        }
    }
}