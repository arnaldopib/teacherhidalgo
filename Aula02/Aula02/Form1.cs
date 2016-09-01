using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula02
{
    public partial class FrmCalculadora : Form
    {
        public FrmCalculadora()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            btnSoma.Enabled = true;
            btnDif.Enabled = true;
            btnMult.Enabled = true;
            btnDiv.Enabled = true;
            btnLimpar.Enabled = false;
            txtN1.Text = "";
           txtN2.Text = "";
           lblResultado.Text = "";
            txtN1.Focus();
        }

        private void FrmCalculadora_Load(object sender, EventArgs e)
        {
            btnLimpar.Enabled = false;
            txtN1.Text = "0";
            txtN2.Text = "0";
        }

        private void txtN1_Leave(object sender, EventArgs e)
        {
            if (txtN1.Text == "")
            {
                MessageBox.Show("N1 é obrigatório.");
                txtN1.Focus();
            }
        }

        private void txtN2_Leave(object sender, EventArgs e)
        {
            if (txtN2.Text == "")
            {
                MessageBox.Show("Informe N2 também.");
                txtN2.Focus();
            }
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            btnSoma.Enabled = true;
            btnDif.Enabled = false;
            btnMult.Enabled = false;
            btnDiv.Enabled = false;
            btnLimpar.Enabled = true;
            double n1 = 0;
            double n2 = 0;
            n1 = double.Parse(txtN1.Text);
            n2 = double.Parse(txtN2.Text);
            double soma = 0;
            soma = n1 + n2;
            lblResultado.Text = soma.ToString();
        }

        private void btnDif_Click(object sender, EventArgs e)
        {
            btnSoma.Enabled = false;
            btnDif.Enabled = true;
            btnMult.Enabled = false;
            btnDiv.Enabled = false;
            btnLimpar.Enabled = true;
            double n1 = 0;
            double n2 = 0;
            n1 = double.Parse(txtN1.Text);
            n2 = double.Parse(txtN2.Text);
            double diff = 0;
            diff = n1 - n2;
            lblResultado.Text = diff.ToString();

        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            btnSoma.Enabled = false;
            btnDif.Enabled = false;
            btnMult.Enabled = true;
            btnDiv.Enabled = false;
            btnLimpar.Enabled = true;
            double n1 = 0;
            double n2 = 0;
            n1 = double.Parse(txtN1.Text);
            n2 = double.Parse(txtN2.Text);
            double divisao = 0;
            divisao = n1 / n2;
            lblResultado.Text = divisao.ToString();

        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            btnSoma.Enabled = false;
            btnDif.Enabled = false;
            btnMult.Enabled = false;
            btnDiv.Enabled = true;
            btnLimpar.Enabled = true;
            double n1 = 0;
            double n2 = 0;
            n1 = double.Parse(txtN1.Text);
            n2 = double.Parse(txtN2.Text);
            double mult = 0;
            mult = n1 * n2;
            lblResultado.Text = mult.ToString();

        }

        private void txtN1_Enter(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtN1.Text == "0")
            {
                txtN1.Text = "1";
            }
            else
            {
                txtN1.Text = txtN1.Text + "1";
            }
        }
    }
}
