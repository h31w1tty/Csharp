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
    public partial class frmContasReceber : Form
    {
        private void HabilitarEdicao()
        {
            cd_contaTextBox.Enabled = false;
            cd_clienteTextBox.Enabled = true;
            cd_documentoTextBox.Enabled = true;
            ds_documentTextBox.Enabled = true;
            dt_emissaoDateTimePicker.Enabled = true;
            dt_vencimentoDateTimePicker.Enabled = true;
            vl_documentoTextBox.Enabled = true;
            vl_pagoTextBox.Enabled = true;
            dt_pagamentoDateTimePicker.Enabled = true;
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
            cd_clienteTextBox.Enabled = false;
            cd_documentoTextBox.Enabled = false;
            ds_documentTextBox.Enabled = false;
            dt_emissaoDateTimePicker.Enabled = false;
            dt_vencimentoDateTimePicker.Enabled = false;
            vl_documentoTextBox.Enabled = false;
            vl_pagoTextBox.Enabled = false;
            dt_pagamentoDateTimePicker.Enabled = false;
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
        public frmContasReceber()
        {
            InitializeComponent();
        }

        private void tb_contasReceberBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tb_contasReceberBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.banquihoDataSet);
            HabilitarEdicao();
        }

        private void frmContasReceber_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'banquihoDataSet.tb_contasReceber'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_contasReceberTableAdapter.Fill(this.banquihoDataSet.tb_contasReceber);
            DesabilitarEdicao();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            tb_contasReceberBindingSource.MovePrevious();
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            tb_contasReceberBindingSource.MovePrevious();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            tb_contasReceberBindingSource.AddNew();
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
                tb_contasReceberBindingSource.RemoveCurrent();
                tb_contasReceberTableAdapter.Update(banquihoDataSet.tb_contasReceber);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Validate();
            tb_contasReceberBindingSource.EndEdit();
            tb_contasReceberTableAdapter.Update(banquihoDataSet.tb_contasReceber);
            DesabilitarEdicao();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            tb_contasReceberBindingSource.CancelEdit();
            DesabilitarEdicao();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            int cod, reg;
            frmPesquisaContasReceber fpcr = new frmPesquisaContasReceber();
            fpcr.ShowDialog();
            cod = fpcr.getCodigo();
            if (cod > 0)
            {
                reg = tb_contasReceberBindingSource.Find("cd_conta", cod);
                tb_contasReceberBindingSource.Position = reg;
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string strDados;
            Graphics objImpressao = e.Graphics;

            strDados = "FICHA DE CONTA A RECEBER" + (char)10 + (char)10;
            strDados += "Código: " + cd_contaTextBox.Text + "           Código do Cliente: " + cd_clienteTextBox.Text + (char)10 + (char)10;
            strDados += "Tipo de Documento: " + ds_documentTextBox.Text + "           Número do documento: " + cd_documentoTextBox.Text + (char)10 + (char)10;
            strDados += "Data de emissão: " + dt_emissaoDateTimePicker.Text + (char)10 + "Data de pagamento: " + dt_pagamentoDateTimePicker.Text + (char)10 + "Data de vencimento: " + dt_vencimentoDateTimePicker.Text + (char)10 + (char)10;
            strDados += "Valor: " + vl_documentoTextBox.Text + (char)10;
            strDados += "Valor Pago: " + vl_pagoTextBox.Text;

            objImpressao.DrawString(strDados, new Font("Arial", 14, FontStyle.Bold), Brushes.Black, 50, 50);
            objImpressao.DrawLine(new Pen(Brushes.Black), 50, 80, 700, 80);
        }
    }
}
