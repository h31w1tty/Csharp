using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtvddBanco
{
    public partial class frmContasPagar : Form
    {
        private void HabilitarEdicao()
        {
            cd_contaTextBox.Enabled = false;
            cd_documentoTextBox.Enabled = true;
            ds_documentoTextBox.Enabled = true;
            dt_emissaoDateTimePicker.Enabled = true;
            dt_vencimentoDateTimePicker.Enabled = true;
            vl_documentoTextBox.Enabled = true;
            dt_pagamentoDateTimePicker.Enabled = true;
            vl_pagoTextBox.Enabled = true;
            cd_fornecedorTextBox.Enabled = true;
            btnAnterior.Enabled = false;
            btnProximo.Enabled = false;
            btnNovo.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnPesquisar.Enabled = false;
            btnImprimir.Enabled = false;
            btnSair.Enabled = false;
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;
        }

        private void DesabilitarEdicao()
        {
            cd_contaTextBox.Enabled = false;
            cd_documentoTextBox.Enabled = false;
            ds_documentoTextBox.Enabled = false;
            dt_emissaoDateTimePicker.Enabled = false;
            dt_vencimentoDateTimePicker.Enabled = false;
            vl_documentoTextBox.Enabled = false;
            dt_pagamentoDateTimePicker.Enabled = false;
            vl_pagoTextBox.Enabled = false;
            cd_fornecedorTextBox.Enabled = false;
            btnAnterior.Enabled = true;
            btnProximo.Enabled = true;
            btnNovo.Enabled = true;
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
            btnPesquisar.Enabled = true;
            btnImprimir.Enabled = true;
            btnSair.Enabled = true;
            btnSalvar.Enabled = false;
            btnCancelar.Enabled = false;
        }

        public frmContasPagar()
        {
            InitializeComponent();
        }

        private void tb_contasPagarBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tb_contasPagarBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.banquihoDataSet);

        }

        private void frmContasPagar_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'banquihoDataSet.tb_contasPagar'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_contasPagarTableAdapter.Fill(this.banquihoDataSet.tb_contasPagar);
            DesabilitarEdicao();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            tb_contasPagarBindingSource.MovePrevious();
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            tb_contasPagarBindingSource.MoveNext();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            tb_contasPagarBindingSource.AddNew();
            HabilitarEdicao();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            HabilitarEdicao();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Tem certeza?", "Atenção!", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (res == DialogResult.OK)
            {
                tb_contasPagarBindingSource.RemoveCurrent();
                tb_contasPagarTableAdapter.Update(banquihoDataSet.tb_contasPagar);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Validate();
            tb_contasPagarBindingSource.EndEdit();
            tb_contasPagarTableAdapter.Update(banquihoDataSet.tb_contasPagar);
            DesabilitarEdicao();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            tb_contasPagarBindingSource.CancelEdit();
            DesabilitarEdicao();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            frmPesquisaContasPagar fpcp = new frmPesquisaContasPagar();
            fpcp.ShowDialog();
        }
    }
}
