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
    public partial class frmPesquisarContasReceber : Form
    {
        private int codigo;

        public frmPesquisarContasReceber()
        {
            InitializeComponent();
        }

        public int getCodigo()
        {
            return codigo;
        }
        private void TbContasReceberBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbContasReceberBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDcontasDataSet);

        }

        private void FrmPesquisarContasReceber_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bDcontasDataSet.tbContasReceber'. Você pode movê-la ou removê-la conforme necessário.
            this.tbContasReceberTableAdapter.Fill(this.bDcontasDataSet.tbContasReceber);

        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                this.tbContasReceberTableAdapter.Fill(this.bDcontasDataSet.tbContasReceber);
            }
            else
            {
                this.tbContasReceberTableAdapter.FillByData(this.bDcontasDataSet.tbContasReceber, "%" + txtNome.Text + "%");
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            codigo = 0;
            Close();
        }

        private void TbContasReceberDataGridView_DoubleClick(object sender, EventArgs e)
        {
            codigo = Convert.ToInt32(tbContasReceberDataGridView.CurrentRow.Cells[0].Value);
            Close();
        }
    }
}
