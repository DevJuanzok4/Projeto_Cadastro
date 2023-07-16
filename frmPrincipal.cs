using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoContas
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void UsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuario fu = new frmUsuario();
            fu.ShowDialog();
        }

        private void SairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClientes fu = new frmClientes();
            fu.ShowDialog();
        }

        private void FornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFornecedores fu = new frmFornecedores();
            fu.ShowDialog();
        }

        private void ContasAPagarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmContasaPagar fu = new frmContasaPagar();
            fu.ShowDialog();
        }

        private void ContasAReceberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmContasReceber fu = new frmContasReceber();
            fu.ShowDialog();
        }

        private void CadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
