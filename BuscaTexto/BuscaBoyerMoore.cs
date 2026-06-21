using System;
using System.Collections.Generic;

namespace BuscaTexto {
    class BuscaBoyerMoore {
        static int[] skip = new int[256];
        public static void InitSkip(String p) {
            int j, m = p.Length;
            for (j = 0; j < 256; j++)
                skip[j] = m;
            for (j = 0; j < m; j++)
                skip[p[j]] = m - j - 1;
        }

        public static List<int> BMSearch(String palavra, String texto) {
            List<int> posicoes = new List<int>();
            int tamanhoPalavra = palavra.Length, tamanhoTexto = texto.Length;

            if (tamanhoPalavra == 0 || tamanhoTexto < tamanhoPalavra)
                return posicoes;

            InitSkip(palavra);

            int i = tamanhoPalavra - 1, j = tamanhoPalavra - 1;
            while (i < tamanhoTexto) {
                int k = i;
                j = tamanhoPalavra - 1;
                while (j >= 0 && k >= 0 && texto[k] == palavra[j]) {
                    k--;
                    j--;
                }
                if (j < 0) {
                    posicoes.Add(k + 1);
                    i += tamanhoPalavra;
                } else {
                    int a = skip[texto[i]];
                    i += (tamanhoPalavra - j > a) ? (tamanhoPalavra - j) : a;
                }
            }
            return posicoes;
        }
    }
}