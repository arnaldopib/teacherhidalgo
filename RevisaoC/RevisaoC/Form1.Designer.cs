namespace RevisaoC
{
    partial class frmPrinc
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
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblSobrenome = new System.Windows.Forms.Label();
            this.txtSobrenome = new System.Windows.Forms.TextBox();
            this.btnConcatena = new System.Windows.Forms.Button();
            this.lblCompleto = new System.Windows.Forms.Label();
            this.txtCompleto = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(26, 47);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(75, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Primeiro Nome";
            // 
            // txtNome
            // 
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNome.Location = new System.Drawing.Point(143, 44);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 1;
            // 
            // lblSobrenome
            // 
            this.lblSobrenome.AutoSize = true;
            this.lblSobrenome.Location = new System.Drawing.Point(26, 96);
            this.lblSobrenome.Name = "lblSobrenome";
            this.lblSobrenome.Size = new System.Drawing.Size(61, 13);
            this.lblSobrenome.TabIndex = 2;
            this.lblSobrenome.Text = "Sobrenome";
            // 
            // txtSobrenome
            // 
            this.txtSobrenome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSobrenome.Location = new System.Drawing.Point(143, 93);
            this.txtSobrenome.Name = "txtSobrenome";
            this.txtSobrenome.Size = new System.Drawing.Size(100, 20);
            this.txtSobrenome.TabIndex = 3;
            // 
            // btnConcatena
            // 
            this.btnConcatena.FlatAppearance.BorderSize = 0;
            this.btnConcatena.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConcatena.Location = new System.Drawing.Point(290, 37);
            this.btnConcatena.Name = "btnConcatena";
            this.btnConcatena.Size = new System.Drawing.Size(75, 23);
            this.btnConcatena.TabIndex = 4;
            this.btnConcatena.Text = "Concatenar";
            this.btnConcatena.UseVisualStyleBackColor = true;
            this.btnConcatena.Click += new System.EventHandler(this.btnConcatena_Click);
            // 
            // lblCompleto
            // 
            this.lblCompleto.AutoSize = true;
            this.lblCompleto.Location = new System.Drawing.Point(26, 150);
            this.lblCompleto.Name = "lblCompleto";
            this.lblCompleto.Size = new System.Drawing.Size(101, 13);
            this.lblCompleto.TabIndex = 5;
            this.lblCompleto.Text = "Nome concatenado";
            // 
            // txtCompleto
            // 
            this.txtCompleto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCompleto.Enabled = false;
            this.txtCompleto.Location = new System.Drawing.Point(143, 142);
            this.txtCompleto.Name = "txtCompleto";
            this.txtCompleto.Size = new System.Drawing.Size(100, 20);
            this.txtCompleto.TabIndex = 6;
            // 
            // btnLimpar
            // 
            this.btnLimpar.FlatAppearance.BorderSize = 0;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Location = new System.Drawing.Point(290, 91);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 7;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Location = new System.Drawing.Point(290, 142);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 23);
            this.btnFechar.TabIndex = 8;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // frmPrinc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 212);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.txtCompleto);
            this.Controls.Add(this.lblCompleto);
            this.Controls.Add(this.btnConcatena);
            this.Controls.Add(this.txtSobrenome);
            this.Controls.Add(this.lblSobrenome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPrinc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Somando dois nomes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblSobrenome;
        private System.Windows.Forms.TextBox txtSobrenome;
        private System.Windows.Forms.Button btnConcatena;
        private System.Windows.Forms.Label lblCompleto;
        private System.Windows.Forms.TextBox txtCompleto;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnFechar;
    }
}

