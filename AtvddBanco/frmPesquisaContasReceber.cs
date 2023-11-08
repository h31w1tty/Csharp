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
    public partial class frmPesquisaContasReceber : Form
    {
        private int codigo;
        public frmPesquisaContasReceber()
        {
            InitializeComponent();
        }

        public int getCodigo()
        {
            return codigo;
        }

        private void frmPesquisaContasReceber_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'banquihoDataSet.tb_contasReceber'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_contasReceberTableAdapter.Fill(this.banquihoDataSet.tb_contasReceber);

        }

        private void tb_contasReceberBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            codigo = 0;
            Close();
        }

        private void tb_contasReceberDataGridView_DoubleClick(object sender, EventArgs e)
        {
            codigo = Convert.ToInt32(tb_contasReceberDataGridView.CurrentRow.Cells[0].Value);
            Close();
        }

        private void cd_data_ValueChanged(object sender, EventArgs e)
        {
            if (cd_data.Text == "")
            {
                this.tb_contasReceberTableAdapter.Fill(this.banquihoDataSet.tb_contasReceber);
            }
            else
            {
                this.tb_contasReceberTableAdapter.FillByData(this.banquihoDataSet.tb_contasReceber, cd_data.Text);
            }
        }
    }
}
