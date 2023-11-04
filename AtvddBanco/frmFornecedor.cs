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
    public partial class frmFornecedor : Form
    {
        private void ValidarCnpj()
        {
            double dig1 = 0, dig2 = 0;
            dig1 += double.Parse(cd_cnpjMaskedTextBox.Text.Substring(14, 1)) * 2;
            dig1 += double.Parse(cd_cnpjMaskedTextBox.Text.Substring(13, 1)) * 3;
            dig1 += double.Parse(cd_cnpjMaskedTextBox.Text.Substring(12, 1)) * 4;
            dig1 += double.Parse(cd_cnpjMaskedTextBox.Text.Substring(11, 1)) * 5;
            dig1 += double.Parse(cd_cnpjMaskedTextBox.Text.Substring(9, 1)) * 6;
            dig1 += double.Parse(cd_cnpjMaskedTextBox.Text.Substring(8, 1)) * 7;
            dig1 += double.Parse(cd_cnpjMaskedTextBox.Text.Substring(7, 1)) * 8;
            dig1 += double.Parse(cd_cnpjMaskedTextBox.Text.Substring(5, 1)) * 9;
            dig1 += double.Parse(cd_cnpjMaskedTextBox.Text.Substring(4, 1)) * 2;
            dig1 += double.Parse(cd_cnpjMaskedTextBox.Text.Substring(3, 1)) * 3;
            dig1 += double.Parse(cd_cnpjMaskedTextBox.Text.Substring(1, 1)) * 4;
            dig1 += double.Parse(cd_cnpjMaskedTextBox.Text.Substring(0, 1)) * 5;
            dig1 = dig1 % 11;
            dig1 = 11 - dig1;
            dig2 += double.Parse(cd_cnpjMaskedTextBox.Text.Substring(16, 1)) * 2;
            dig2 += double.Parse(cd_cnpjMaskedTextBox.Text.Substring(14, 1)) * 3;
            dig2 += double.Parse(cd_cnpjMaskedTextBox.Text.Substring(13, 1)) * 4;
            dig2 += double.Parse(cd_cnpjMaskedTextBox.Text.Substring(12, 1)) * 5;
            dig2 += double.Parse(cd_cnpjMaskedTextBox.Text.Substring(11, 1)) * 6;
            dig2 += double.Parse(cd_cnpjMaskedTextBox.Text.Substring(9, 1)) * 7;
            dig2 += double.Parse(cd_cnpjMaskedTextBox.Text.Substring(8, 1)) * 8;
            dig2 += double.Parse(cd_cnpjMaskedTextBox.Text.Substring(7, 1)) * 9;
            dig2 += double.Parse(cd_cnpjMaskedTextBox.Text.Substring(5, 1)) * 2;
            dig2 += double.Parse(cd_cnpjMaskedTextBox.Text.Substring(4, 1)) * 3;
            dig2 += double.Parse(cd_cnpjMaskedTextBox.Text.Substring(3, 1)) * 4;
            dig2 += double.Parse(cd_cnpjMaskedTextBox.Text.Substring(1, 1)) * 5;
            dig2 += double.Parse(cd_cnpjMaskedTextBox.Text.Substring(0, 1)) * 6;
            dig2 = dig2 % 11;
            dig2 = 11 - dig2;
            if (cd_cnpjMaskedTextBox.Text.Substring(16, 1) != dig1.ToString() || cd_cnpjMaskedTextBox.Text.Substring(17, 1) != dig2.ToString())
            {
                cnpjicon.ForeColor = Color.Red;
                cnpjicon.Text = "Inválido!";
            }
            else
            {
                cnpjicon.ForeColor = Color.Green;
                cnpjicon.Text = "Válido!";
            }
        }
        private void CnpjBranco()
        {
            if(cd_cnpjMaskedTextBox.Text.Contains(" "))
            {
                cnpjicon.ForeColor = Color.Red;
                cnpjicon.Text = "Inválido!";
            }
            else
            {
                ValidarCnpj();
            }
        }
        private void HabilitaEdicao()
        {
            cd_fornecedorTextBox.Enabled = false;
            nm_fornecedorTextBox.Enabled = true;
            ds_enderecoTextBox.Enabled = true;
            cd_numeroTextBox.Enabled = true;
            nm_bairroTextBox.Enabled = true;
            nm_cidadeTextBox.Enabled = true;
            sg_estadoComboBox.Enabled = true;
            cd_cepMaskedTextBox.Enabled = true;
            cd_cnpjMaskedTextBox.Enabled = true;
            cd_ieMaskedTextBox.Enabled = true;
            cd_telefoneMaskedTextBox.Enabled = true;
            ds_emailTextBox.Enabled = true;
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

        private void DesabilitaEdicao()
        {
            cd_fornecedorTextBox.Enabled = false;
            nm_fornecedorTextBox.Enabled = false;
            ds_enderecoTextBox.Enabled = false;
            cd_numeroTextBox.Enabled = false;
            nm_bairroTextBox.Enabled = false;
            nm_cidadeTextBox.Enabled = false;
            sg_estadoComboBox.Enabled = false;
            cd_cepMaskedTextBox.Enabled = false;
            cd_cnpjMaskedTextBox.Enabled = false;
            cd_ieMaskedTextBox.Enabled = false;
            cd_telefoneMaskedTextBox.Enabled = false;
            ds_emailTextBox.Enabled = false;
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
            cnpjicon.ForeColor = Control.DefaultBackColor;
        }
        public frmFornecedor()
        {
            InitializeComponent();
        }

        private void frmFornecedor_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'banquihoDataSet.tb_fornecedor'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_fornecedorTableAdapter.Fill(this.banquihoDataSet.tb_fornecedor);
            DesabilitaEdicao();

        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            tb_fornecedorBindingSource.MovePrevious();
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            tb_fornecedorBindingSource.MoveNext();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            tb_fornecedorBindingSource.AddNew();
            HabilitaEdicao();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            HabilitaEdicao();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            //adicionar pergunta para confirmar exclusao
            var res = MessageBox.Show("Tem certeza?", "Atenção!", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if(res == DialogResult.OK)
            {
                tb_fornecedorBindingSource.RemoveCurrent();//quando sem registros erro ao excluir
                tb_fornecedorTableAdapter.Update(banquihoDataSet.tb_fornecedor);
            }
            
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if(cnpjicon.ForeColor != Color.Red)
            {
                Validate();
                tb_fornecedorBindingSource.EndEdit();
                tb_fornecedorTableAdapter.Update(banquihoDataSet.tb_fornecedor);
                DesabilitaEdicao();
            }
            else
            {
                MessageBox.Show("CNPJ inválido!!");
                cd_cnpjMaskedTextBox.Focus();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            tb_fornecedorBindingSource.CancelEdit();
            DesabilitaEdicao();

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cd_cnpjMaskedTextBox_Leave(object sender, EventArgs e)
        {
            CnpjBranco();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            int cod, reg;
            frmPesquisaFornecedor fpf = new frmPesquisaFornecedor();
            fpf.ShowDialog();
            cod = fpf.getCodigo();
            if (cod > 0)
            {
                reg = tb_fornecedorBindingSource.Find("cd_fornecedor", cod);
                tb_fornecedorBindingSource.Position = reg;
            }
        }
    }
}
