namespace AtvddBanco
{
    partial class frmPesquisaContasReceber
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cd_data = new System.Windows.Forms.DateTimePicker();
            this.btnSair = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.banquihoDataSet = new AtvddBanco.BanquihoDataSet();
            this.tb_contasReceberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_contasReceberTableAdapter = new AtvddBanco.BanquihoDataSetTableAdapters.tb_contasReceberTableAdapter();
            this.tableAdapterManager = new AtvddBanco.BanquihoDataSetTableAdapters.TableAdapterManager();
            this.tb_contasReceberDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.banquihoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_contasReceberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_contasReceberDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // cd_data
            // 
            this.cd_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.cd_data.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.cd_data.Location = new System.Drawing.Point(227, 46);
            this.cd_data.Name = "cd_data";
            this.cd_data.Size = new System.Drawing.Size(128, 29);
            this.cd_data.TabIndex = 63;
            this.cd_data.ValueChanged += new System.EventHandler(this.cd_data_ValueChanged);
            // 
            // btnSair
            // 
            this.btnSair.AutoSize = true;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnSair.Location = new System.Drawing.Point(333, 371);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(103, 34);
            this.btnSair.TabIndex = 61;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label1.Location = new System.Drawing.Point(113, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 24);
            this.label1.TabIndex = 60;
            this.label1.Text = "Vencimento:";
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
            // tb_contasReceberDataGridView
            // 
            this.tb_contasReceberDataGridView.AllowUserToAddRows = false;
            this.tb_contasReceberDataGridView.AllowUserToDeleteRows = false;
            this.tb_contasReceberDataGridView.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tb_contasReceberDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tb_contasReceberDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tb_contasReceberDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn2});
            this.tb_contasReceberDataGridView.DataSource = this.tb_contasReceberBindingSource;
            this.tb_contasReceberDataGridView.Location = new System.Drawing.Point(117, 91);
            this.tb_contasReceberDataGridView.Name = "tb_contasReceberDataGridView";
            this.tb_contasReceberDataGridView.ReadOnly = true;
            this.tb_contasReceberDataGridView.Size = new System.Drawing.Size(585, 247);
            this.tb_contasReceberDataGridView.TabIndex = 64;
            this.tb_contasReceberDataGridView.DoubleClick += new System.EventHandler(this.tb_contasReceberDataGridView_DoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "cd_conta";
            this.dataGridViewTextBoxColumn1.HeaderText = "Código";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 80;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "dt_vencimento";
            this.dataGridViewTextBoxColumn5.HeaderText = "Vencimento";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "dt_emissao";
            this.dataGridViewTextBoxColumn4.HeaderText = "Emissão";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "cd_documento";
            this.dataGridViewTextBoxColumn2.HeaderText = "Documento";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 140;
            // 
            // frmPesquisaContasReceber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.tb_contasReceberDataGridView);
            this.Controls.Add(this.cd_data);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.label1);
            this.Name = "frmPesquisaContasReceber";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisar contas a Receber";
            this.Load += new System.EventHandler(this.frmPesquisaContasReceber_Load);
            ((System.ComponentModel.ISupportInitialize)(this.banquihoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_contasReceberBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_contasReceberDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker cd_data;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label label1;
        private BanquihoDataSet banquihoDataSet;
        private System.Windows.Forms.BindingSource tb_contasReceberBindingSource;
        private BanquihoDataSetTableAdapters.tb_contasReceberTableAdapter tb_contasReceberTableAdapter;
        private BanquihoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView tb_contasReceberDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}