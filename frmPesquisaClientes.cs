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
    public partial class frmPesquisaClientes : Form
    {
        private int codigo;

        public frmPesquisaClientes()
        {
            InitializeComponent();
        }

        public int getCodigo()
        {
            return codigo;
        }



        private void TbUsuarioDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            codigo = 0;
            Close();
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                this.tbClienteTableAdapter.Fill(this.bDcontasDataSet.tbCliente);
            }
            else
            {
                this.tbClienteTableAdapter.FillByNome(this.bDcontasDataSet.tbCliente, "%" + txtNome.Text + "%");
            }
        }

        private void TxtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TbClienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbClienteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDcontasDataSet);

        }

        private void FrmPesquisaClientes_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bDcontasDataSet.tbCliente'. Você pode movê-la ou removê-la conforme necessário.
            this.tbClienteTableAdapter.Fill(this.bDcontasDataSet.tbCliente);

        }

        private void TbClienteDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TbClienteDataGridView_DoubleClick(object sender, EventArgs e)
        {
            codigo = Convert.ToInt32(tbClienteDataGridView.CurrentRow.Cells[0].Value);
            Close();
        }
    }
}
