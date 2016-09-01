namespace Projeto01
{
    partial class frmPrincipal
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
            this.lblNome1 = new System.Windows.Forms.Label();
            this.lblNome2 = new System.Windows.Forms.Label();
            this.lblNomeCompleto = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txtN1 = new System.Windows.Forms.TextBox();
            this.txtN2 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.somarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dividirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subtrairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.multiplicarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNome1
            // 
            this.lblNome1.AutoSize = true;
            this.lblNome1.Location = new System.Drawing.Point(32, 29);
            this.lblNome1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNome1.Name = "lblNome1";
            this.lblNome1.Size = new System.Drawing.Size(29, 20);
            this.lblNome1.TabIndex = 0;
            this.lblNome1.Text = "N1";
            // 
            // lblNome2
            // 
            this.lblNome2.AutoSize = true;
            this.lblNome2.Location = new System.Drawing.Point(32, 97);
            this.lblNome2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNome2.Name = "lblNome2";
            this.lblNome2.Size = new System.Drawing.Size(29, 20);
            this.lblNome2.TabIndex = 1;
            this.lblNome2.Text = "N2";
            // 
            // lblNomeCompleto
            // 
            this.lblNomeCompleto.AutoSize = true;
            this.lblNomeCompleto.Location = new System.Drawing.Point(32, 197);
            this.lblNomeCompleto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomeCompleto.Name = "lblNomeCompleto";
            this.lblNomeCompleto.Size = new System.Drawing.Size(51, 20);
            this.lblNomeCompleto.TabIndex = 2;
            this.lblNomeCompleto.Text = "Soma";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(32, 238);
            this.lblResultado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 20);
            this.lblResultado.TabIndex = 3;
            // 
            // txtN1
            // 
            this.txtN1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtN1.Location = new System.Drawing.Point(36, 55);
            this.txtN1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtN1.Name = "txtN1";
            this.txtN1.Size = new System.Drawing.Size(253, 26);
            this.txtN1.TabIndex = 4;
            // 
            // txtN2
            // 
            this.txtN2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtN2.Location = new System.Drawing.Point(36, 123);
            this.txtN2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtN2.Name = "txtN2";
            this.txtN2.Size = new System.Drawing.Size(253, 26);
            this.txtN2.TabIndex = 5;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.somarToolStripMenuItem,
            this.dividirToolStripMenuItem,
            this.subtrairToolStripMenuItem,
            this.multiplicarToolStripMenuItem,
            this.toolStripMenuItem1,
            this.sairToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 142);
            // 
            // somarToolStripMenuItem
            // 
            this.somarToolStripMenuItem.Name = "somarToolStripMenuItem";
            this.somarToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.somarToolStripMenuItem.Text = "Somar";
            // 
            // dividirToolStripMenuItem
            // 
            this.dividirToolStripMenuItem.Name = "dividirToolStripMenuItem";
            this.dividirToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.dividirToolStripMenuItem.Text = "Dividir";
            // 
            // subtrairToolStripMenuItem
            // 
            this.subtrairToolStripMenuItem.Name = "subtrairToolStripMenuItem";
            this.subtrairToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.subtrairToolStripMenuItem.Text = "Subtrair";
            // 
            // multiplicarToolStripMenuItem
            // 
            this.multiplicarToolStripMenuItem.Name = "multiplicarToolStripMenuItem";
            this.multiplicarToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.multiplicarToolStripMenuItem.Text = "Multiplicar";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(128, 6);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 380);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.txtN2);
            this.Controls.Add(this.txtN1);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblNomeCompleto);
            this.Controls.Add(this.lblNome2);
            this.Controls.Add(this.lblNome1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trabalhando no Windows Forms";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome1;
        private System.Windows.Forms.Label lblNome2;
        private System.Windows.Forms.Label lblNomeCompleto;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txtN1;
        private System.Windows.Forms.TextBox txtN2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem somarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dividirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subtrairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem multiplicarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
    }
}

