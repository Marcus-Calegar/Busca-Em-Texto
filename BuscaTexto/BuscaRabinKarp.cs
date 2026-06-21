using System;
using System.Collections.Generic;

namespace BuscaTexto {
    class BuscaRabinKarp {
        const long q = 10014521L;
        const int d = 128;

        public static List<int> RKSearch(String palavra, String texto) {
            List<int> posicoes = new List<int>();
            int tamanhoPalavra = palavra.Length;
            int tamanhoTexto = texto.Length;

            if (tamanhoTexto < tamanhoPalavra || tamanhoPalavra == 0)
                return posicoes;

            long dm = 1, h1 = 0, h2 = 0;

            for (int i = 1; i < tamanhoPalavra; i++)
                dm = (d * dm) % q;

            for (int i = 0; i < tamanhoPalavra; i++) {
                h1 = (h1 * d + palavra[i]) % q;
                h2 = (h2 * d + texto[i]) % q;
            }

            for (int i = 0; i <= tamanhoTexto - tamanhoPalavra; i++) {
                if (h1 == h2) {
                    int j;
                    for (j = 0; j < tamanhoPalavra; j++) {
                        if (texto[i + j] != palavra[j]) break;
                    }
                    if (j == tamanhoPalavra) posicoes.Add(i);
                }

                if (i < tamanhoTexto - tamanhoPalavra) {
                    h2 = (h2 + d * q - texto[i] * dm) % q;
                    h2 = (h2 * d + texto[i + tamanhoPalavra]) % q;
                }
            }
            return posicoes;
        }
    }
}