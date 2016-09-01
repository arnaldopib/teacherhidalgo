using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto01
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtN1.Clear(); //txtNome1.Text = "";
            txtN2.Clear(); //txtNome2.Text = "";
            lblResultado.Text = "";
            txtN1.Focus();
        }

        private void btnConcatenar_Click(object sender, EventArgs e)
        {
            int n1 = 0;
            if (txtN1.Text == "")
            {
                MessageBox.Show("Informe um número...");
            }
            else
            {
                n1 = int.Parse(txtN1.Text);
            }
            int n2 = int.Parse(txtN2.Text);
            int soma = n1 + n2;
            lblResultado.Text = soma.ToString();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    }
