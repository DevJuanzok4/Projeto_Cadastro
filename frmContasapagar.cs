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
    public partial class frmContasaPagar : Form
    {

        private void HabilitaEdicao()
        {
            cd_contaTextBox.Enabled = false;
            dt_emissaoDateTimePicker.Enabled = true;
            cd_fornecedorTextBox.Enabled = true;
            vl_contaTextBox.Enabled = true;
            dt_vencimentoDateTimePicker.Enabled = true;
            dt_pagamentoDateTimePicker.Enabled = true;
            vl_pagoTextBox.Enabled = true;
            btnAnterior.Enabled = false;
            btnProximo.Enabled = false;
            btnNovo.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;
            btnPesquisar.Enabled = false;
            btnImprimir.Enabled = false;
            btnSair.Enabled = false;

        }

        private void DesabilitaEdicao()
        {
            cd_contaTextBox.Enabled = false;
            dt_emissaoDateTimePicker.Enabled = false;
            cd_fornecedorTextBox.Enabled = false;
            vl_contaTextBox.Enabled = false;
            dt_vencimentoDateTimePicker.Enabled = false;
            dt_pagamentoDateTimePicker.Enabled = false;
            vl_pagoTextBox.Enabled = false;
            btnAnterior.Enabled = true;
            btnProximo.Enabled = true;
            btnNovo.Enabled = true;
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
            btnSalvar.Enabled = false;
            btnCancelar.Enabled = false;
            btnPesquisar.Enabled = true;
            btnImprimir.Enabled = true;
            btnSair.Enabled = true;

        }

        public frmContasaPagar()
        {
            InitializeComponent();
        }




        private void TbcontaspagarBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbcontaspagarBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDcontasDataSet);

        }

        private void FrmContasaPagar_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bDcontasDataSet.Table'. Você pode movê-la ou removê-la conforme necessário.
            this.tableTableAdapter.Fill(this.bDcontasDataSet.Table);
            // TODO: esta linha de código carrega dados na tabela 'bDcontasDataSet.tbCliente'. Você pode movê-la ou removê-la conforme necessário.
            this.tbClienteTableAdapter.Fill(this.bDcontasDataSet.tbCliente);
            // TODO: esta linha de código carrega dados na tabela 'bDcontasDataSet.tbcontaspagar'. Você pode movê-la ou removê-la conforme necessário.
            this.tbcontaspagarTableAdapter.Fill(this.bDcontasDataSet.tbcontaspagar);
            DesabilitaEdicao();
        }

        private void BtnAnterior_Click(object sender, EventArgs e)
        {
            tbcontaspagarBindingSource.MovePrevious();
        }

        private void BtnProximo_Click(object sender, EventArgs e)
        {
            tbcontaspagarBindingSource.MoveNext();
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            HabilitaEdicao();
            tbcontaspagarBindingSource.AddNew();
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            HabilitaEdicao();
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            tbcontaspagarBindingSource.RemoveCurrent();
            tbcontaspagarTableAdapter.Update(bDcontasDataSet.tbcontaspagar);
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            DesabilitaEdicao();
            Validate();
            tbcontaspagarBindingSource.EndEdit();
            tbcontaspagarTableAdapter.Update(bDcontasDataSet.tbcontaspagar);
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            DesabilitaEdicao();
            tbcontaspagarBindingSource.CancelEdit();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Cd_contaLabel_Click(object sender, EventArgs e)
        {

        }

        private void Cd_contaTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            int cod, reg;
            frmPesquisarContasapagar fpu = new frmPesquisarContasapagar();
            fpu.ShowDialog();
            cod = fpu.getCodigo();
            if (cod > 0)
            {
                reg = tbcontaspagarBindingSource.Find("cd_conta", cod);
                tbcontaspagarBindingSource.Position = reg;
            }
        }
    }
}
