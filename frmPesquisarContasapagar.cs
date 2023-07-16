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
    public partial class frmPesquisarContasapagar : Form
    {
        private int codigo;
        public frmPesquisarContasapagar()
        {
            InitializeComponent();
        }

        public int getCodigo()
        {
            return codigo;
        }


        private void TbcontaspagarBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbcontaspagarBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDcontasDataSet);

        }

        private void FrmPesquisarContasapagar_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bDcontasDataSet.tbcontaspagar'. Você pode movê-la ou removê-la conforme necessário.
            this.tbcontaspagarTableAdapter.Fill(this.bDcontasDataSet.tbcontaspagar);

        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                this.tbcontaspagarTableAdapter.Fill(this.bDcontasDataSet.tbcontaspagar);
            }
            else
            {
                this.tbcontaspagarTableAdapter.FillByData(this.bDcontasDataSet.tbcontaspagar, "%" + txtNome.Text + "%");
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            codigo = 0;
            Close();
        }

        private void TbcontaspagarDataGridView_DoubleClick(object sender, EventArgs e)
        {
            codigo = Convert.ToInt32(tbcontaspagarDataGridView.CurrentRow.Cells[0].Value);
            Close();
        }

        private void TbcontaspagarDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
