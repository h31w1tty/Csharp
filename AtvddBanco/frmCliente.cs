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
    public partial class frmCliente : Form
    {
        private void CalcularCpf()
        {
            bool res = false;
            int dig1 = 0, dig2 = 0;
            dig1 += int.Parse(cd_cpfMaskedTextBox.Text.Substring(10, 1)) * 2;
            dig1 += int.Parse(cd_cpfMaskedTextBox.Text.Substring(9, 1)) * 3;
            dig1 += int.Parse(cd_cpfMaskedTextBox.Text.Substring(8, 1)) * 4;
            dig1 += int.Parse(cd_cpfMaskedTextBox.Text.Substring(6, 1)) * 5;
            dig1 += int.Parse(cd_cpfMaskedTextBox.Text.Substring(5, 1)) * 6;
            dig1 += int.Parse(cd_cpfMaskedTextBox.Text.Substring(4, 1)) * 7;
            dig1 += int.Parse(cd_cpfMaskedTextBox.Text.Substring(2, 1)) * 8;
            dig1 += int.Parse(cd_cpfMaskedTextBox.Text.Substring(1, 1)) * 9;
            dig1 += int.Parse(cd_cpfMaskedTextBox.Text.Substring(0, 1)) * 10;
            dig1 = dig1 % 11;
            if (dig1 < 2) { dig1 = 0; } else { dig1 = 11 - dig1; }
            dig2 += int.Parse(cd_cpfMaskedTextBox.Text.Substring(12, 1)) * 2;
            dig2 += int.Parse(cd_cpfMaskedTextBox.Text.Substring(10, 1)) * 3;
            dig2 += int.Parse(cd_cpfMaskedTextBox.Text.Substring(9, 1)) * 4;
            dig2 += int.Parse(cd_cpfMaskedTextBox.Text.Substring(8, 1)) * 5;
            dig2 += int.Parse(cd_cpfMaskedTextBox.Text.Substring(6, 1)) * 6;
            dig2 += int.Parse(cd_cpfMaskedTextBox.Text.Substring(5, 1)) * 7;
            dig2 += int.Parse(cd_cpfMaskedTextBox.Text.Substring(4, 1)) * 8;
            dig2 += int.Parse(cd_cpfMaskedTextBox.Text.Substring(2, 1)) * 9;
            dig2 += int.Parse(cd_cpfMaskedTextBox.Text.Substring(1, 1)) * 10;
            dig2 += int.Parse(cd_cpfMaskedTextBox.Text.Substring(0, 1)) * 11;
            dig2 = dig2 % 11;
            if (dig2 < 2) { dig2 = 0; } else { dig2 = 11 - dig2; }
            if (int.Parse(cd_cpfMaskedTextBox.Text.Substring(12, 1)) == dig1 && int.Parse(cd_cpfMaskedTextBox.Text.Substring(13, 1)) == dig2)
            {
                res = true;
            }

            if (!res)
            {
                cpficon.Text = "Inválido!";
                cpficon.ForeColor = Color.Red;
            }
            else
            {
                cpficon.Text = "Válido!";
                cpficon.ForeColor = Color.Green;
            }
        }
        public void CalcularRg()
        {
            int dig1 = 0;
            bool res = false;
            dig1 += int.Parse(cd_rgMaskedTextBox.Text.Substring(0, 1)) * 2;
            dig1 += int.Parse(cd_rgMaskedTextBox.Text.Substring(1, 1)) * 3;
            dig1 += int.Parse(cd_rgMaskedTextBox.Text.Substring(3, 1)) * 4;
            dig1 += int.Parse(cd_rgMaskedTextBox.Text.Substring(4, 1)) * 5;
            dig1 += int.Parse(cd_rgMaskedTextBox.Text.Substring(5, 1)) * 6;
            dig1 += int.Parse(cd_rgMaskedTextBox.Text.Substring(7, 1)) * 7;
            dig1 += int.Parse(cd_rgMaskedTextBox.Text.Substring(8, 1)) * 8;
            dig1 += int.Parse(cd_rgMaskedTextBox.Text.Substring(9, 1)) * 9;
            dig1 = dig1 % 11;
            dig1 = 11 - dig1;
            if (dig1 == 11 && cd_rgMaskedTextBox.Text.Substring(11, 1) == "0") { res = true; }
            else if (dig1 == 10 && cd_rgMaskedTextBox.Text.Substring(11, 1).ToUpper() == "X") { res = true; }
            else if (dig1 != 10 && cd_rgMaskedTextBox.Text.Substring(11, 1).ToUpper() == "X") {}
            else if (int.Parse(cd_rgMaskedTextBox.Text.Substring(11, 1)) == dig1) { res = true; }


            if (!res)
            {
                rgicon.Text = "Inválido!";
                rgicon.ForeColor = Color.Red;
            }
            else
            {
                rgicon.Text = "Válido!";
                rgicon.ForeColor = Color.Green;
            }
        }
        private void CpfBranco()
        {
            string texto = cd_cpfMaskedTextBox.Text;

            if (!texto.Contains(" "))
            {
                CalcularCpf();
            }
            else {
                cpficon.Text = "Inválido!";
                cpficon.ForeColor = Color.Red;
            }
        }
        private void RgBranco()
        {
            string texto = cd_rgMaskedTextBox.Text;
            if ((!texto.Contains(" ")))
            {
                if(!int.TryParse(texto.Substring(11, 1), out int s) && texto.Substring(11, 1).ToUpper() == "X")
                {
                    CalcularRg();
                }
                else
                {
                    rgicon.Text = "Inválido!";
                    rgicon.ForeColor = Color.Red;
                }
            }
            else {
                rgicon.Text = "Inválido!";
                rgicon.ForeColor = Color.Red;
            }
        }
        private void HabilitarEdicao()
        {
            cd_clienteTextBox.Enabled = false;
            nm_clienteTextBox.Enabled = true;
            ds_enderecoTextBox.Enabled = true;
            cd_numeroTextBox.Enabled = true;
            nm_bairroTextBox.Enabled = true;
            nm_cidadeTextBox.Enabled = true;
            sg_estadoComboBox.Enabled = true;
            cd_cepMaskedTextBox.Enabled = true;
            cd_cpfMaskedTextBox.Enabled = true;
            cd_rgMaskedTextBox.Enabled = true;
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

        private void DesabilitarEdicao()
        {
            cd_clienteTextBox.Enabled = false;
            nm_clienteTextBox.Enabled = false;
            ds_enderecoTextBox.Enabled = false;
            cd_numeroTextBox.Enabled = false;
            nm_bairroTextBox.Enabled = false;
            nm_cidadeTextBox.Enabled = false;
            sg_estadoComboBox.Enabled = false;
            cd_cepMaskedTextBox.Enabled = false;
            cd_cpfMaskedTextBox.Enabled = false;
            cd_rgMaskedTextBox.Enabled = false;
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
            cpficon.ForeColor = Control.DefaultBackColor;
            rgicon.ForeColor = Control.DefaultBackColor;
        }
        public frmCliente()
        {
            InitializeComponent();
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'banquihoDataSet.tb_cliente'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_clienteTableAdapter.Fill(this.banquihoDataSet.tb_cliente);
            DesabilitarEdicao();

        }


        private void tb_clienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tb_clienteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.banquihoDataSet);

        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            tb_clienteBindingSource.MovePrevious();
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            tb_clienteBindingSource.MoveNext();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            tb_clienteBindingSource.AddNew();
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
                tb_clienteBindingSource.RemoveCurrent();
                tb_clienteTableAdapter.Update(banquihoDataSet.tb_cliente);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (cpficon.ForeColor == Color.Red)
            {
                MessageBox.Show("CPF Inválido!!!");
                cd_cpfMaskedTextBox.Focus();
            }
            else
            {
                if(rgicon.ForeColor == Color.Red)
                {
                    MessageBox.Show("RG Inválido!!!");
                    cd_rgMaskedTextBox.Focus();
                }
                else
                {
                    Validate();
                    tb_clienteBindingSource.EndEdit();
                    tb_clienteTableAdapter.Update(banquihoDataSet.tb_cliente);
                    DesabilitarEdicao();
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            tb_clienteBindingSource.CancelEdit();
            DesabilitarEdicao();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cd_cpfMaskedTextBox_Leave(object sender, EventArgs e) //CPF Validar
        {
            CpfBranco();
        }

        private void cd_rgMaskedTextBox_Leave(object sender, EventArgs e) //RG Validar
        {
            RgBranco();
        }

        private void cd_rgMaskedTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            int cod, reg;
            frmPesquisaCliente fpc = new frmPesquisaCliente();
            fpc.ShowDialog();
            cod = fpc.getCodigo();
            if (cod > 0)
            {
                reg = tb_clienteBindingSource.Find("cd_cliente", cod);
                tb_clienteBindingSource.Position = reg;
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

            strDados = "FICHA DE CLIENTE" + (char)10 + (char)10;
            strDados += "Código: " + cd_clienteTextBox.Text + (char)10 + (char)10;
            strDados += "Nome: " + nm_clienteTextBox.Text + ", CPF: " + cd_cpfMaskedTextBox.Text + ", RG: " + cd_rgMaskedTextBox.Text + (char)10 + (char)10;
            strDados += "E-mail: " + ds_emailTextBox.Text + " |  Número: " + cd_telefoneMaskedTextBox.Text + (char)10 + (char)10;
            strDados += "ENDEREÇO" + (char)10 + (char)10 + (char)10;
            strDados += "Bairro - " + nm_bairroTextBox.Text + (char)10 + (char)10;
            strDados += ds_enderecoTextBox.Text + " - N°" + cd_numeroTextBox.Text + ", " + nm_cidadeTextBox.Text + " - " + sg_estadoComboBox.Text + (char)10 + (char)10;
            strDados += "CEP: " + cd_cepMaskedTextBox.Text;
            
            

            objImpressao.DrawString(strDados, new Font("Arial", 14, FontStyle.Bold), Brushes.Black, 50, 50);
            objImpressao.DrawLine(new Pen(Brushes.Black), 50, 80, 700, 80);
        }
    }
}
