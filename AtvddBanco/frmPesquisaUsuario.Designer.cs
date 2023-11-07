namespace AtvddBanco
{
    partial class frmPesquisaUsuario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.tb_usuarioDataGridView = new System.Windows.Forms.DataGridView();
            this.tb_usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.banquihoDataSet = new AtvddBanco.BanquihoDataSet();
            this.btnSair = new System.Windows.Forms.Button();
            this.tb_usuarioTableAdapter = new AtvddBanco.BanquihoDataSetTableAdapters.tb_usuarioTableAdapter();
            this.tableAdapterManager = new AtvddBanco.BanquihoDataSetTableAdapters.TableAdapterManager();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tb_usuarioDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_usuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.banquihoDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label1.Location = new System.Drawing.Point(129, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtNome.Location = new System.Drawing.Point(197, 55);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(395, 29);
            this.txtNome.TabIndex = 2;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // tb_usuarioDataGridView
            // 
            this.tb_usuarioDataGridView.AllowUserToAddRows = false;
            this.tb_usuarioDataGridView.AllowUserToDeleteRows = false;
            this.tb_usuarioDataGridView.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tb_usuarioDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tb_usuarioDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tb_usuarioDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.tb_usuarioDataGridView.DataSource = this.tb_usuarioBindingSource;
            this.tb_usuarioDataGridView.Location = new System.Drawing.Point(133, 102);
            this.tb_usuarioDataGridView.Name = "tb_usuarioDataGridView";
            this.tb_usuarioDataGridView.ReadOnly = true;
            this.tb_usuarioDataGridView.Size = new System.Drawing.Size(510, 230);
            this.tb_usuarioDataGridView.TabIndex = 4;
            this.tb_usuarioDataGridView.DoubleClick += new System.EventHandler(this.tb_usuarioDataGridView_DoubleClick);
            // 
            // tb_usuarioBindingSource
            // 
            this.tb_usuarioBindingSource.DataMember = "tb_usuario";
            this.tb_usuarioBindingSource.DataSource = this.banquihoDataSet;
            // 
            // banquihoDataSet
            // 
            this.banquihoDataSet.DataSetName = "BanquihoDataSet";
            this.banquihoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnSair
            // 
            this.btnSair.AutoSize = true;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnSair.Location = new System.Drawing.Point(339, 372);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(103, 34);
            this.btnSair.TabIndex = 5;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // tb_usuarioTableAdapter
            // 
            this.tb_usuarioTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tb_clienteTableAdapter = null;
            this.tableAdapterManager.tb_contasPagarTableAdapter = null;
            this.tableAdapterManager.tb_contasReceberTableAdapter = null;
            this.tableAdapterManager.tb_fornecedorTableAdapter = null;
            this.tableAdapterManager.tb_usuarioTableAdapter = this.tb_usuarioTableAdapter;
            this.tableAdapterManager.UpdateOrder = AtvddBanco.BanquihoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "cd_usuario";
            this.dataGridViewTextBoxColumn1.HeaderText = "Código";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nm_usuario";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 350;
            // 
            // frmPesquisaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.tb_usuarioDataGridView);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Name = "frmPesquisaUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisar Usuário";
            this.Load += new System.EventHandler(this.frmPesquisaUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tb_usuarioDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_usuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.banquihoDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private BanquihoDataSet banquihoDataSet;
        private System.Windows.Forms.BindingSource tb_usuarioBindingSource;
        private BanquihoDataSetTableAdapters.tb_usuarioTableAdapter tb_usuarioTableAdapter;
        private BanquihoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView tb_usuarioDataGridView;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}