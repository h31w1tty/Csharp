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
    public partial class frmPesquisaFornecedor : Form
    {
        private int codigo;
        public frmPesquisaFornecedor()
        {
            InitializeComponent();
        }
        public int getCodigo()
        {
            return codigo;
        }

        private void frmPesquisaFornecedor_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'banquihoDataSet.tb_fornecedor'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_fornecedorTableAdapter.Fill(this.banquihoDataSet.tb_fornecedor);

        }

        private void tb_fornecedorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tb_fornecedorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.banquihoDataSet);

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                this.tb_fornecedorTableAdapter.Fill(this.banquihoDataSet.tb_fornecedor);
            }
            else
            {
                this.tb_fornecedorTableAdapter.FillByNome(this.banquihoDataSet.tb_fornecedor, "%" + txtNome.Text + "%");
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            codigo = 0;
            Close();
        }

        private void tb_fornecedorDataGridView_DoubleClick(object sender, EventArgs e)
        {
            codigo = Convert.ToInt32(tb_fornecedorDataGridView.CurrentRow.Cells[0].Value);
            Close();
        }
    }
}
