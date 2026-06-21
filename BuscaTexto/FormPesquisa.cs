using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuscaTexto {
    public partial class FormPesquisa : Form {
        public string Padrao { get { return txtPadrao.Text; } }
        public string Subistituir { get { return txtSubistituir.Text; } }
        public bool isCaseSensitive { get { return chkCaseSensitive.Checked; } }
        public bool isSubistituir { get { return chkSubistituir.Checked; } }
        public FormPesquisa() {
            InitializeComponent();
            chkCaseSensitive.Checked = false;
            chkSubistituir.Checked = false;
            lblSubistituir.Visible = false;
            txtSubistituir.Visible = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnPesquisar_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void chkSubistituir_CheckedChanged(object sender, EventArgs e) {
            if (chkSubistituir.Checked) {
                lblSubistituir.Visible = true;
                txtSubistituir.Visible = true;
            } else {
                lblSubistituir.Visible = false;
                txtSubistituir.Visible = false;
            }
        }

        private void chkCaseSensitive_CheckedChanged(object sender, EventArgs e) {}

        private void FormPesquisa_Load(object sender, EventArgs e) {

        }
    }
}
