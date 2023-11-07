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
        public frmPesquisaContasPagar()
        {
            InitializeComponent();
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
    }
}
