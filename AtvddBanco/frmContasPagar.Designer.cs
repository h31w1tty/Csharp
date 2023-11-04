namespace AtvddBanco
{
    partial class frmContasPagar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label cd_contaLabel;
            System.Windows.Forms.Label cd_documentoLabel;
            System.Windows.Forms.Label ds_documentoLabel;
            System.Windows.Forms.Label dt_emissaoLabel;
            System.Windows.Forms.Label dt_vencimentoLabel;
            System.Windows.Forms.Label vl_documentoLabel;
            System.Windows.Forms.Label dt_pagamentoLabel;
            System.Windows.Forms.Label vl_pagoLabel;
            System.Windows.Forms.Label cd_fornecedorLabel;
            this.btnSair = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnProximo = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.banquihoDataSet = new AtvddBanco.BanquihoDataSet();
            this.tb_contasPagarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_contasPagarTableAdapter = new AtvddBanco.BanquihoDataSetTableAdapters.tb_contasPagarTableAdapter();
            this.tableAdapterManager = new AtvddBanco.BanquihoDataSetTableAdapters.TableAdapterManager();
            this.cd_contaTextBox = new System.Windows.Forms.TextBox();
            this.cd_documentoTextBox = new System.Windows.Forms.TextBox();
            this.ds_documentoTextBox = new System.Windows.Forms.TextBox();
            this.dt_emissaoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dt_vencimentoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.vl_documentoTextBox = new System.Windows.Forms.TextBox();
            this.dt_pagamentoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.vl_pagoTextBox = new System.Windows.Forms.TextBox();
            this.cd_fornecedorTextBox = new System.Windows.Forms.TextBox();
            cd_contaLabel = new System.Windows.Forms.Label();
            cd_documentoLabel = new System.Windows.Forms.Label();
            ds_documentoLabel = new System.Windows.Forms.Label();
            dt_emissaoLabel = new System.Windows.Forms.Label();
            dt_vencimentoLabel = new System.Windows.Forms.Label();
            vl_documentoLabel = new System.Windows.Forms.Label();
            dt_pagamentoLabel = new System.Windows.Forms.Label();
            vl_pagoLabel = new System.Windows.Forms.Label();
            cd_fornecedorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.banquihoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_contasPagarBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(592, 391);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(102, 36);
            this.btnSair.TabIndex = 54;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Location = new System.Drawing.Point(469, 391);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(102, 36);
            this.btnImprimir.TabIndex = 53;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Location = new System.Drawing.Point(346, 391);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(102, 36);
            this.btnPesquisar.TabIndex = 52;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(223, 391);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(102, 36);
            this.btnCancelar.TabIndex = 51;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(100, 391);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(102, 36);
            this.btnSalvar.TabIndex = 50;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(592, 332);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(102, 36);
            this.btnExcluir.TabIndex = 49;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.Location = new System.Drawing.Point(469, 332);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(102, 36);
            this.btnAlterar.TabIndex = 48;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Location = new System.Drawing.Point(346, 332);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(102, 36);
            this.btnNovo.TabIndex = 47;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnProximo
            // 
            this.btnProximo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProximo.Location = new System.Drawing.Point(223, 332);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(102, 36);
            this.btnProximo.TabIndex = 46;
            this.btnProximo.Text = "Próximo";
            this.btnProximo.UseVisualStyleBackColor = true;
            this.btnProximo.Click += new System.EventHandler(this.btnProximo_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnterior.Location = new System.Drawing.Point(100, 332);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(102, 36);
            this.btnAnterior.TabIndex = 45;
            this.btnAnterior.Text = "Anterior";
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // banquihoDataSet
            // 
            this.banquihoDataSet.DataSetName = "BanquihoDataSet";
            this.banquihoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tb_contasPagarBindingSource
            // 
            this.tb_contasPagarBindingSource.DataMember = "tb_contasPagar";
            this.tb_contasPagarBindingSource.DataSource = this.banquihoDataSet;
            // 
            // tb_contasPagarTableAdapter
            // 
            this.tb_contasPagarTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tb_clienteTableAdapter = null;
            this.tableAdapterManager.tb_contasPagarTableAdapter = this.tb_contasPagarTableAdapter;
            this.tableAdapterManager.tb_contasReceberTableAdapter = null;
            this.tableAdapterManager.tb_fornecedorTableAdapter = null;
            this.tableAdapterManager.tb_usuarioTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = AtvddBanco.BanquihoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cd_contaLabel
            // 
            cd_contaLabel.AutoSize = true;
            cd_contaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            cd_contaLabel.Location = new System.Drawing.Point(134, 17);
            cd_contaLabel.Name = "cd_contaLabel";
            cd_contaLabel.Size = new System.Drawing.Size(130, 24);
            cd_contaLabel.TabIndex = 55;
            cd_contaLabel.Text = "Código/Conta:";
            // 
            // cd_contaTextBox
            // 
            this.cd_contaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_contasPagarBindingSource, "cd_conta", true));
            this.cd_contaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.cd_contaTextBox.Location = new System.Drawing.Point(264, 17);
            this.cd_contaTextBox.Name = "cd_contaTextBox";
            this.cd_contaTextBox.Size = new System.Drawing.Size(80, 29);
            this.cd_contaTextBox.TabIndex = 56;
            // 
            // cd_documentoLabel
            // 
            cd_documentoLabel.AutoSize = true;
            cd_documentoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            cd_documentoLabel.Location = new System.Drawing.Point(342, 90);
            cd_documentoLabel.Name = "cd_documentoLabel";
            cd_documentoLabel.Size = new System.Drawing.Size(209, 24);
            cd_documentoLabel.TabIndex = 57;
            cd_documentoLabel.Text = "Número do Documento";
            // 
            // cd_documentoTextBox
            // 
            this.cd_documentoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_contasPagarBindingSource, "cd_documento", true));
            this.cd_documentoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.cd_documentoTextBox.Location = new System.Drawing.Point(551, 90);
            this.cd_documentoTextBox.MaxLength = 15;
            this.cd_documentoTextBox.Name = "cd_documentoTextBox";
            this.cd_documentoTextBox.Size = new System.Drawing.Size(200, 29);
            this.cd_documentoTextBox.TabIndex = 58;
            // 
            // ds_documentoLabel
            // 
            ds_documentoLabel.AutoSize = true;
            ds_documentoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            ds_documentoLabel.Location = new System.Drawing.Point(15, 90);
            ds_documentoLabel.Name = "ds_documentoLabel";
            ds_documentoLabel.Size = new System.Drawing.Size(183, 24);
            ds_documentoLabel.TabIndex = 59;
            ds_documentoLabel.Text = "Tipo de Documento:";
            // 
            // ds_documentoTextBox
            // 
            this.ds_documentoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_contasPagarBindingSource, "ds_documento", true));
            this.ds_documentoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.ds_documentoTextBox.Location = new System.Drawing.Point(198, 90);
            this.ds_documentoTextBox.MaxLength = 40;
            this.ds_documentoTextBox.Name = "ds_documentoTextBox";
            this.ds_documentoTextBox.Size = new System.Drawing.Size(139, 29);
            this.ds_documentoTextBox.TabIndex = 60;
            // 
            // dt_emissaoLabel
            // 
            dt_emissaoLabel.AutoSize = true;
            dt_emissaoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            dt_emissaoLabel.Location = new System.Drawing.Point(16, 133);
            dt_emissaoLabel.Name = "dt_emissaoLabel";
            dt_emissaoLabel.Size = new System.Drawing.Size(156, 24);
            dt_emissaoLabel.TabIndex = 61;
            dt_emissaoLabel.Text = "Data de Emissão:";
            // 
            // dt_emissaoDateTimePicker
            // 
            this.dt_emissaoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tb_contasPagarBindingSource, "dt_emissao", true));
            this.dt_emissaoDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.dt_emissaoDateTimePicker.Location = new System.Drawing.Point(172, 133);
            this.dt_emissaoDateTimePicker.Name = "dt_emissaoDateTimePicker";
            this.dt_emissaoDateTimePicker.Size = new System.Drawing.Size(200, 29);
            this.dt_emissaoDateTimePicker.TabIndex = 62;
            // 
            // dt_vencimentoLabel
            // 
            dt_vencimentoLabel.AutoSize = true;
            dt_vencimentoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            dt_vencimentoLabel.Location = new System.Drawing.Point(34, 203);
            dt_vencimentoLabel.Name = "dt_vencimentoLabel";
            dt_vencimentoLabel.Size = new System.Drawing.Size(117, 24);
            dt_vencimentoLabel.TabIndex = 63;
            dt_vencimentoLabel.Text = "Vencimento:";
            // 
            // dt_vencimentoDateTimePicker
            // 
            this.dt_vencimentoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tb_contasPagarBindingSource, "dt_vencimento", true));
            this.dt_vencimentoDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.dt_vencimentoDateTimePicker.Location = new System.Drawing.Point(151, 203);
            this.dt_vencimentoDateTimePicker.Name = "dt_vencimentoDateTimePicker";
            this.dt_vencimentoDateTimePicker.Size = new System.Drawing.Size(200, 29);
            this.dt_vencimentoDateTimePicker.TabIndex = 64;
            // 
            // vl_documentoLabel
            // 
            vl_documentoLabel.AutoSize = true;
            vl_documentoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            vl_documentoLabel.Location = new System.Drawing.Point(356, 203);
            vl_documentoLabel.Name = "vl_documentoLabel";
            vl_documentoLabel.Size = new System.Drawing.Size(189, 24);
            vl_documentoLabel.TabIndex = 65;
            vl_documentoLabel.Text = "Valor do Documento:";
            // 
            // vl_documentoTextBox
            // 
            this.vl_documentoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_contasPagarBindingSource, "vl_documento", true));
            this.vl_documentoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.vl_documentoTextBox.Location = new System.Drawing.Point(545, 203);
            this.vl_documentoTextBox.Name = "vl_documentoTextBox";
            this.vl_documentoTextBox.Size = new System.Drawing.Size(200, 29);
            this.vl_documentoTextBox.TabIndex = 66;
            // 
            // dt_pagamentoLabel
            // 
            dt_pagamentoLabel.AutoSize = true;
            dt_pagamentoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            dt_pagamentoLabel.Location = new System.Drawing.Point(384, 133);
            dt_pagamentoLabel.Name = "dt_pagamentoLabel";
            dt_pagamentoLabel.Size = new System.Drawing.Size(111, 24);
            dt_pagamentoLabel.TabIndex = 67;
            dt_pagamentoLabel.Text = "Pagamento:";
            // 
            // dt_pagamentoDateTimePicker
            // 
            this.dt_pagamentoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tb_contasPagarBindingSource, "dt_pagamento", true));
            this.dt_pagamentoDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.dt_pagamentoDateTimePicker.Location = new System.Drawing.Point(495, 133);
            this.dt_pagamentoDateTimePicker.Name = "dt_pagamentoDateTimePicker";
            this.dt_pagamentoDateTimePicker.Size = new System.Drawing.Size(200, 29);
            this.dt_pagamentoDateTimePicker.TabIndex = 68;
            // 
            // vl_pagoLabel
            // 
            vl_pagoLabel.AutoSize = true;
            vl_pagoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            vl_pagoLabel.Location = new System.Drawing.Point(425, 244);
            vl_pagoLabel.Name = "vl_pagoLabel";
            vl_pagoLabel.Size = new System.Drawing.Size(108, 24);
            vl_pagoLabel.TabIndex = 69;
            vl_pagoLabel.Text = "Valor Pago:";
            // 
            // vl_pagoTextBox
            // 
            this.vl_pagoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_contasPagarBindingSource, "vl_pago", true));
            this.vl_pagoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.vl_pagoTextBox.Location = new System.Drawing.Point(533, 243);
            this.vl_pagoTextBox.Name = "vl_pagoTextBox";
            this.vl_pagoTextBox.Size = new System.Drawing.Size(200, 29);
            this.vl_pagoTextBox.TabIndex = 70;
            // 
            // cd_fornecedorLabel
            // 
            cd_fornecedorLabel.AutoSize = true;
            cd_fornecedorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            cd_fornecedorLabel.Location = new System.Drawing.Point(384, 17);
            cd_fornecedorLabel.Name = "cd_fornecedorLabel";
            cd_fornecedorLabel.Size = new System.Drawing.Size(181, 24);
            cd_fornecedorLabel.TabIndex = 71;
            cd_fornecedorLabel.Text = "Código/Fornecedor:";
            // 
            // cd_fornecedorTextBox
            // 
            this.cd_fornecedorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_contasPagarBindingSource, "cd_fornecedor", true));
            this.cd_fornecedorTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.cd_fornecedorTextBox.Location = new System.Drawing.Point(565, 17);
            this.cd_fornecedorTextBox.MaxLength = 9;
            this.cd_fornecedorTextBox.Name = "cd_fornecedorTextBox";
            this.cd_fornecedorTextBox.Size = new System.Drawing.Size(85, 29);
            this.cd_fornecedorTextBox.TabIndex = 72;
            // 
            // frmContasPagar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 457);
            this.ControlBox = false;
            this.Controls.Add(cd_contaLabel);
            this.Controls.Add(this.cd_contaTextBox);
            this.Controls.Add(cd_documentoLabel);
            this.Controls.Add(this.cd_documentoTextBox);
            this.Controls.Add(ds_documentoLabel);
            this.Controls.Add(this.ds_documentoTextBox);
            this.Controls.Add(dt_emissaoLabel);
            this.Controls.Add(this.dt_emissaoDateTimePicker);
            this.Controls.Add(dt_vencimentoLabel);
            this.Controls.Add(this.dt_vencimentoDateTimePicker);
            this.Controls.Add(vl_documentoLabel);
            this.Controls.Add(this.vl_documentoTextBox);
            this.Controls.Add(dt_pagamentoLabel);
            this.Controls.Add(this.dt_pagamentoDateTimePicker);
            this.Controls.Add(vl_pagoLabel);
            this.Controls.Add(this.vl_pagoTextBox);
            this.Controls.Add(cd_fornecedorLabel);
            this.Controls.Add(this.cd_fornecedorTextBox);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnProximo);
            this.Controls.Add(this.btnAnterior);
            this.Name = "frmContasPagar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar em Contas a Pagar";
            this.Load += new System.EventHandler(this.frmContasPagar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.banquihoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_contasPagarBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnProximo;
        private System.Windows.Forms.Button btnAnterior;
        private BanquihoDataSet banquihoDataSet;
        private System.Windows.Forms.BindingSource tb_contasPagarBindingSource;
        private BanquihoDataSetTableAdapters.tb_contasPagarTableAdapter tb_contasPagarTableAdapter;
        private BanquihoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox cd_contaTextBox;
        private System.Windows.Forms.TextBox cd_documentoTextBox;
        private System.Windows.Forms.TextBox ds_documentoTextBox;
        private System.Windows.Forms.DateTimePicker dt_emissaoDateTimePicker;
        private System.Windows.Forms.DateTimePicker dt_vencimentoDateTimePicker;
        private System.Windows.Forms.TextBox vl_documentoTextBox;
        private System.Windows.Forms.DateTimePicker dt_pagamentoDateTimePicker;
        private System.Windows.Forms.TextBox vl_pagoTextBox;
        private System.Windows.Forms.TextBox cd_fornecedorTextBox;
    }
}