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
    public partial class frmPesquisaCliente : Form
    {
        private int codigo;
        public frmPesquisaCliente()
        {
            InitializeComponent();
        }
        public int getCodigo()
        {
            return codigo;
        }

        private void tb_clienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tb_clienteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.banquihoDataSet);

        }

        private void frmPesquisaCliente_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'banquihoDataSet.tb_cliente'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_clienteTableAdapter.Fill(this.banquihoDataSet.tb_cliente);

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                this.tb_clienteTableAdapter.Fill(this.banquihoDataSet.tb_cliente);
            }
            else
            {
                this.tb_clienteTableAdapter.FillByNome(this.banquihoDataSet.tb_cliente, "%" + txtNome.Text + "%");
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            codigo = 0;
            Close();
        }

        private void tb_clienteDataGridView_DoubleClick(object sender, EventArgs e)
        {
            codigo = Convert.ToInt32(tb_clienteDataGridView.CurrentRow.Cells[0].Value);
            Close();
        }

        private void tb_clienteDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
