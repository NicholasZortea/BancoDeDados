namespace TRABALHO_BANCO
{
    partial class Index
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
            this.btCliente = new System.Windows.Forms.Button();
            this.btCarro = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btCliente
            // 
            this.btCliente.Location = new System.Drawing.Point(310, 120);
            this.btCliente.Name = "btCliente";
            this.btCliente.Size = new System.Drawing.Size(131, 23);
            this.btCliente.TabIndex = 0;
            this.btCliente.Text = "Cadastro de clientes";
            this.btCliente.UseVisualStyleBackColor = true;
            // 
            // btCarro
            // 
            this.btCarro.Location = new System.Drawing.Point(310, 174);
            this.btCarro.Name = "btCarro";
            this.btCarro.Size = new System.Drawing.Size(131, 23);
            this.btCarro.TabIndex = 1;
            this.btCarro.Text = "Cadastro de carros";
            this.btCarro.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(339, 248);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(336, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Selecione";
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btCarro);
            this.Controls.Add(this.btCliente);
            this.Name = "Index";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCliente;
        private System.Windows.Forms.Button btCarro;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
    }
}