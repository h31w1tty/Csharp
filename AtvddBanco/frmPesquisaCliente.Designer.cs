namespace AtvddBanco
{
    partial class frmPesquisaCliente
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
            this.btnSair = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.banquihoDataSet = new AtvddBanco.BanquihoDataSet();
            this.tb_clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_clienteTableAdapter = new AtvddBanco.BanquihoDataSetTableAdapters.tb_clienteTableAdapter();
            this.tableAdapterManager = new AtvddBanco.BanquihoDataSetTableAdapters.TableAdapterManager();
            this.tb_clienteDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.banquihoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_clienteDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.AutoSize = true;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnSair.Location = new System.Drawing.Point(353, 367);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(103, 34);
            this.btnSair.TabIndex = 9;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtNome.Location = new System.Drawing.Point(231, 40);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(395, 29);
            this.txtNome.TabIndex = 7;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label1.Location = new System.Drawing.Point(147, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nome";
            // 
            // banquihoDataSet
            // 
            this.banquihoDataSet.DataSetName = "BanquihoDataSet";
            this.banquihoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tb_clienteBindingSource
            // 
            this.tb_clienteBindingSource.DataMember = "tb_cliente";
            this.tb_clienteBindingSource.DataSource = this.banquihoDataSet;
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
            // tb_clienteDataGridView
            // 
            this.tb_clienteDataGridView.AllowUserToAddRows = false;
            this.tb_clienteDataGridView.AllowUserToDeleteRows = false;
            this.tb_clienteDataGridView.AutoGenerateColumns = false;
            this.tb_clienteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tb_clienteDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.tb_clienteDataGridView.DataSource = this.tb_clienteBindingSource;
            this.tb_clienteDataGridView.Location = new System.Drawing.Point(151, 91);
            this.tb_clienteDataGridView.Name = "tb_clienteDataGridView";
            this.tb_clienteDataGridView.ReadOnly = true;
            this.tb_clienteDataGridView.Size = new System.Drawing.Size(542, 228);
            this.tb_clienteDataGridView.TabIndex = 10;
            this.tb_clienteDataGridView.DoubleClick += new System.EventHandler(this.tb_clienteDataGridView_DoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "cd_cliente";
            this.dataGridViewTextBoxColumn1.HeaderText = "cd_cliente";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 80;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nm_cliente";
            this.dataGridViewTextBoxColumn2.HeaderText = "nm_cliente";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 400;
            // 
            // frmPesquisaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.tb_clienteDataGridView);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Name = "frmPesquisaCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisar Cliente";
            this.Load += new System.EventHandler(this.frmPesquisaCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.banquihoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_clienteDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private BanquihoDataSet banquihoDataSet;
        private System.Windows.Forms.BindingSource tb_clienteBindingSource;
        private BanquihoDataSetTableAdapters.tb_clienteTableAdapter tb_clienteTableAdapter;
        private BanquihoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView tb_clienteDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}