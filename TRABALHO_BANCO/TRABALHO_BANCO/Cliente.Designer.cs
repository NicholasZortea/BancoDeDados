namespace TRABALHO_BANCO
{
    partial class Cliente
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
            this.label1 = new System.Windows.Forms.Label();
            this.txName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mtxTelefone = new System.Windows.Forms.MaskedTextBox();
            this.mtxCPF = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txEmail = new System.Windows.Forms.TextBox();
            this.btInserir = new System.Windows.Forms.Button();
            this.btAlterar = new System.Windows.Forms.Button();
            this.btDeletar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tRABALHO_BANCODataSet = new TRABALHO_BANCO.TRABALHO_BANCODataSet();
            this.label5 = new System.Windows.Forms.Label();
            this.txId = new System.Windows.Forms.TextBox();
            this.btConsultar = new System.Windows.Forms.Button();
            this.cLIENTEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cLIENTETableAdapter = new TRABALHO_BANCO.TRABALHO_BANCODataSetTableAdapters.CLIENTETableAdapter();
            this.cLIIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLINOMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLICPFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLITELEFONEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLIEMAILDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLICIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLIRUADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLIBAIRRODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRABALHO_BANCODataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTEBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txName
            // 
            this.txName.Location = new System.Drawing.Point(68, 53);
            this.txName.Name = "txName";
            this.txName.Size = new System.Drawing.Size(111, 20);
            this.txName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "CPF:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Telefone:";
            // 
            // mtxTelefone
            // 
            this.mtxTelefone.Location = new System.Drawing.Point(79, 92);
            this.mtxTelefone.Mask = "(00) 00000-0000";
            this.mtxTelefone.Name = "mtxTelefone";
            this.mtxTelefone.Size = new System.Drawing.Size(100, 20);
            this.mtxTelefone.TabIndex = 4;
            // 
            // mtxCPF
            // 
            this.mtxCPF.Location = new System.Drawing.Point(68, 132);
            this.mtxCPF.Mask = "000,000,000-00";
            this.mtxCPF.Name = "mtxCPF";
            this.mtxCPF.Size = new System.Drawing.Size(111, 20);
            this.mtxCPF.TabIndex = 5;
            this.mtxCPF.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtxCPF_MaskInputRejected);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Email:";
            // 
            // txEmail
            // 
            this.txEmail.Location = new System.Drawing.Point(79, 172);
            this.txEmail.Name = "txEmail";
            this.txEmail.Size = new System.Drawing.Size(100, 20);
            this.txEmail.TabIndex = 7;
            // 
            // btInserir
            // 
            this.btInserir.Location = new System.Drawing.Point(214, 107);
            this.btInserir.Name = "btInserir";
            this.btInserir.Size = new System.Drawing.Size(75, 35);
            this.btInserir.TabIndex = 8;
            this.btInserir.Text = "Inserir";
            this.btInserir.UseVisualStyleBackColor = true;
            this.btInserir.Click += new System.EventHandler(this.btInserir_Click);
            // 
            // btAlterar
            // 
            this.btAlterar.Location = new System.Drawing.Point(214, 53);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(75, 32);
            this.btAlterar.TabIndex = 9;
            this.btAlterar.Text = "Alterar";
            this.btAlterar.UseVisualStyleBackColor = true;
            this.btAlterar.Click += new System.EventHandler(this.btAlterar_Click);
            // 
            // btDeletar
            // 
            this.btDeletar.Location = new System.Drawing.Point(214, 157);
            this.btDeletar.Name = "btDeletar";
            this.btDeletar.Size = new System.Drawing.Size(75, 35);
            this.btDeletar.TabIndex = 10;
            this.btDeletar.Text = "Deletar";
            this.btDeletar.UseVisualStyleBackColor = true;
            this.btDeletar.Click += new System.EventHandler(this.btDeletar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cLIIDDataGridViewTextBoxColumn,
            this.cLINOMEDataGridViewTextBoxColumn,
            this.cLICPFDataGridViewTextBoxColumn,
            this.cLITELEFONEDataGridViewTextBoxColumn,
            this.cLIEMAILDataGridViewTextBoxColumn,
            this.cLICIDDataGridViewTextBoxColumn,
            this.cLIRUADataGridViewTextBoxColumn,
            this.cLIBAIRRODataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cLIENTEBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(30, 214);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(740, 201);
            this.dataGridView1.TabIndex = 12;
            // 
            // tRABALHO_BANCODataSet
            // 
            this.tRABALHO_BANCODataSet.DataSetName = "TRABALHO_BANCODataSet";
            this.tRABALHO_BANCODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(105, 15);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Id:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txId
            // 
            this.txId.Location = new System.Drawing.Point(140, 15);
            this.txId.Margin = new System.Windows.Forms.Padding(2);
            this.txId.Name = "txId";
            this.txId.Size = new System.Drawing.Size(39, 20);
            this.txId.TabIndex = 14;
            // 
            // btConsultar
            // 
            this.btConsultar.Location = new System.Drawing.Point(215, 15);
            this.btConsultar.Margin = new System.Windows.Forms.Padding(2);
            this.btConsultar.Name = "btConsultar";
            this.btConsultar.Size = new System.Drawing.Size(74, 19);
            this.btConsultar.TabIndex = 15;
            this.btConsultar.Text = "Consultar";
            this.btConsultar.UseVisualStyleBackColor = true;
            this.btConsultar.Click += new System.EventHandler(this.btConsultar_Click);
            // 
            // cLIENTEBindingSource
            // 
            this.cLIENTEBindingSource.DataMember = "CLIENTE";
            this.cLIENTEBindingSource.DataSource = this.tRABALHO_BANCODataSet;
            // 
            // cLIENTETableAdapter
            // 
            this.cLIENTETableAdapter.ClearBeforeFill = true;
            // 
            // cLIIDDataGridViewTextBoxColumn
            // 
            this.cLIIDDataGridViewTextBoxColumn.DataPropertyName = "CLI_ID";
            this.cLIIDDataGridViewTextBoxColumn.HeaderText = "CLI_ID";
            this.cLIIDDataGridViewTextBoxColumn.Name = "cLIIDDataGridViewTextBoxColumn";
            this.cLIIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cLINOMEDataGridViewTextBoxColumn
            // 
            this.cLINOMEDataGridViewTextBoxColumn.DataPropertyName = "CLI_NOME";
            this.cLINOMEDataGridViewTextBoxColumn.HeaderText = "CLI_NOME";
            this.cLINOMEDataGridViewTextBoxColumn.Name = "cLINOMEDataGridViewTextBoxColumn";
            // 
            // cLICPFDataGridViewTextBoxColumn
            // 
            this.cLICPFDataGridViewTextBoxColumn.DataPropertyName = "CLI_CPF";
            this.cLICPFDataGridViewTextBoxColumn.HeaderText = "CLI_CPF";
            this.cLICPFDataGridViewTextBoxColumn.Name = "cLICPFDataGridViewTextBoxColumn";
            // 
            // cLITELEFONEDataGridViewTextBoxColumn
            // 
            this.cLITELEFONEDataGridViewTextBoxColumn.DataPropertyName = "CLI_TELEFONE";
            this.cLITELEFONEDataGridViewTextBoxColumn.HeaderText = "CLI_TELEFONE";
            this.cLITELEFONEDataGridViewTextBoxColumn.Name = "cLITELEFONEDataGridViewTextBoxColumn";
            // 
            // cLIEMAILDataGridViewTextBoxColumn
            // 
            this.cLIEMAILDataGridViewTextBoxColumn.DataPropertyName = "CLI_EMAIL";
            this.cLIEMAILDataGridViewTextBoxColumn.HeaderText = "CLI_EMAIL";
            this.cLIEMAILDataGridViewTextBoxColumn.Name = "cLIEMAILDataGridViewTextBoxColumn";
            // 
            // cLICIDDataGridViewTextBoxColumn
            // 
            this.cLICIDDataGridViewTextBoxColumn.DataPropertyName = "CLI_CID";
            this.cLICIDDataGridViewTextBoxColumn.HeaderText = "CLI_CID";
            this.cLICIDDataGridViewTextBoxColumn.Name = "cLICIDDataGridViewTextBoxColumn";
            // 
            // cLIRUADataGridViewTextBoxColumn
            // 
            this.cLIRUADataGridViewTextBoxColumn.DataPropertyName = "CLI_RUA";
            this.cLIRUADataGridViewTextBoxColumn.HeaderText = "CLI_RUA";
            this.cLIRUADataGridViewTextBoxColumn.Name = "cLIRUADataGridViewTextBoxColumn";
            // 
            // cLIBAIRRODataGridViewTextBoxColumn
            // 
            this.cLIBAIRRODataGridViewTextBoxColumn.DataPropertyName = "CLI_BAIRRO";
            this.cLIBAIRRODataGridViewTextBoxColumn.HeaderText = "CLI_BAIRRO";
            this.cLIBAIRRODataGridViewTextBoxColumn.Name = "cLIBAIRRODataGridViewTextBoxColumn";
            // 
            // Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btConsultar);
            this.Controls.Add(this.txId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btDeletar);
            this.Controls.Add(this.btAlterar);
            this.Controls.Add(this.btInserir);
            this.Controls.Add(this.txEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.mtxCPF);
            this.Controls.Add(this.mtxTelefone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txName);
            this.Controls.Add(this.label1);
            this.Name = "Cliente";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRABALHO_BANCODataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTEBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mtxTelefone;
        private System.Windows.Forms.MaskedTextBox mtxCPF;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txEmail;
        private System.Windows.Forms.Button btInserir;
        private System.Windows.Forms.Button btAlterar;
        private System.Windows.Forms.Button btDeletar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private TRABALHO_BANCODataSet tRABALHO_BANCODataSet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txId;
        private System.Windows.Forms.Button btConsultar;
        private System.Windows.Forms.BindingSource cLIENTEBindingSource;
        private TRABALHO_BANCODataSetTableAdapters.CLIENTETableAdapter cLIENTETableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLIIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLINOMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLICPFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLITELEFONEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLIEMAILDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLICIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLIRUADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLIBAIRRODataGridViewTextBoxColumn;
    }
}

