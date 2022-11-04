namespace TRABALHO_BANCO
{
    partial class Agenda
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
            this.label2 = new System.Windows.Forms.Label();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btInserir = new System.Windows.Forms.Button();
            this.btDeletar = new System.Windows.Forms.Button();
            this.btConsultar = new System.Windows.Forms.Button();
            this.cbPlaca = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txCod = new System.Windows.Forms.TextBox();
            this.rtbDesc = new System.Windows.Forms.RichTextBox();
            this.btAlterar = new System.Windows.Forms.Button();
            this.tRABALHO_BANCODataSet = new TRABALHO_BANCO.TRABALHO_BANCODataSet();
            this.cARROBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cARROTableAdapter = new TRABALHO_BANCO.TRABALHO_BANCODataSetTableAdapters.CARROTableAdapter();
            this.dataTable2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataTable2TableAdapter = new TRABALHO_BANCO.TRABALHO_BANCODataSetTableAdapters.DataTable2TableAdapter();
            this.aGENDACODDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aGENDADESCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aGENDADATADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cARPLACADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mODMODELODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLINOMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRABALHO_BANCODataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cARROBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable2BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Placa do carro:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Data:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dtpData
            // 
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData.Location = new System.Drawing.Point(137, 110);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(121, 20);
            this.dtpData.TabIndex = 3;
            this.dtpData.Value = new System.DateTime(2022, 11, 3, 0, 0, 0, 0);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.aGENDACODDataGridViewTextBoxColumn,
            this.aGENDADESCDataGridViewTextBoxColumn,
            this.aGENDADATADataGridViewTextBoxColumn,
            this.cARPLACADataGridViewTextBoxColumn,
            this.mODMODELODataGridViewTextBoxColumn,
            this.cLINOMEDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dataTable2BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(56, 220);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(667, 218);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btInserir
            // 
            this.btInserir.Location = new System.Drawing.Point(645, 109);
            this.btInserir.Name = "btInserir";
            this.btInserir.Size = new System.Drawing.Size(75, 23);
            this.btInserir.TabIndex = 5;
            this.btInserir.Text = "Inserir";
            this.btInserir.UseVisualStyleBackColor = true;
            this.btInserir.Click += new System.EventHandler(this.btInserir_Click);
            // 
            // btDeletar
            // 
            this.btDeletar.Location = new System.Drawing.Point(645, 153);
            this.btDeletar.Name = "btDeletar";
            this.btDeletar.Size = new System.Drawing.Size(75, 23);
            this.btDeletar.TabIndex = 6;
            this.btDeletar.Text = "Deletar";
            this.btDeletar.UseVisualStyleBackColor = true;
            this.btDeletar.Click += new System.EventHandler(this.btDeletar_Click);
            // 
            // btConsultar
            // 
            this.btConsultar.Location = new System.Drawing.Point(645, 20);
            this.btConsultar.Name = "btConsultar";
            this.btConsultar.Size = new System.Drawing.Size(75, 23);
            this.btConsultar.TabIndex = 7;
            this.btConsultar.Text = "Consultar";
            this.btConsultar.UseVisualStyleBackColor = true;
            this.btConsultar.Click += new System.EventHandler(this.btConsultar_Click);
            // 
            // cbPlaca
            // 
            this.cbPlaca.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.cARROBindingSource, "CAR_PLACA", true));
            this.cbPlaca.DataSource = this.cARROBindingSource;
            this.cbPlaca.DisplayMember = "CAR_PLACA";
            this.cbPlaca.FormattingEnabled = true;
            this.cbPlaca.Location = new System.Drawing.Point(137, 63);
            this.cbPlaca.Name = "cbPlaca";
            this.cbPlaca.Size = new System.Drawing.Size(121, 21);
            this.cbPlaca.TabIndex = 8;
            this.cbPlaca.ValueMember = "CAR_PLACA";
            this.cbPlaca.SelectedIndexChanged += new System.EventHandler(this.cbPlaca_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(340, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Descrição:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Código:";
            // 
            // txCod
            // 
            this.txCod.Location = new System.Drawing.Point(137, 19);
            this.txCod.Name = "txCod";
            this.txCod.Size = new System.Drawing.Size(35, 20);
            this.txCod.TabIndex = 12;
            // 
            // rtbDesc
            // 
            this.rtbDesc.Location = new System.Drawing.Point(404, 19);
            this.rtbDesc.Name = "rtbDesc";
            this.rtbDesc.Size = new System.Drawing.Size(219, 157);
            this.rtbDesc.TabIndex = 13;
            this.rtbDesc.Text = "";
            // 
            // btAlterar
            // 
            this.btAlterar.Location = new System.Drawing.Point(645, 61);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(75, 23);
            this.btAlterar.TabIndex = 14;
            this.btAlterar.Text = "Alterar";
            this.btAlterar.UseVisualStyleBackColor = true;
            this.btAlterar.Click += new System.EventHandler(this.btAlterar_Click);
            // 
            // tRABALHO_BANCODataSet
            // 
            this.tRABALHO_BANCODataSet.DataSetName = "TRABALHO_BANCODataSet";
            this.tRABALHO_BANCODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cARROBindingSource
            // 
            this.cARROBindingSource.DataMember = "CARRO";
            this.cARROBindingSource.DataSource = this.tRABALHO_BANCODataSet;
            // 
            // cARROTableAdapter
            // 
            this.cARROTableAdapter.ClearBeforeFill = true;
            // 
            // dataTable2BindingSource
            // 
            this.dataTable2BindingSource.DataMember = "DataTable2";
            this.dataTable2BindingSource.DataSource = this.tRABALHO_BANCODataSet;
            // 
            // dataTable2TableAdapter
            // 
            this.dataTable2TableAdapter.ClearBeforeFill = true;
            // 
            // aGENDACODDataGridViewTextBoxColumn
            // 
            this.aGENDACODDataGridViewTextBoxColumn.DataPropertyName = "AGENDA_COD";
            this.aGENDACODDataGridViewTextBoxColumn.HeaderText = "AGENDA_COD";
            this.aGENDACODDataGridViewTextBoxColumn.Name = "aGENDACODDataGridViewTextBoxColumn";
            this.aGENDACODDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aGENDADESCDataGridViewTextBoxColumn
            // 
            this.aGENDADESCDataGridViewTextBoxColumn.DataPropertyName = "AGENDA_DESC";
            this.aGENDADESCDataGridViewTextBoxColumn.HeaderText = "AGENDA_DESC";
            this.aGENDADESCDataGridViewTextBoxColumn.Name = "aGENDADESCDataGridViewTextBoxColumn";
            // 
            // aGENDADATADataGridViewTextBoxColumn
            // 
            this.aGENDADATADataGridViewTextBoxColumn.DataPropertyName = "AGENDA_DATA";
            this.aGENDADATADataGridViewTextBoxColumn.HeaderText = "AGENDA_DATA";
            this.aGENDADATADataGridViewTextBoxColumn.Name = "aGENDADATADataGridViewTextBoxColumn";
            // 
            // cARPLACADataGridViewTextBoxColumn
            // 
            this.cARPLACADataGridViewTextBoxColumn.DataPropertyName = "CAR_PLACA";
            this.cARPLACADataGridViewTextBoxColumn.HeaderText = "CAR_PLACA";
            this.cARPLACADataGridViewTextBoxColumn.Name = "cARPLACADataGridViewTextBoxColumn";
            // 
            // mODMODELODataGridViewTextBoxColumn
            // 
            this.mODMODELODataGridViewTextBoxColumn.DataPropertyName = "MOD_MODELO";
            this.mODMODELODataGridViewTextBoxColumn.HeaderText = "MOD_MODELO";
            this.mODMODELODataGridViewTextBoxColumn.Name = "mODMODELODataGridViewTextBoxColumn";
            // 
            // cLINOMEDataGridViewTextBoxColumn
            // 
            this.cLINOMEDataGridViewTextBoxColumn.DataPropertyName = "CLI_NOME";
            this.cLINOMEDataGridViewTextBoxColumn.HeaderText = "CLI_NOME";
            this.cLINOMEDataGridViewTextBoxColumn.Name = "cLINOMEDataGridViewTextBoxColumn";
            // 
            // Agenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btAlterar);
            this.Controls.Add(this.rtbDesc);
            this.Controls.Add(this.txCod);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbPlaca);
            this.Controls.Add(this.btConsultar);
            this.Controls.Add(this.btDeletar);
            this.Controls.Add(this.btInserir);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dtpData);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Agenda";
            this.Text = "Agenda";
            this.Load += new System.EventHandler(this.Agenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRABALHO_BANCODataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cARROBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable2BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btInserir;
        private System.Windows.Forms.Button btDeletar;
        private System.Windows.Forms.Button btConsultar;
        private System.Windows.Forms.ComboBox cbPlaca;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txCod;
        private System.Windows.Forms.RichTextBox rtbDesc;
        private System.Windows.Forms.Button btAlterar;
        private TRABALHO_BANCODataSet tRABALHO_BANCODataSet;
        private System.Windows.Forms.BindingSource cARROBindingSource;
        private TRABALHO_BANCODataSetTableAdapters.CARROTableAdapter cARROTableAdapter;
        private System.Windows.Forms.BindingSource dataTable2BindingSource;
        private TRABALHO_BANCODataSetTableAdapters.DataTable2TableAdapter dataTable2TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn aGENDACODDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aGENDADESCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aGENDADATADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cARPLACADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mODMODELODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLINOMEDataGridViewTextBoxColumn;
    }
}