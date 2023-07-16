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
    public partial class frmPesquisaUsuario : Form
    {
        private int codigo;

        public frmPesquisaUsuario()
        {
            InitializeComponent();
        }

        public int getCodigo()
        {
            return codigo;
        }

        private void FrmPesquisaUsuario_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bDcontasDataSet.tbUsuario'. Você pode movê-la ou removê-la conforme necessário.
            this.tbUsuarioTableAdapter.Fill(this.bDcontasDataSet.tbUsuario);

        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text=="")
            {
                this.tbUsuarioTableAdapter.Fill(this.bDcontasDataSet.tbUsuario);
            }
            else
            {
                this.tbUsuarioTableAdapter.FillByNome(this.bDcontasDataSet.tbUsuario, "%" + txtNome.Text + "%");
            }       
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            codigo = 0;
            Close();
        }

        private void TbUsuarioDataGridView_DoubleClick(object sender, EventArgs e)
        {
            codigo = Convert.ToInt32(tbUsuarioDataGridView.CurrentRow.Cells[0].Value);
            Close();
        }

        private void TbUsuarioDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TxtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
