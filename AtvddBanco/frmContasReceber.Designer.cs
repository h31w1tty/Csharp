namespace AtvddBanco
{
    partial class frmContasReceber
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
            System.Windows.Forms.Label ds_documentLabel;
            System.Windows.Forms.Label dt_emissaoLabel;
            System.Windows.Forms.Label dt_vencimentoLabel;
            System.Windows.Forms.Label vl_documentoLabel;
            System.Windows.Forms.Label dt_pagamentoLabel;
            System.Windows.Forms.Label vl_pagoLabel;
            System.Windows.Forms.Label cd_clienteLabel;
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
            this.tb_contasReceberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_contasReceberTableAdapter = new AtvddBanco.BanquihoDataSetTableAdapters.tb_contasReceberTableAdapter();
            this.tableAdapterManager = new AtvddBanco.BanquihoDataSetTableAdapters.TableAdapterManager();
            this.cd_contaTextBox = new System.Windows.Forms.TextBox();
            this.cd_documentoTextBox = new System.Windows.Forms.TextBox();
            this.ds_documentTextBox = new System.Windows.Forms.TextBox();
            this.dt_emissaoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dt_vencimentoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.vl_documentoTextBox = new System.Windows.Forms.TextBox();
            this.dt_pagamentoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.vl_pagoTextBox = new System.Windows.Forms.TextBox();
            this.cd_clienteTextBox = new System.Windows.Forms.TextBox();
            cd_contaLabel = new System.Windows.Forms.Label();
            cd_documentoLabel = new System.Windows.Forms.Label();
            ds_documentLabel = new System.Windows.Forms.Label();
            dt_emissaoLabel = new System.Windows.Forms.Label();
            dt_vencimentoLabel = new System.Windows.Forms.Label();
            vl_documentoLabel = new System.Windows.Forms.Label();
            dt_pagamentoLabel = new System.Windows.Forms.Label();
            vl_pagoLabel = new System.Windows.Forms.Label();
            cd_clienteLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.banquihoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_contasReceberBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cd_contaLabel
            // 
            cd_contaLabel.AutoSize = true;
            cd_contaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            cd_contaLabel.Location = new System.Drawing.Point(161, 43);
            cd_contaLabel.Name = "cd_contaLabel";
            cd_contaLabel.Size = new System.Drawing.Size(130, 24);
            cd_contaLabel.TabIndex = 45;
            cd_contaLabel.Text = "Código/Conta:";
            // 
            // cd_documentoLabel
            // 
            cd_documentoLabel.AutoSize = true;
            cd_documentoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            cd_documentoLabel.Location = new System.Drawing.Point(405, 89);
            cd_documentoLabel.Name = "cd_documentoLabel";
            cd_documentoLabel.Size = new System.Drawing.Size(164, 24);
            cd_documentoLabel.TabIndex = 47;
            cd_documentoLabel.Text = "Núm. Documento:";
            // 
            // ds_documentLabel
            // 
            ds_documentLabel.AutoSize = true;
            ds_documentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            ds_documentLabel.Location = new System.Drawing.Point(4, 89);
            ds_documentLabel.Name = "ds_documentLabel";
            ds_documentLabel.Size = new System.Drawing.Size(183, 24);
            ds_documentLabel.TabIndex = 49;
            ds_documentLabel.Text = "Tipo de Documento:";
            // 
            // dt_emissaoLabel
            // 
            dt_emissaoLabel.AutoSize = true;
            dt_emissaoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            dt_emissaoLabel.Location = new System.Drawing.Point(4, 125);
            dt_emissaoLabel.Name = "dt_emissaoLabel";
            dt_emissaoLabel.Size = new System.Drawing.Size(87, 24);
            dt_emissaoLabel.TabIndex = 51;
            dt_emissaoLabel.Text = "Emissão:";
            // 
            // dt_vencimentoLabel
            // 
            dt_vencimentoLabel.AutoSize = true;
            dt_vencimentoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            dt_vencimentoLabel.Location = new System.Drawing.Point(524, 237);
            dt_vencimentoLabel.Name = "dt_vencimentoLabel";
            dt_vencimentoLabel.Size = new System.Drawing.Size(117, 24);
            dt_vencimentoLabel.TabIndex = 53;
            dt_vencimentoLabel.Text = "Vencimento:";
            // 
            // vl_documentoLabel
            // 
            vl_documentoLabel.AutoSize = true;
            vl_documentoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            vl_documentoLabel.Location = new System.Drawing.Point(380, 126);
            vl_documentoLabel.Name = "vl_documentoLabel";
            vl_documentoLabel.Size = new System.Drawing.Size(189, 24);
            vl_documentoLabel.TabIndex = 55;
            vl_documentoLabel.Text = "Valor do Documento:";
            // 
            // dt_pagamentoLabel
            // 
            dt_pagamentoLabel.AutoSize = true;
            dt_pagamentoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            dt_pagamentoLabel.Location = new System.Drawing.Point(4, 161);
            dt_pagamentoLabel.Name = "dt_pagamentoLabel";
            dt_pagamentoLabel.Size = new System.Drawing.Size(180, 24);
            dt_pagamentoLabel.TabIndex = 57;
            dt_pagamentoLabel.Text = "Data de Pagamento:";
            // 
            // vl_pagoLabel
            // 
            vl_pagoLabel.AutoSize = true;
            vl_pagoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            vl_pagoLabel.Location = new System.Drawing.Point(461, 201);
            vl_pagoLabel.Name = "vl_pagoLabel";
            vl_pagoLabel.Size = new System.Drawing.Size(108, 24);
            vl_pagoLabel.TabIndex = 59;
            vl_pagoLabel.Text = "Valor Pago:";
            // 
            // cd_clienteLabel
            // 
            cd_clienteLabel.AutoSize = true;
            cd_clienteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            cd_clienteLabel.Location = new System.Drawing.Point(405, 40);
            cd_clienteLabel.Name = "cd_clienteLabel";
            cd_clienteLabel.Size = new System.Drawing.Size(139, 24);
            cd_clienteLabel.TabIndex = 61;
            cd_clienteLabel.Text = "Código/Cliente:";
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(586, 378);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(102, 36);
            this.btnSair.TabIndex = 44;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Location = new System.Drawing.Point(463, 378);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(102, 36);
            this.btnImprimir.TabIndex = 43;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Location = new System.Drawing.Point(340, 378);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(102, 36);
            this.btnPesquisar.TabIndex = 42;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(217, 378);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(102, 36);
            this.btnCancelar.TabIndex = 41;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(94, 378);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(102, 36);
            this.btnSalvar.TabIndex = 40;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(586, 319);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(102, 36);
            this.btnExcluir.TabIndex = 39;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.Location = new System.Drawing.Point(463, 319);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(102, 36);
            this.btnAlterar.TabIndex = 38;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Location = new System.Drawing.Point(340, 319);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(102, 36);
            this.btnNovo.TabIndex = 37;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnProximo
            // 
            this.btnProximo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProximo.Location = new System.Drawing.Point(217, 319);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(102, 36);
            this.btnProximo.TabIndex = 36;
            this.btnProximo.Text = "Próximo";
            this.btnProximo.UseVisualStyleBackColor = true;
            this.btnProximo.Click += new System.EventHandler(this.btnProximo_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnterior.Location = new System.Drawing.Point(94, 319);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(102, 36);
            this.btnAnterior.TabIndex = 35;
            this.btnAnterior.Text = "Anterior";
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // banquihoDataSet
            // 
            this.banquihoDataSet.DataSetName = "BanquihoDataSet";
            this.banquihoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tb_contasReceberBindingSource
            // 
            this.tb_contasReceberBindingSource.DataMember = "tb_contasReceber";
            this.tb_contasReceberBindingSource.DataSource = this.banquihoDataSet;
            // 
            // tb_contasReceberTableAdapter
            // 
            this.tb_contasReceberTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tb_clienteTableAdapter = null;
            this.tableAdapterManager.tb_contasPagarTableAdapter = null;
            this.tableAdapterManager.tb_contasReceberTableAdapter = this.tb_contasReceberTableAdapter;
            this.tableAdapterManager.tb_fornecedorTableAdapter = null;
            this.tableAdapterManager.tb_usuarioTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = AtvddBanco.BanquihoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cd_contaTextBox
            // 
            this.cd_contaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_contasReceberBindingSource, "cd_conta", true));
            this.cd_contaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.cd_contaTextBox.Location = new System.Drawing.Point(293, 40);
            this.cd_contaTextBox.Name = "cd_contaTextBox";
            this.cd_contaTextBox.Size = new System.Drawing.Size(65, 29);
            this.cd_contaTextBox.TabIndex = 46;
            // 
            // cd_documentoTextBox
            // 
            this.cd_documentoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_contasReceberBindingSource, "cd_documento", true));
            this.cd_documentoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.cd_documentoTextBox.Location = new System.Drawing.Point(569, 88);
            this.cd_documentoTextBox.MaxLength = 15;
            this.cd_documentoTextBox.Name = "cd_documentoTextBox";
            this.cd_documentoTextBox.Size = new System.Drawing.Size(200, 29);
            this.cd_documentoTextBox.TabIndex = 48;
            // 
            // ds_documentTextBox
            // 
            this.ds_documentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_contasReceberBindingSource, "ds_document", true));
            this.ds_documentTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.ds_documentTextBox.Location = new System.Drawing.Point(193, 88);
            this.ds_documentTextBox.MaxLength = 40;
            this.ds_documentTextBox.Name = "ds_documentTextBox";
            this.ds_documentTextBox.Size = new System.Drawing.Size(200, 29);
            this.ds_documentTextBox.TabIndex = 50;
            // 
            // dt_emissaoDateTimePicker
            // 
            this.dt_emissaoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tb_contasReceberBindingSource, "dt_emissao", true));
            this.dt_emissaoDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.dt_emissaoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_emissaoDateTimePicker.Location = new System.Drawing.Point(193, 125);
            this.dt_emissaoDateTimePicker.Name = "dt_emissaoDateTimePicker";
            this.dt_emissaoDateTimePicker.Size = new System.Drawing.Size(128, 29);
            this.dt_emissaoDateTimePicker.TabIndex = 52;
            // 
            // dt_vencimentoDateTimePicker
            // 
            this.dt_vencimentoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tb_contasReceberBindingSource, "dt_vencimento", true));
            this.dt_vencimentoDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.dt_vencimentoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_vencimentoDateTimePicker.Location = new System.Drawing.Point(641, 235);
            this.dt_vencimentoDateTimePicker.Name = "dt_vencimentoDateTimePicker";
            this.dt_vencimentoDateTimePicker.Size = new System.Drawing.Size(128, 29);
            this.dt_vencimentoDateTimePicker.TabIndex = 54;
            // 
            // vl_documentoTextBox
            // 
            this.vl_documentoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_contasReceberBindingSource, "vl_documento", true));
            this.vl_documentoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.vl_documentoTextBox.Location = new System.Drawing.Point(569, 125);
            this.vl_documentoTextBox.Name = "vl_documentoTextBox";
            this.vl_documentoTextBox.Size = new System.Drawing.Size(200, 29);
            this.vl_documentoTextBox.TabIndex = 56;
            // 
            // dt_pagamentoDateTimePicker
            // 
            this.dt_pagamentoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tb_contasReceberBindingSource, "dt_pagamento", true));
            this.dt_pagamentoDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.dt_pagamentoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_pagamentoDateTimePicker.Location = new System.Drawing.Point(193, 161);
            this.dt_pagamentoDateTimePicker.Name = "dt_pagamentoDateTimePicker";
            this.dt_pagamentoDateTimePicker.Size = new System.Drawing.Size(128, 29);
            this.dt_pagamentoDateTimePicker.TabIndex = 58;
            // 
            // vl_pagoTextBox
            // 
            this.vl_pagoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_contasReceberBindingSource, "vl_pago", true));
            this.vl_pagoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.vl_pagoTextBox.Location = new System.Drawing.Point(569, 200);
            this.vl_pagoTextBox.Name = "vl_pagoTextBox";
            this.vl_pagoTextBox.Size = new System.Drawing.Size(200, 29);
            this.vl_pagoTextBox.TabIndex = 60;
            // 
            // cd_clienteTextBox
            // 
            this.cd_clienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_contasReceberBindingSource, "cd_cliente", true));
            this.cd_clienteTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.cd_clienteTextBox.Location = new System.Drawing.Point(544, 39);
            this.cd_clienteTextBox.MaxLength = 9;
            this.cd_clienteTextBox.Name = "cd_clienteTextBox";
            this.cd_clienteTextBox.Size = new System.Drawing.Size(68, 29);
            this.cd_clienteTextBox.TabIndex = 62;
            // 
            // frmContasReceber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(cd_contaLabel);
            this.Controls.Add(this.cd_contaTextBox);
            this.Controls.Add(cd_documentoLabel);
            this.Controls.Add(this.cd_documentoTextBox);
            this.Controls.Add(ds_documentLabel);
            this.Controls.Add(this.ds_documentTextBox);
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
            this.Controls.Add(cd_clienteLabel);
            this.Controls.Add(this.cd_clienteTextBox);
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
            this.Name = "frmContasReceber";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar em Contas a Receber";
            this.Load += new System.EventHandler(this.frmContasReceber_Load);
            ((System.ComponentModel.ISupportInitialize)(this.banquihoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_contasReceberBindingSource)).EndInit();
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
        private System.Windows.Forms.BindingSource tb_contasReceberBindingSource;
        private BanquihoDataSetTableAdapters.tb_contasReceberTableAdapter tb_contasReceberTableAdapter;
        private BanquihoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox cd_contaTextBox;
        private System.Windows.Forms.TextBox cd_documentoTextBox;
        private System.Windows.Forms.TextBox ds_documentTextBox;
        private System.Windows.Forms.DateTimePicker dt_emissaoDateTimePicker;
        private System.Windows.Forms.DateTimePicker dt_vencimentoDateTimePicker;
        private System.Windows.Forms.TextBox vl_documentoTextBox;
        private System.Windows.Forms.DateTimePicker dt_pagamentoDateTimePicker;
        private System.Windows.Forms.TextBox vl_pagoTextBox;
        private System.Windows.Forms.TextBox cd_clienteTextBox;
    }
}