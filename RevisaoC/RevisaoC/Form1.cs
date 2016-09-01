using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RevisaoC
{
    public partial class frmPrinc : Form
    {
        public frmPrinc()
        {
            InitializeComponent();
        }

        private void btnConcatena_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                MessageBox.Show("Problema... ");
                txtNome.Focus();
            }
            else
            {
                if (txtSobrenome.Text == "")
                {
                    MessageBox.Show("Problema... ");
                    txtSobrenome.Focus();
                }
                else
                {
                    txtCompleto.Text = txtNome.Text + " " + txtSobrenome.Text;
                }
            }
         }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtSobrenome.Text = "";
            txtNome.Text = "";
            txtCompleto.Clear();
            txtNome.Focus();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            DialogResult resposta = MessageBox.Show("Deseja realmente encerrar a aplicação?", "Daniel Simões", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (resposta == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
