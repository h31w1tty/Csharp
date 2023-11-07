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
    public partial class frmPesquisaContasPagar : Form
    {
        private int codigo;
        public frmPesquisaContasPagar()
        {
            InitializeComponent();
        }
       
        public int getCodigo()
        {
            return codigo;
        }

        private void tb_contasPagarBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tb_contasPagarBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.banquihoDataSet);

        }

        private void frmPesquisaContasPagar_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'banquihoDataSet.tb_contasPagar'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_contasPagarTableAdapter.Fill(this.banquihoDataSet.tb_contasPagar);

        }

        private void dt_pagamentoDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (cd_data.Text == "")
            {
                this.tb_contasPagarTableAdapter.Fill(this.banquihoDataSet.tb_contasPagar);
            }
            else
            {
                this.tb_contasPagarTableAdapter.FillByData(this.banquihoDataSet.tb_contasPagar, cd_data.Text);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            codigo = 0;
            Close();
        }

        private void tb_contasPagarDataGridView_DoubleClick(object sender, EventArgs e)
        {
            codigo = Convert.ToInt32(tb_contasPagarDataGridView.CurrentRow.Cells[0].Value);
            Close();
        }
    }
}
