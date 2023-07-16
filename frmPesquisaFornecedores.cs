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
    public partial class frmPesquisaFornecedores : Form
    {
        private int codigo;

        public frmPesquisaFornecedores()
        {
            InitializeComponent();
        }

        public int getCodigo()
        {
            return codigo;
        }

        private void TbFornecedorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbFornecedorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDcontasDataSet);

        }

        private void FrmPesquisaFornecedores_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bDcontasDataSet.tbFornecedor'. Você pode movê-la ou removê-la conforme necessário.
            this.tbFornecedorTableAdapter.Fill(this.bDcontasDataSet.tbFornecedor);

        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                this.tbFornecedorTableAdapter.Fill(this.bDcontasDataSet.tbFornecedor);
            }
            else
            {
                this.tbFornecedorTableAdapter.FillByNome(this.bDcontasDataSet.tbFornecedor, "%" + txtNome.Text + "%");
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            codigo = 0;
            Close();
        }

        private void TbFornecedorDataGridView_DoubleClick(object sender, EventArgs e)
        {
            codigo = Convert.ToInt32(tbFornecedorDataGridView.CurrentRow.Cells[0].Value);
            Close();
        }
    }
}
