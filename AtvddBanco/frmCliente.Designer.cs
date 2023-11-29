namespace AtvddBanco
{
    partial class frmCliente
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
            System.Windows.Forms.Label cd_clienteLabel;
            System.Windows.Forms.Label nm_clienteLabel;
            System.Windows.Forms.Label ds_enderecoLabel;
            System.Windows.Forms.Label cd_numeroLabel;
            System.Windows.Forms.Label nm_bairroLabel;
            System.Windows.Forms.Label nm_cidadeLabel;
            System.Windows.Forms.Label sg_estadoLabel;
            System.Windows.Forms.Label cd_cepLabel;
            System.Windows.Forms.Label cd_cpfLabel;
            System.Windows.Forms.Label cd_rgLabel;
            System.Windows.Forms.Label cd_telefoneLabel;
            System.Windows.Forms.Label ds_emailLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCliente));
            this.tb_clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.banquihoDataSet = new AtvddBanco.BanquihoDataSet();
            this.tb_clienteTableAdapter = new AtvddBanco.BanquihoDataSetTableAdapters.tb_clienteTableAdapter();
            this.tableAdapterManager = new AtvddBanco.BanquihoDataSetTableAdapters.TableAdapterManager();
            this.cd_clienteTextBox = new System.Windows.Forms.TextBox();
            this.nm_clienteTextBox = new System.Windows.Forms.TextBox();
            this.ds_enderecoTextBox = new System.Windows.Forms.TextBox();
            this.cd_numeroTextBox = new System.Windows.Forms.TextBox();
            this.nm_bairroTextBox = new System.Windows.Forms.TextBox();
            this.nm_cidadeTextBox = new System.Windows.Forms.TextBox();
            this.ds_emailTextBox = new System.Windows.Forms.TextBox();
            this.cd_cepMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.cd_cpfMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.cd_rgMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.cd_telefoneMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnProximo = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.sg_estadoComboBox = new System.Windows.Forms.ComboBox();
            this.cpficon = new System.Windows.Forms.Label();
            this.rgicon = new System.Windows.Forms.Label();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            cd_clienteLabel = new System.Windows.Forms.Label();
            nm_clienteLabel = new System.Windows.Forms.Label();
            ds_enderecoLabel = new System.Windows.Forms.Label();
            cd_numeroLabel = new System.Windows.Forms.Label();
            nm_bairroLabel = new System.Windows.Forms.Label();
            nm_cidadeLabel = new System.Windows.Forms.Label();
            sg_estadoLabel = new System.Windows.Forms.Label();
            cd_cepLabel = new System.Windows.Forms.Label();
            cd_cpfLabel = new System.Windows.Forms.Label();
            cd_rgLabel = new System.Windows.Forms.Label();
            cd_telefoneLabel = new System.Windows.Forms.Label();
            ds_emailLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tb_clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.banquihoDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // cd_clienteLabel
            // 
            cd_clienteLabel.AutoSize = true;
            cd_clienteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            cd_clienteLabel.Location = new System.Drawing.Point(252, 15);
            cd_clienteLabel.Name = "cd_clienteLabel";
            cd_clienteLabel.Size = new System.Drawing.Size(76, 24);
            cd_clienteLabel.TabIndex = 34;
            cd_clienteLabel.Text = "Código:";
            // 
            // nm_clienteLabel
            // 
            nm_clienteLabel.AutoSize = true;
            nm_clienteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            nm_clienteLabel.Location = new System.Drawing.Point(12, 66);
            nm_clienteLabel.Name = "nm_clienteLabel";
            nm_clienteLabel.Size = new System.Drawing.Size(73, 24);
            nm_clienteLabel.TabIndex = 36;
            nm_clienteLabel.Text = "Cliente:";
            // 
            // ds_enderecoLabel
            // 
            ds_enderecoLabel.AutoSize = true;
            ds_enderecoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            ds_enderecoLabel.Location = new System.Drawing.Point(7, 153);
            ds_enderecoLabel.Name = "ds_enderecoLabel";
            ds_enderecoLabel.Size = new System.Drawing.Size(49, 24);
            ds_enderecoLabel.TabIndex = 38;
            ds_enderecoLabel.Text = "Rua:";
            // 
            // cd_numeroLabel
            // 
            cd_numeroLabel.AutoSize = true;
            cd_numeroLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            cd_numeroLabel.Location = new System.Drawing.Point(306, 153);
            cd_numeroLabel.Name = "cd_numeroLabel";
            cd_numeroLabel.Size = new System.Drawing.Size(84, 24);
            cd_numeroLabel.TabIndex = 40;
            cd_numeroLabel.Text = "Número:";
            // 
            // nm_bairroLabel
            // 
            nm_bairroLabel.AutoSize = true;
            nm_bairroLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            nm_bairroLabel.Location = new System.Drawing.Point(490, 153);
            nm_bairroLabel.Name = "nm_bairroLabel";
            nm_bairroLabel.Size = new System.Drawing.Size(64, 24);
            nm_bairroLabel.TabIndex = 42;
            nm_bairroLabel.Text = "Bairro:";
            // 
            // nm_cidadeLabel
            // 
            nm_cidadeLabel.AutoSize = true;
            nm_cidadeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            nm_cidadeLabel.Location = new System.Drawing.Point(33, 193);
            nm_cidadeLabel.Name = "nm_cidadeLabel";
            nm_cidadeLabel.Size = new System.Drawing.Size(75, 24);
            nm_cidadeLabel.TabIndex = 44;
            nm_cidadeLabel.Text = "Cidade:";
            // 
            // sg_estadoLabel
            // 
            sg_estadoLabel.AutoSize = true;
            sg_estadoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            sg_estadoLabel.Location = new System.Drawing.Point(302, 193);
            sg_estadoLabel.Name = "sg_estadoLabel";
            sg_estadoLabel.Size = new System.Drawing.Size(73, 24);
            sg_estadoLabel.TabIndex = 46;
            sg_estadoLabel.Text = "Estado:";
            // 
            // cd_cepLabel
            // 
            cd_cepLabel.AutoSize = true;
            cd_cepLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            cd_cepLabel.Location = new System.Drawing.Point(439, 193);
            cd_cepLabel.Name = "cd_cepLabel";
            cd_cepLabel.Size = new System.Drawing.Size(53, 24);
            cd_cepLabel.TabIndex = 48;
            cd_cepLabel.Text = "CEP:";
            // 
            // cd_cpfLabel
            // 
            cd_cpfLabel.AutoSize = true;
            cd_cpfLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            cd_cpfLabel.Location = new System.Drawing.Point(303, 66);
            cd_cpfLabel.Name = "cd_cpfLabel";
            cd_cpfLabel.Size = new System.Drawing.Size(52, 24);
            cd_cpfLabel.TabIndex = 50;
            cd_cpfLabel.Text = "CPF:";
            // 
            // cd_rgLabel
            // 
            cd_rgLabel.AutoSize = true;
            cd_rgLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            cd_rgLabel.Location = new System.Drawing.Point(516, 66);
            cd_rgLabel.Name = "cd_rgLabel";
            cd_rgLabel.Size = new System.Drawing.Size(42, 24);
            cd_rgLabel.TabIndex = 52;
            cd_rgLabel.Text = "RG:";
            // 
            // cd_telefoneLabel
            // 
            cd_telefoneLabel.AutoSize = true;
            cd_telefoneLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_clienteBindingSource, "cd_telefone", true));
            cd_telefoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            cd_telefoneLabel.Location = new System.Drawing.Point(354, 102);
            cd_telefoneLabel.Name = "cd_telefoneLabel";
            cd_telefoneLabel.Size = new System.Drawing.Size(90, 24);
            cd_telefoneLabel.TabIndex = 54;
            cd_telefoneLabel.Text = "Telefone:";
            // 
            // tb_clienteBindingSource
            // 
            this.tb_clienteBindingSource.DataMember = "tb_cliente";
            this.tb_clienteBindingSource.DataSource = this.banquihoDataSet;
            // 
            // banquihoDataSet
            // 
            this.banquihoDataSet.DataSetName = "BanquihoDataSet";
            this.banquihoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ds_emailLabel
            // 
            ds_emailLabel.AutoSize = true;
            ds_emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            ds_emailLabel.Location = new System.Drawing.Point(27, 102);
            ds_emailLabel.Name = "ds_emailLabel";
            ds_emailLabel.Size = new System.Drawing.Size(68, 24);
            ds_emailLabel.TabIndex = 56;
            ds_emailLabel.Text = "E-mail:";
            // 
            // tb_clienteTableAdapter
            // 
            this.tb_clienteTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tb_clienteTableAdapter = this.tb_clienteTableAdapter;
            this.tableAdapterManager.tb_contasPagarTableAdapter = null;
            this.tableAdapterManager.tb_contasReceberTableAdapter = null;
            this.tableAdapterManager.tb_fornecedorTableAdapter = null;
            this.tableAdapterManager.tb_usuarioTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = AtvddBanco.BanquihoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cd_clienteTextBox
            // 
            this.cd_clienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_clienteBindingSource, "cd_cliente", true));
            this.cd_clienteTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.cd_clienteTextBox.Location = new System.Drawing.Point(334, 12);
            this.cd_clienteTextBox.Name = "cd_clienteTextBox";
            this.cd_clienteTextBox.Size = new System.Drawing.Size(59, 29);
            this.cd_clienteTextBox.TabIndex = 35;
            // 
            // nm_clienteTextBox
            // 
            this.nm_clienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_clienteBindingSource, "nm_cliente", true));
            this.nm_clienteTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.nm_clienteTextBox.Location = new System.Drawing.Point(85, 65);
            this.nm_clienteTextBox.MaxLength = 50;
            this.nm_clienteTextBox.Name = "nm_clienteTextBox";
            this.nm_clienteTextBox.Size = new System.Drawing.Size(212, 29);
            this.nm_clienteTextBox.TabIndex = 37;
            // 
            // ds_enderecoTextBox
            // 
            this.ds_enderecoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_clienteBindingSource, "ds_endereco", true));
            this.ds_enderecoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.ds_enderecoTextBox.Location = new System.Drawing.Point(56, 152);
            this.ds_enderecoTextBox.MaxLength = 40;
            this.ds_enderecoTextBox.Name = "ds_enderecoTextBox";
            this.ds_enderecoTextBox.Size = new System.Drawing.Size(241, 29);
            this.ds_enderecoTextBox.TabIndex = 39;
            // 
            // cd_numeroTextBox
            // 
            this.cd_numeroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_clienteBindingSource, "cd_numero", true));
            this.cd_numeroTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.cd_numeroTextBox.Location = new System.Drawing.Point(390, 152);
            this.cd_numeroTextBox.MaxLength = 10;
            this.cd_numeroTextBox.Name = "cd_numeroTextBox";
            this.cd_numeroTextBox.Size = new System.Drawing.Size(85, 29);
            this.cd_numeroTextBox.TabIndex = 41;
            // 
            // nm_bairroTextBox
            // 
            this.nm_bairroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_clienteBindingSource, "nm_bairro", true));
            this.nm_bairroTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.nm_bairroTextBox.Location = new System.Drawing.Point(554, 152);
            this.nm_bairroTextBox.MaxLength = 30;
            this.nm_bairroTextBox.Name = "nm_bairroTextBox";
            this.nm_bairroTextBox.Size = new System.Drawing.Size(169, 29);
            this.nm_bairroTextBox.TabIndex = 43;
            // 
            // nm_cidadeTextBox
            // 
            this.nm_cidadeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_clienteBindingSource, "nm_cidade", true));
            this.nm_cidadeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.nm_cidadeTextBox.Location = new System.Drawing.Point(108, 190);
            this.nm_cidadeTextBox.MaxLength = 30;
            this.nm_cidadeTextBox.Name = "nm_cidadeTextBox";
            this.nm_cidadeTextBox.Size = new System.Drawing.Size(182, 29);
            this.nm_cidadeTextBox.TabIndex = 45;
            // 
            // ds_emailTextBox
            // 
            this.ds_emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_clienteBindingSource, "ds_email", true));
            this.ds_emailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.ds_emailTextBox.Location = new System.Drawing.Point(102, 99);
            this.ds_emailTextBox.MaxLength = 100;
            this.ds_emailTextBox.Name = "ds_emailTextBox";
            this.ds_emailTextBox.Size = new System.Drawing.Size(233, 29);
            this.ds_emailTextBox.TabIndex = 57;
            // 
            // cd_cepMaskedTextBox
            // 
            this.cd_cepMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_clienteBindingSource, "cd_cep", true));
            this.cd_cepMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.cd_cepMaskedTextBox.Location = new System.Drawing.Point(494, 190);
            this.cd_cepMaskedTextBox.Mask = "00000-000";
            this.cd_cepMaskedTextBox.Name = "cd_cepMaskedTextBox";
            this.cd_cepMaskedTextBox.Size = new System.Drawing.Size(92, 29);
            this.cd_cepMaskedTextBox.TabIndex = 58;
            // 
            // cd_cpfMaskedTextBox
            // 
            this.cd_cpfMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_clienteBindingSource, "cd_cpf", true));
            this.cd_cpfMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.cd_cpfMaskedTextBox.Location = new System.Drawing.Point(354, 65);
            this.cd_cpfMaskedTextBox.Mask = "000,000,000-00";
            this.cd_cpfMaskedTextBox.Name = "cd_cpfMaskedTextBox";
            this.cd_cpfMaskedTextBox.Size = new System.Drawing.Size(138, 29);
            this.cd_cpfMaskedTextBox.TabIndex = 59;
            this.cd_cpfMaskedTextBox.Leave += new System.EventHandler(this.cd_cpfMaskedTextBox_Leave);
            // 
            // cd_rgMaskedTextBox
            // 
            this.cd_rgMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_clienteBindingSource, "cd_rg", true));
            this.cd_rgMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.cd_rgMaskedTextBox.Location = new System.Drawing.Point(557, 65);
            this.cd_rgMaskedTextBox.Mask = "00,000,000-a";
            this.cd_rgMaskedTextBox.Name = "cd_rgMaskedTextBox";
            this.cd_rgMaskedTextBox.Size = new System.Drawing.Size(126, 29);
            this.cd_rgMaskedTextBox.TabIndex = 60;
            this.cd_rgMaskedTextBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.cd_rgMaskedTextBox_MaskInputRejected);
            this.cd_rgMaskedTextBox.Leave += new System.EventHandler(this.cd_rgMaskedTextBox_Leave);
            // 
            // cd_telefoneMaskedTextBox
            // 
            this.cd_telefoneMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_clienteBindingSource, "cd_telefone", true));
            this.cd_telefoneMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.cd_telefoneMaskedTextBox.Location = new System.Drawing.Point(443, 101);
            this.cd_telefoneMaskedTextBox.Mask = "(00) 000000000";
            this.cd_telefoneMaskedTextBox.Name = "cd_telefoneMaskedTextBox";
            this.cd_telefoneMaskedTextBox.Size = new System.Drawing.Size(143, 29);
            this.cd_telefoneMaskedTextBox.TabIndex = 61;
            // 
            // btnAnterior
            // 
            this.btnAnterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnterior.Location = new System.Drawing.Point(72, 268);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(102, 34);
            this.btnAnterior.TabIndex = 24;
            this.btnAnterior.Text = "Anterior";
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnProximo
            // 
            this.btnProximo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProximo.Location = new System.Drawing.Point(195, 268);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(102, 34);
            this.btnProximo.TabIndex = 25;
            this.btnProximo.Text = "Próximo";
            this.btnProximo.UseVisualStyleBackColor = true;
            this.btnProximo.Click += new System.EventHandler(this.btnProximo_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Location = new System.Drawing.Point(318, 268);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(102, 34);
            this.btnNovo.TabIndex = 26;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.Location = new System.Drawing.Point(441, 268);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(102, 34);
            this.btnAlterar.TabIndex = 27;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(564, 268);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(102, 34);
            this.btnExcluir.TabIndex = 28;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(72, 327);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(102, 34);
            this.btnSalvar.TabIndex = 29;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(195, 327);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(102, 34);
            this.btnCancelar.TabIndex = 30;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Location = new System.Drawing.Point(318, 327);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(102, 34);
            this.btnPesquisar.TabIndex = 31;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Location = new System.Drawing.Point(441, 327);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(102, 34);
            this.btnImprimir.TabIndex = 32;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(564, 327);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(102, 34);
            this.btnSair.TabIndex = 33;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // sg_estadoComboBox
            // 
            this.sg_estadoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_clienteBindingSource, "sg_estado", true));
            this.sg_estadoComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.sg_estadoComboBox.FormattingEnabled = true;
            this.sg_estadoComboBox.IntegralHeight = false;
            this.sg_estadoComboBox.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.sg_estadoComboBox.Location = new System.Drawing.Point(378, 190);
            this.sg_estadoComboBox.Name = "sg_estadoComboBox";
            this.sg_estadoComboBox.Size = new System.Drawing.Size(48, 32);
            this.sg_estadoComboBox.TabIndex = 63;
            // 
            // cpficon
            // 
            this.cpficon.AutoSize = true;
            this.cpficon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.cpficon.ForeColor = System.Drawing.SystemColors.Control;
            this.cpficon.Location = new System.Drawing.Point(393, 43);
            this.cpficon.Name = "cpficon";
            this.cpficon.Size = new System.Drawing.Size(60, 20);
            this.cpficon.TabIndex = 64;
            this.cpficon.Text = "Válido!";
            // 
            // rgicon
            // 
            this.rgicon.AutoSize = true;
            this.rgicon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.rgicon.ForeColor = System.Drawing.SystemColors.Control;
            this.rgicon.Location = new System.Drawing.Point(590, 43);
            this.rgicon.Name = "rgicon";
            this.rgicon.Size = new System.Drawing.Size(60, 20);
            this.rgicon.TabIndex = 65;
            this.rgicon.Text = "Válido!";
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 388);
            this.ControlBox = false;
            this.Controls.Add(this.rgicon);
            this.Controls.Add(this.cpficon);
            this.Controls.Add(this.sg_estadoComboBox);
            this.Controls.Add(this.cd_telefoneMaskedTextBox);
            this.Controls.Add(this.cd_rgMaskedTextBox);
            this.Controls.Add(this.cd_cpfMaskedTextBox);
            this.Controls.Add(this.cd_cepMaskedTextBox);
            this.Controls.Add(cd_clienteLabel);
            this.Controls.Add(this.cd_clienteTextBox);
            this.Controls.Add(nm_clienteLabel);
            this.Controls.Add(this.nm_clienteTextBox);
            this.Controls.Add(ds_enderecoLabel);
            this.Controls.Add(this.ds_enderecoTextBox);
            this.Controls.Add(cd_numeroLabel);
            this.Controls.Add(this.cd_numeroTextBox);
            this.Controls.Add(nm_bairroLabel);
            this.Controls.Add(this.nm_bairroTextBox);
            this.Controls.Add(nm_cidadeLabel);
            this.Controls.Add(this.nm_cidadeTextBox);
            this.Controls.Add(sg_estadoLabel);
            this.Controls.Add(cd_cepLabel);
            this.Controls.Add(cd_cpfLabel);
            this.Controls.Add(cd_rgLabel);
            this.Controls.Add(cd_telefoneLabel);
            this.Controls.Add(ds_emailLabel);
            this.Controls.Add(this.ds_emailTextBox);
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
            this.Name = "frmCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Cliente";
            this.Load += new System.EventHandler(this.frmCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tb_clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.banquihoDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private BanquihoDataSet banquihoDataSet;
        private System.Windows.Forms.BindingSource tb_clienteBindingSource;
        private BanquihoDataSetTableAdapters.tb_clienteTableAdapter tb_clienteTableAdapter;
        private BanquihoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox cd_clienteTextBox;
        private System.Windows.Forms.TextBox nm_clienteTextBox;
        private System.Windows.Forms.TextBox ds_enderecoTextBox;
        private System.Windows.Forms.TextBox cd_numeroTextBox;
        private System.Windows.Forms.TextBox nm_bairroTextBox;
        private System.Windows.Forms.TextBox nm_cidadeTextBox;
        private System.Windows.Forms.TextBox ds_emailTextBox;
        private System.Windows.Forms.MaskedTextBox cd_cepMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox cd_cpfMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox cd_rgMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox cd_telefoneMaskedTextBox;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnProximo;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.ComboBox sg_estadoComboBox;
        private System.Windows.Forms.Label cpficon;
        private System.Windows.Forms.Label rgicon;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}