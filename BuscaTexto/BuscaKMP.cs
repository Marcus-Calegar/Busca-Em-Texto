using System;
using System.Collections.Generic;

namespace BuscaTexto {
    class BuscaKMP {
        static int[] next = new int[1000];

        public static void InitNext(String palavra) {
            int i = 0, j = -1, m = palavra.Length;
            next[0] = -1;
            while (i < m) {
                while (j >= 0 && palavra[i] != palavra[j])
                    j = next[j];
                i++;
                j++;
                next[i] = j;
            }
        }

        public static List<int> KMPSearch(String palavra, String texto) {
            List<int> posicoes = new List<int>();
            int i = 0, j = 0, m = palavra.Length, n = texto.Length;
            if (m == 0 || n < m) return posicoes;

            InitNext(palavra);

            while (i < n) {
                while (j >= 0 && texto[i] != palavra[j]) {
                    j = next[j];
                }
                i++;
                j++;
                if (j == m) {
                    posicoes.Add(i - m);
                    j = next[j];
                }
            }
            return posicoes;
        }
    }
}