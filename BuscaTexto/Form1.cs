using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace BuscaTexto {
    public partial class Form1 : Form {
        private FormPesquisa formPesquisa;
        private int ocorrenciaAtual { get; set; }
        private int totalOcorrencias { get; set; }
        private List<int> posicoes { get; set; }
        private string padrao { get; set; }
        public Form1() {
            InitializeComponent();
            this.ocorrenciaAtual = -1;
            this.totalOcorrencias = 0;
            this.padrao = string.Empty;
        }

        public void ColorirTexto(List<int> posicoes, int comprimento, int atual) {
            if (posicoes == null || posicoes.Count == 0) return;
            if (atual < 0 || atual >= posicoes.Count) atual = 0;
            foreach (int pos in posicoes) {
                texto.Select(pos, comprimento);
                texto.SelectionBackColor = System.Drawing.Color.Yellow;
            }
            // Realçar ocorrência atual
            texto.Select(posicoes[atual], comprimento);
            texto.SelectionBackColor = System.Drawing.Color.Blue;
            texto.DeselectAll();
        }
        public void ColorirTexto(List<int> posicoes, int comprimento) {
            foreach (int pos in posicoes) {
                texto.Select(pos, comprimento);
                texto.SelectionBackColor = System.Drawing.Color.Yellow;
                texto.DeselectAll();
            }
        }
        public void LimparColoracao() {
            texto.SelectAll();
            texto.SelectionBackColor = System.Drawing.Color.White;
            texto.DeselectAll();
        }

        public void SubstituirTexto(List<int> posicoes, int comprimento, string substituto) {
            foreach (int pos in posicoes) {
                texto.Select(pos, comprimento);
                texto.SelectedText = substituto;
            }
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e) {
            texto.Text = "";
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e) {
            MessageBox.Show(this,
               "Busca em Texto - 2026/1\n\nDesenvolvido por:\n72500549 - Marcus Vinícius Calegar\n72500581 - Yuri Stiwart Faria Filho\nProf. Virgílio Borges de Oliveira\n\nAlgoritmos e Estruturas de Dados II\nFaculdade COTEMIG\nSomente para fins didáticos.",
               "Sobre o trabalho...",
               MessageBoxButtons.OK,
               MessageBoxIcon.Information);
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e) {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.RestoreDirectory = true;
            openFileDialog.Filter = "Arquivos de Texto e RTF|*.txt;*.rtf|Arquivos de Texto (*.txt)|*.txt|Rich Text Format (*.rtf)|*.rtf";

            if (openFileDialog.ShowDialog() == DialogResult.OK) {
                string selectedFilePath = openFileDialog.FileName;
                texto.Text = File.ReadAllText(selectedFilePath);
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void forçaBrutaToolStripMenuItem_Click(object sender, EventArgs e) {
            Pesquisa(Metodo.ForcaBruta);
        }

        private FormPesquisa dialogPesquisa() {
            formPesquisa = new FormPesquisa();
            formPesquisa.ShowDialog();
            return formPesquisa;
        }

        private void Pesquisa(Metodo metodo) {
            LimparColoracao();
            FormPesquisa form = dialogPesquisa();
            if (form.DialogResult != DialogResult.OK) {
                return;
            }
            if (form == null) {
                MessageBox.Show("Preencher a caixa de padrao e obrigatorio!");
                return;
            }
            this.posicoes = new List<int>();

            this.padrao = form.Padrao;
            string conteudo = this.texto.Text;

            if (!form.isCaseSensitive) {
                this.padrao = this.padrao.ToLower();
                conteudo = conteudo.ToLower();
            }

            switch (metodo) {
                case Metodo.BoyerMoore:
                    this.posicoes = BuscaBoyerMoore.BMSearch(this.padrao, conteudo);
                    break;
                case Metodo.ForcaBruta:
                    this.posicoes = BuscaForcaBruta.ForcaBruta(this.padrao, conteudo);
                    break;
                case Metodo.KMP:
                    this.posicoes = BuscaKMP.KMPSearch(this.padrao, conteudo);
                    break;
                case Metodo.RabinKarp:
                    this.posicoes = BuscaRabinKarp.RKSearch(this.padrao, conteudo);
                    break;
            }

            this.totalOcorrencias = this.posicoes.Count;

            if(this.totalOcorrencias == 0) {
                lblOcorrencia.Visible = false;
                MessageBox.Show("Nenhuma ocorrencia encontrada!");
                return;
            }
            lblOcorrencia.Visible = true;
            lblOcorrencia.Text = $"Ocorrencia 0 de {totalOcorrencias}";

            this.ocorrenciaAtual = 0;
            ColorirTexto(this.posicoes, this.padrao.Length, this.ocorrenciaAtual);
            texto.Select(this.posicoes[this.ocorrenciaAtual], this.padrao.Length);
            texto.ScrollToCaret();
            texto.Focus();

            if(form.isSubistituir) {
                SubstituirTexto(this.posicoes, this.padrao.Length, form.Subistituir);
            }
        }

        private void rabinKarpToolStripMenuItem_Click(object sender, EventArgs e) {
            Pesquisa(Metodo.RabinKarp);
        }

        private void kMPToolStripMenuItem_Click(object sender, EventArgs e) {
            Pesquisa(Metodo.KMP);
        }

        private void boyerMooreToolStripMenuItem_Click(object sender, EventArgs e) {
            Pesquisa(Metodo.BoyerMoore);
        }

        private void btnProx_Click(object sender, EventArgs e) {
            if (this.totalOcorrencias == 0) {
                return;
            }
            this.ocorrenciaAtual = (this.ocorrenciaAtual + 1) % this.totalOcorrencias;
            lblOcorrencia.Text = $"Ocorrencia {ocorrenciaAtual+1} de {totalOcorrencias}";

            this.ColorirTexto(this.posicoes, this.padrao.Length, this.ocorrenciaAtual);
            texto.Select(this.posicoes[this.ocorrenciaAtual], this.padrao.Length);
            texto.ScrollToCaret();
            texto.Focus();
        }

        private void btnAnt_Click(object sender, EventArgs e) {
            if (this.totalOcorrencias == 0) {
                return;
            }
            this.ocorrenciaAtual = (this.ocorrenciaAtual - 1 + this.totalOcorrencias) % this.totalOcorrencias;
            lblOcorrencia.Text = $"Ocorrencia {ocorrenciaAtual + 1} de {totalOcorrencias}";

            this.ColorirTexto(this.posicoes, this.padrao.Length, this.ocorrenciaAtual);
            texto.Select(this.posicoes[this.ocorrenciaAtual], this.padrao.Length);
            texto.ScrollToCaret();
            texto.Focus();
        }
    }
}
