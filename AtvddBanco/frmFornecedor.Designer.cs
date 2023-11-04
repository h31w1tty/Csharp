namespace AtvddBanco
{
    partial class frmFornecedor
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
            System.Windows.Forms.Label cd_fornecedorLabel;
            System.Windows.Forms.Label nm_fornecedorLabel;
            System.Windows.Forms.Label ds_enderecoLabel;
            System.Windows.Forms.Label cd_numeroLabel;
            System.Windows.Forms.Label nm_bairroLabel;
            System.Windows.Forms.Label nm_cidadeLabel;
            System.Windows.Forms.Label sg_estadoLabel;
            System.Windows.Forms.Label cd_cepLabel;
            System.Windows.Forms.Label cd_cnpjLabel;
            System.Windows.Forms.Label cd_ieLabel;
            System.Windows.Forms.Label cd_telefoneLabel;
            System.Windows.Forms.Label ds_emailLabel;
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
            this.tb_fornecedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_fornecedorTableAdapter = new AtvddBanco.BanquihoDataSetTableAdapters.tb_fornecedorTableAdapter();
            this.tableAdapterManager = new AtvddBanco.BanquihoDataSetTableAdapters.TableAdapterManager();
            this.cd_fornecedorTextBox = new System.Windows.Forms.TextBox();
            this.nm_fornecedorTextBox = new System.Windows.Forms.TextBox();
            this.ds_enderecoTextBox = new System.Windows.Forms.TextBox();
            this.cd_numeroTextBox = new System.Windows.Forms.TextBox();
            this.nm_bairroTextBox = new System.Windows.Forms.TextBox();
            this.nm_cidadeTextBox = new System.Windows.Forms.TextBox();
            this.ds_emailTextBox = new System.Windows.Forms.TextBox();
            this.sg_estadoComboBox = new System.Windows.Forms.ComboBox();
            this.cd_cepMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.cd_cnpjMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.cd_ieMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.cd_telefoneMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.cnpjicon = new System.Windows.Forms.Label();
            cd_fornecedorLabel = new System.Windows.Forms.Label();
            nm_fornecedorLabel = new System.Windows.Forms.Label();
            ds_enderecoLabel = new System.Windows.Forms.Label();
            cd_numeroLabel = new System.Windows.Forms.Label();
            nm_bairroLabel = new System.Windows.Forms.Label();
            nm_cidadeLabel = new System.Windows.Forms.Label();
            sg_estadoLabel = new System.Windows.Forms.Label();
            cd_cepLabel = new System.Windows.Forms.Label();
            cd_cnpjLabel = new System.Windows.Forms.Label();
            cd_ieLabel = new System.Windows.Forms.Label();
            cd_telefoneLabel = new System.Windows.Forms.Label();
            ds_emailLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.banquihoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_fornecedorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cd_fornecedorLabel
            // 
            cd_fornecedorLabel.AutoSize = true;
            cd_fornecedorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            cd_fornecedorLabel.Location = new System.Drawing.Point(276, 34);
            cd_fornecedorLabel.Name = "cd_fornecedorLabel";
            cd_fornecedorLabel.Size = new System.Drawing.Size(76, 24);
            cd_fornecedorLabel.TabIndex = 35;
            cd_fornecedorLabel.Text = "Código:";
            // 
            // nm_fornecedorLabel
            // 
            nm_fornecedorLabel.AutoSize = true;
            nm_fornecedorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            nm_fornecedorLabel.Location = new System.Drawing.Point(13, 79);
            nm_fornecedorLabel.Name = "nm_fornecedorLabel";
            nm_fornecedorLabel.Size = new System.Drawing.Size(115, 24);
            nm_fornecedorLabel.TabIndex = 37;
            nm_fornecedorLabel.Text = "Fornecedor:";
            // 
            // ds_enderecoLabel
            // 
            ds_enderecoLabel.AutoSize = true;
            ds_enderecoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            ds_enderecoLabel.Location = new System.Drawing.Point(12, 169);
            ds_enderecoLabel.Name = "ds_enderecoLabel";
            ds_enderecoLabel.Size = new System.Drawing.Size(49, 24);
            ds_enderecoLabel.TabIndex = 39;
            ds_enderecoLabel.Text = "Rua:";
            // 
            // cd_numeroLabel
            // 
            cd_numeroLabel.AutoSize = true;
            cd_numeroLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            cd_numeroLabel.Location = new System.Drawing.Point(360, 169);
            cd_numeroLabel.Name = "cd_numeroLabel";
            cd_numeroLabel.Size = new System.Drawing.Size(84, 24);
            cd_numeroLabel.TabIndex = 41;
            cd_numeroLabel.Text = "Número:";
            // 
            // nm_bairroLabel
            // 
            nm_bairroLabel.AutoSize = true;
            nm_bairroLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            nm_bairroLabel.Location = new System.Drawing.Point(548, 169);
            nm_bairroLabel.Name = "nm_bairroLabel";
            nm_bairroLabel.Size = new System.Drawing.Size(64, 24);
            nm_bairroLabel.TabIndex = 43;
            nm_bairroLabel.Text = "Bairro:";
            // 
            // nm_cidadeLabel
            // 
            nm_cidadeLabel.AutoSize = true;
            nm_cidadeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            nm_cidadeLabel.Location = new System.Drawing.Point(33, 204);
            nm_cidadeLabel.Name = "nm_cidadeLabel";
            nm_cidadeLabel.Size = new System.Drawing.Size(75, 24);
            nm_cidadeLabel.TabIndex = 45;
            nm_cidadeLabel.Text = "Cidade:";
            // 
            // sg_estadoLabel
            // 
            sg_estadoLabel.AutoSize = true;
            sg_estadoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            sg_estadoLabel.Location = new System.Drawing.Point(320, 204);
            sg_estadoLabel.Name = "sg_estadoLabel";
            sg_estadoLabel.Size = new System.Drawing.Size(73, 24);
            sg_estadoLabel.TabIndex = 47;
            sg_estadoLabel.Text = "Estado:";
            // 
            // cd_cepLabel
            // 
            cd_cepLabel.AutoSize = true;
            cd_cepLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            cd_cepLabel.Location = new System.Drawing.Point(456, 204);
            cd_cepLabel.Name = "cd_cepLabel";
            cd_cepLabel.Size = new System.Drawing.Size(53, 24);
            cd_cepLabel.TabIndex = 49;
            cd_cepLabel.Text = "CEP:";
            // 
            // cd_cnpjLabel
            // 
            cd_cnpjLabel.AutoSize = true;
            cd_cnpjLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            cd_cnpjLabel.Location = new System.Drawing.Point(472, 79);
            cd_cnpjLabel.Name = "cd_cnpjLabel";
            cd_cnpjLabel.Size = new System.Drawing.Size(63, 24);
            cd_cnpjLabel.TabIndex = 51;
            cd_cnpjLabel.Text = "CNPJ:";
            // 
            // cd_ieLabel
            // 
            cd_ieLabel.AutoSize = true;
            cd_ieLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            cd_ieLabel.Location = new System.Drawing.Point(72, 240);
            cd_ieLabel.Name = "cd_ieLabel";
            cd_ieLabel.Size = new System.Drawing.Size(167, 24);
            cd_ieLabel.TabIndex = 53;
            cd_ieLabel.Text = "Inscrição Estadual:";
            // 
            // cd_telefoneLabel
            // 
            cd_telefoneLabel.AutoSize = true;
            cd_telefoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            cd_telefoneLabel.Location = new System.Drawing.Point(370, 115);
            cd_telefoneLabel.Name = "cd_telefoneLabel";
            cd_telefoneLabel.Size = new System.Drawing.Size(90, 24);
            cd_telefoneLabel.TabIndex = 55;
            cd_telefoneLabel.Text = "Telefone:";
            // 
            // ds_emailLabel
            // 
            ds_emailLabel.AutoSize = true;
            ds_emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            ds_emailLabel.Location = new System.Drawing.Point(27, 115);
            ds_emailLabel.Name = "ds_emailLabel";
            ds_emailLabel.Size = new System.Drawing.Size(68, 24);
            ds_emailLabel.TabIndex = 57;
            ds_emailLabel.Text = "E-mail:";
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(599, 362);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(102, 36);
            this.btnSair.TabIndex = 34;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Location = new System.Drawing.Point(476, 362);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(102, 36);
            this.btnImprimir.TabIndex = 33;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Location = new System.Drawing.Point(353, 362);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(102, 36);
            this.btnPesquisar.TabIndex = 32;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(230, 362);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(102, 36);
            this.btnCancelar.TabIndex = 31;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(107, 362);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(102, 36);
            this.btnSalvar.TabIndex = 30;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(599, 303);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(102, 36);
            this.btnExcluir.TabIndex = 29;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.Location = new System.Drawing.Point(476, 303);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(102, 36);
            this.btnAlterar.TabIndex = 28;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Location = new System.Drawing.Point(353, 303);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(102, 36);
            this.btnNovo.TabIndex = 27;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnProximo
            // 
            this.btnProximo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProximo.Location = new System.Drawing.Point(230, 303);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(102, 36);
            this.btnProximo.TabIndex = 26;
            this.btnProximo.Text = "Próximo";
            this.btnProximo.UseVisualStyleBackColor = true;
            this.btnProximo.Click += new System.EventHandler(this.btnProximo_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnterior.Location = new System.Drawing.Point(107, 303);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(102, 36);
            this.btnAnterior.TabIndex = 25;
            this.btnAnterior.Text = "Anterior";
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // banquihoDataSet
            // 
            this.banquihoDataSet.DataSetName = "BanquihoDataSet";
            this.banquihoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tb_fornecedorBindingSource
            // 
            this.tb_fornecedorBindingSource.DataMember = "tb_fornecedor";
            this.tb_fornecedorBindingSource.DataSource = this.banquihoDataSet;
            // 
            // tb_fornecedorTableAdapter
            // 
            this.tb_fornecedorTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tb_clienteTableAdapter = null;
            this.tableAdapterManager.tb_contasPagarTableAdapter = null;
            this.tableAdapterManager.tb_contasReceberTableAdapter = null;
            this.tableAdapterManager.tb_fornecedorTableAdapter = this.tb_fornecedorTableAdapter;
            this.tableAdapterManager.tb_usuarioTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = AtvddBanco.BanquihoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cd_fornecedorTextBox
            // 
            this.cd_fornecedorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_fornecedorBindingSource, "cd_fornecedor", true));
            this.cd_fornecedorTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.cd_fornecedorTextBox.Location = new System.Drawing.Point(358, 31);
            this.cd_fornecedorTextBox.Name = "cd_fornecedorTextBox";
            this.cd_fornecedorTextBox.Size = new System.Drawing.Size(77, 29);
            this.cd_fornecedorTextBox.TabIndex = 36;
            // 
            // nm_fornecedorTextBox
            // 
            this.nm_fornecedorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_fornecedorBindingSource, "nm_fornecedor", true));
            this.nm_fornecedorTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.nm_fornecedorTextBox.Location = new System.Drawing.Point(128, 79);
            this.nm_fornecedorTextBox.MaxLength = 50;
            this.nm_fornecedorTextBox.Name = "nm_fornecedorTextBox";
            this.nm_fornecedorTextBox.Size = new System.Drawing.Size(327, 29);
            this.nm_fornecedorTextBox.TabIndex = 38;
            // 
            // ds_enderecoTextBox
            // 
            this.ds_enderecoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_fornecedorBindingSource, "ds_endereco", true));
            this.ds_enderecoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.ds_enderecoTextBox.Location = new System.Drawing.Point(61, 169);
            this.ds_enderecoTextBox.MaxLength = 40;
            this.ds_enderecoTextBox.Name = "ds_enderecoTextBox";
            this.ds_enderecoTextBox.Size = new System.Drawing.Size(295, 29);
            this.ds_enderecoTextBox.TabIndex = 40;
            // 
            // cd_numeroTextBox
            // 
            this.cd_numeroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_fornecedorBindingSource, "cd_numero", true));
            this.cd_numeroTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.cd_numeroTextBox.Location = new System.Drawing.Point(444, 169);
            this.cd_numeroTextBox.MaxLength = 10;
            this.cd_numeroTextBox.Name = "cd_numeroTextBox";
            this.cd_numeroTextBox.Size = new System.Drawing.Size(100, 29);
            this.cd_numeroTextBox.TabIndex = 42;
            // 
            // nm_bairroTextBox
            // 
            this.nm_bairroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_fornecedorBindingSource, "nm_bairro", true));
            this.nm_bairroTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.nm_bairroTextBox.Location = new System.Drawing.Point(612, 169);
            this.nm_bairroTextBox.MaxLength = 30;
            this.nm_bairroTextBox.Name = "nm_bairroTextBox";
            this.nm_bairroTextBox.Size = new System.Drawing.Size(176, 29);
            this.nm_bairroTextBox.TabIndex = 44;
            // 
            // nm_cidadeTextBox
            // 
            this.nm_cidadeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_fornecedorBindingSource, "nm_cidade", true));
            this.nm_cidadeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.nm_cidadeTextBox.Location = new System.Drawing.Point(109, 204);
            this.nm_cidadeTextBox.MaxLength = 30;
            this.nm_cidadeTextBox.Name = "nm_cidadeTextBox";
            this.nm_cidadeTextBox.Size = new System.Drawing.Size(206, 29);
            this.nm_cidadeTextBox.TabIndex = 46;
            // 
            // ds_emailTextBox
            // 
            this.ds_emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_fornecedorBindingSource, "ds_email", true));
            this.ds_emailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.ds_emailTextBox.Location = new System.Drawing.Point(95, 114);
            this.ds_emailTextBox.MaxLength = 100;
            this.ds_emailTextBox.Name = "ds_emailTextBox";
            this.ds_emailTextBox.Size = new System.Drawing.Size(263, 29);
            this.ds_emailTextBox.TabIndex = 58;
            // 
            // sg_estadoComboBox
            // 
            this.sg_estadoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_fornecedorBindingSource, "sg_estado", true));
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
            "RM",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.sg_estadoComboBox.Location = new System.Drawing.Point(391, 202);
            this.sg_estadoComboBox.Name = "sg_estadoComboBox";
            this.sg_estadoComboBox.Size = new System.Drawing.Size(61, 32);
            this.sg_estadoComboBox.TabIndex = 59;
            // 
            // cd_cepMaskedTextBox
            // 
            this.cd_cepMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_fornecedorBindingSource, "cd_cep", true));
            this.cd_cepMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.cd_cepMaskedTextBox.Location = new System.Drawing.Point(507, 204);
            this.cd_cepMaskedTextBox.Mask = "00000-000";
            this.cd_cepMaskedTextBox.Name = "cd_cepMaskedTextBox";
            this.cd_cepMaskedTextBox.Size = new System.Drawing.Size(94, 29);
            this.cd_cepMaskedTextBox.TabIndex = 60;
            // 
            // cd_cnpjMaskedTextBox
            // 
            this.cd_cnpjMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_fornecedorBindingSource, "cd_cnpj", true));
            this.cd_cnpjMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.cd_cnpjMaskedTextBox.Location = new System.Drawing.Point(535, 79);
            this.cd_cnpjMaskedTextBox.Mask = "00,000,000/0000-00";
            this.cd_cnpjMaskedTextBox.Name = "cd_cnpjMaskedTextBox";
            this.cd_cnpjMaskedTextBox.Size = new System.Drawing.Size(166, 29);
            this.cd_cnpjMaskedTextBox.TabIndex = 61;
            this.cd_cnpjMaskedTextBox.Leave += new System.EventHandler(this.cd_cnpjMaskedTextBox_Leave);
            // 
            // cd_ieMaskedTextBox
            // 
            this.cd_ieMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_fornecedorBindingSource, "cd_ie", true));
            this.cd_ieMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.cd_ieMaskedTextBox.Location = new System.Drawing.Point(237, 240);
            this.cd_ieMaskedTextBox.Mask = "000,000,000,000";
            this.cd_ieMaskedTextBox.Name = "cd_ieMaskedTextBox";
            this.cd_ieMaskedTextBox.Size = new System.Drawing.Size(144, 29);
            this.cd_ieMaskedTextBox.TabIndex = 62;
            // 
            // cd_telefoneMaskedTextBox
            // 
            this.cd_telefoneMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_fornecedorBindingSource, "cd_telefone", true));
            this.cd_telefoneMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.cd_telefoneMaskedTextBox.Location = new System.Drawing.Point(460, 114);
            this.cd_telefoneMaskedTextBox.Mask = "(00) 000000000";
            this.cd_telefoneMaskedTextBox.Name = "cd_telefoneMaskedTextBox";
            this.cd_telefoneMaskedTextBox.Size = new System.Drawing.Size(137, 29);
            this.cd_telefoneMaskedTextBox.TabIndex = 63;
            // 
            // cnpjicon
            // 
            this.cnpjicon.AutoSize = true;
            this.cnpjicon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.cnpjicon.ForeColor = System.Drawing.SystemColors.Control;
            this.cnpjicon.Location = new System.Drawing.Point(587, 56);
            this.cnpjicon.Name = "cnpjicon";
            this.cnpjicon.Size = new System.Drawing.Size(60, 20);
            this.cnpjicon.TabIndex = 64;
            this.cnpjicon.Text = "Válido!";
            // 
            // frmFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 450);
            this.ControlBox = false;
            this.Controls.Add(this.cnpjicon);
            this.Controls.Add(this.cd_telefoneMaskedTextBox);
            this.Controls.Add(this.cd_ieMaskedTextBox);
            this.Controls.Add(this.cd_cnpjMaskedTextBox);
            this.Controls.Add(this.cd_cepMaskedTextBox);
            this.Controls.Add(this.sg_estadoComboBox);
            this.Controls.Add(cd_fornecedorLabel);
            this.Controls.Add(this.cd_fornecedorTextBox);
            this.Controls.Add(nm_fornecedorLabel);
            this.Controls.Add(this.nm_fornecedorTextBox);
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
            this.Controls.Add(cd_cnpjLabel);
            this.Controls.Add(cd_ieLabel);
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
            this.Name = "frmFornecedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Forneçedor";
            this.Load += new System.EventHandler(this.frmFornecedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.banquihoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_fornecedorBindingSource)).EndInit();
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
        private System.Windows.Forms.BindingSource tb_fornecedorBindingSource;
        private BanquihoDataSetTableAdapters.tb_fornecedorTableAdapter tb_fornecedorTableAdapter;
        private BanquihoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox cd_fornecedorTextBox;
        private System.Windows.Forms.TextBox nm_fornecedorTextBox;
        private System.Windows.Forms.TextBox ds_enderecoTextBox;
        private System.Windows.Forms.TextBox cd_numeroTextBox;
        private System.Windows.Forms.TextBox nm_bairroTextBox;
        private System.Windows.Forms.TextBox nm_cidadeTextBox;
        private System.Windows.Forms.TextBox ds_emailTextBox;
        private System.Windows.Forms.ComboBox sg_estadoComboBox;
        private System.Windows.Forms.MaskedTextBox cd_cepMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox cd_cnpjMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox cd_ieMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox cd_telefoneMaskedTextBox;
        private System.Windows.Forms.Label cnpjicon;
    }
}