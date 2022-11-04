namespace TRABALHO_BANCO
{
    partial class Carro
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
            this.txPlaca = new System.Windows.Forms.TextBox();
            this.txAnoFabric = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btConsultar = new System.Windows.Forms.Button();
            this.btInserir = new System.Windows.Forms.Button();
            this.btAlterar = new System.Windows.Forms.Button();
            this.btDeletar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cbMarca = new System.Windows.Forms.ComboBox();
            this.cbModelo = new System.Windows.Forms.ComboBox();
            this.cbCliente = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tRABALHO_BANCODataSet = new TRABALHO_BANCO.TRABALHO_BANCODataSet();
            this.cLIENTEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cLIENTETableAdapter = new TRABALHO_BANCO.TRABALHO_BANCODataSetTableAdapters.CLIENTETableAdapter();
            this.mODELOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mODELOTableAdapter = new TRABALHO_BANCO.TRABALHO_BANCODataSetTableAdapters.MODELOTableAdapter();
            this.dataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataTable1TableAdapter = new TRABALHO_BANCO.TRABALHO_BANCODataSetTableAdapters.DataTable1TableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mODMODELODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLINOMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mODMARCADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRABALHO_BANCODataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mODELOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Placa do carro:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ano de Fabricação:";
            // 
            // txPlaca
            // 
            this.txPlaca.Location = new System.Drawing.Point(121, 67);
            this.txPlaca.Name = "txPlaca";
            this.txPlaca.Size = new System.Drawing.Size(126, 20);
            this.txPlaca.TabIndex = 2;
            // 
            // txAnoFabric
            // 
            this.txAnoFabric.Location = new System.Drawing.Point(142, 111);
            this.txAnoFabric.Name = "txAnoFabric";
            this.txAnoFabric.Size = new System.Drawing.Size(105, 20);
            this.txAnoFabric.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Marca:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Modelo:";
            // 
            // btConsultar
            // 
            this.btConsultar.Location = new System.Drawing.Point(292, 24);
            this.btConsultar.Name = "btConsultar";
            this.btConsultar.Size = new System.Drawing.Size(75, 23);
            this.btConsultar.TabIndex = 9;
            this.btConsultar.Text = "Consultar";
            this.btConsultar.UseVisualStyleBackColor = true;
            this.btConsultar.Click += new System.EventHandler(this.btConsultar_Click);
            // 
            // btInserir
            // 
            this.btInserir.Location = new System.Drawing.Point(292, 109);
            this.btInserir.Name = "btInserir";
            this.btInserir.Size = new System.Drawing.Size(75, 23);
            this.btInserir.TabIndex = 10;
            this.btInserir.Text = "Inserir";
            this.btInserir.UseVisualStyleBackColor = true;
            this.btInserir.Click += new System.EventHandler(this.btInserir_Click);
            // 
            // btAlterar
            // 
            this.btAlterar.Location = new System.Drawing.Point(292, 67);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(75, 23);
            this.btAlterar.TabIndex = 11;
            this.btAlterar.Text = "Alterar";
            this.btAlterar.UseVisualStyleBackColor = true;
            this.btAlterar.Click += new System.EventHandler(this.btAlterar_Click);
            // 
            // btDeletar
            // 
            this.btDeletar.Location = new System.Drawing.Point(292, 152);
            this.btDeletar.Name = "btDeletar";
            this.btDeletar.Size = new System.Drawing.Size(75, 23);
            this.btDeletar.TabIndex = 12;
            this.btDeletar.Text = "Deletar";
            this.btDeletar.UseVisualStyleBackColor = true;
            this.btDeletar.Click += new System.EventHandler(this.btDeletar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Cliente:";
            // 
            // cbMarca
            // 
            this.cbMarca.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.mODELOBindingSource, "MOD_COD", true));
            this.cbMarca.DataSource = this.mODELOBindingSource;
            this.cbMarca.DisplayMember = "MOD_MARCA";
            this.cbMarca.FormattingEnabled = true;
            this.cbMarca.Location = new System.Drawing.Point(82, 159);
            this.cbMarca.Name = "cbMarca";
            this.cbMarca.Size = new System.Drawing.Size(165, 21);
            this.cbMarca.TabIndex = 14;
            this.cbMarca.ValueMember = "MOD_COD";
            // 
            // cbModelo
            // 
            this.cbModelo.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.mODELOBindingSource, "MOD_COD", true));
            this.cbModelo.DataSource = this.mODELOBindingSource;
            this.cbModelo.DisplayMember = "MOD_MODELO";
            this.cbModelo.FormattingEnabled = true;
            this.cbModelo.Location = new System.Drawing.Point(90, 213);
            this.cbModelo.Name = "cbModelo";
            this.cbModelo.Size = new System.Drawing.Size(157, 21);
            this.cbModelo.TabIndex = 15;
            this.cbModelo.ValueMember = "MOD_COD";
            // 
            // cbCliente
            // 
            this.cbCliente.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.cLIENTEBindingSource, "CLI_ID", true));
            this.cbCliente.DataSource = this.cLIENTEBindingSource;
            this.cbCliente.DisplayMember = "CLI_NOME";
            this.cbCliente.FormattingEnabled = true;
            this.cbCliente.Location = new System.Drawing.Point(121, 16);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(126, 21);
            this.cbCliente.TabIndex = 16;
            this.cbCliente.ValueMember = "CLI_ID";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.mODMODELODataGridViewTextBoxColumn,
            this.cLINOMEDataGridViewTextBoxColumn,
            this.mODMARCADataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dataTable1BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(39, 272);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(732, 150);
            this.dataGridView1.TabIndex = 17;
            // 
            // tRABALHO_BANCODataSet
            // 
            this.tRABALHO_BANCODataSet.DataSetName = "TRABALHO_BANCODataSet";
            this.tRABALHO_BANCODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // mODELOBindingSource
            // 
            this.mODELOBindingSource.DataMember = "MODELO";
            this.mODELOBindingSource.DataSource = this.tRABALHO_BANCODataSet;
            // 
            // mODELOTableAdapter
            // 
            this.mODELOTableAdapter.ClearBeforeFill = true;
            // 
            // dataTable1BindingSource
            // 
            this.dataTable1BindingSource.DataMember = "DataTable1";
            this.dataTable1BindingSource.DataSource = this.tRABALHO_BANCODataSet;
            // 
            // dataTable1TableAdapter
            // 
            this.dataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CAR_PLACA";
            this.dataGridViewTextBoxColumn1.HeaderText = "CAR_PLACA";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CAR_ANOFABRIC";
            this.dataGridViewTextBoxColumn2.HeaderText = "CAR_ANOFABRIC";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
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
            // mODMARCADataGridViewTextBoxColumn
            // 
            this.mODMARCADataGridViewTextBoxColumn.DataPropertyName = "MOD_MARCA";
            this.mODMARCADataGridViewTextBoxColumn.HeaderText = "MOD_MARCA";
            this.mODMARCADataGridViewTextBoxColumn.Name = "mODMARCADataGridViewTextBoxColumn";
            // 
            // Carro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cbCliente);
            this.Controls.Add(this.cbModelo);
            this.Controls.Add(this.cbMarca);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btDeletar);
            this.Controls.Add(this.btAlterar);
            this.Controls.Add(this.btInserir);
            this.Controls.Add(this.btConsultar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txAnoFabric);
            this.Controls.Add(this.txPlaca);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Carro";
            this.Text = "Carro";
            this.Load += new System.EventHandler(this.Carro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRABALHO_BANCODataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mODELOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txPlaca;
        private System.Windows.Forms.TextBox txAnoFabric;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private TRABALHO_BANCODataSetTableAdapters.CARROTableAdapter cARROTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cARCLIIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cARPLACADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cARANOFABRICDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cARMODCODDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btConsultar;
        private System.Windows.Forms.Button btInserir;
        private System.Windows.Forms.Button btAlterar;
        private System.Windows.Forms.Button btDeletar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbMarca;
        private System.Windows.Forms.ComboBox cbModelo;
        private System.Windows.Forms.ComboBox cbCliente;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mARCMARCADataGridViewTextBoxColumn;
        private TRABALHO_BANCODataSet tRABALHO_BANCODataSet;
        private System.Windows.Forms.BindingSource cLIENTEBindingSource;
        private TRABALHO_BANCODataSetTableAdapters.CLIENTETableAdapter cLIENTETableAdapter;
        private System.Windows.Forms.BindingSource mODELOBindingSource;
        private TRABALHO_BANCODataSetTableAdapters.MODELOTableAdapter mODELOTableAdapter;
        private System.Windows.Forms.BindingSource dataTable1BindingSource;
        private TRABALHO_BANCODataSetTableAdapters.DataTable1TableAdapter dataTable1TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn mODMODELODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLINOMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mODMARCADataGridViewTextBoxColumn;
    }
}