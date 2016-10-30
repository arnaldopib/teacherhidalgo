using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjCalculadora
{
    public partial class Form1 : Form
    {
        double v1 = 0, v2 = 0;
        string operacao = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtPainel.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtPainel.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtPainel.Text += "3";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtPainel.Text += "0";
        }

        private void btnVirg_Click(object sender, EventArgs e)
        {
            txtPainel.Text += ",";
            btnVirg.Enabled = false;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtPainel.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtPainel.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtPainel.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtPainel.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtPainel.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtPainel.Text += "9";
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            if ((v1 == 0) || (operacao == "="))
            {
                lstResult.Items.Clear();
                lstResult.Items.Add(txtPainel.Text);
                v1 = double.Parse(txtPainel.Text);
                operacao = "-";
                txtPainel.Clear();
                btnVirg.Enabled = true;
                lstResult.Items.Add("-");
            }
            else
            {
                lstResult.Items.Add(txtPainel.Text);
                v1 -= double.Parse(txtPainel.Text);
                operacao = "-";
                txtPainel.Clear();
                btnVirg.Enabled = true;
                lstResult.Items.Add("-");
            }

        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            if (operacao == "+")
            {
                lstResult.Items.Add(txtPainel.Text);
                v2 = double.Parse(txtPainel.Text);
                v2 += v1;
                v1 = 0;
                txtPainel.Clear();
                btnVirg.Enabled = true;
                lstResult.Items.Add("=");
                lstResult.Items.Add(v2.ToString());
                txtPainel.Text = v2.ToString();
                operacao = "=";
            }
            else
            {
                if (operacao == "-")
                {
                    lstResult.Items.Add(txtPainel.Text);
                    v2 = double.Parse(txtPainel.Text);
                    v2 -= v1;
                    v1 = 0;
                    txtPainel.Clear();
                    btnVirg.Enabled = true;
                    lstResult.Items.Add("=");
                    lstResult.Items.Add(v2.ToString());
                    txtPainel.Text = v2.ToString();
                    operacao = "=";
                }
                else
                {
                    if (operacao == "*")
                    {
                        lstResult.Items.Add(txtPainel.Text);
                        v2 = double.Parse(txtPainel.Text);
                        v2 *= v1;
                        v1 = 0;
                        txtPainel.Clear();
                        btnVirg.Enabled = true;
                        lstResult.Items.Add("=");
                        lstResult.Items.Add(v2.ToString());
                        txtPainel.Text = v2.ToString();
                        operacao = "=";
                    }
                    else
                    {
                        if (operacao == "÷")
                        {
                            lstResult.Items.Add(txtPainel.Text);
                            v2 = double.Parse(txtPainel.Text);
                            v2 /= v1;
                            v1 = 0;
                            txtPainel.Clear();
                            btnVirg.Enabled = true;
                            lstResult.Items.Add("=");
                            lstResult.Items.Add(v2.ToString());
                            txtPainel.Text = v2.ToString();
                            operacao = "=";
                        }

                    }

                }

            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            if ((v1 == 0) || (operacao == "="))
            {
                lstResult.Items.Clear();
                lstResult.Items.Add(txtPainel.Text);
                v1 = double.Parse(txtPainel.Text);
                operacao = "*";
                txtPainel.Clear();
                btnVirg.Enabled = true;
                lstResult.Items.Add("*");
            }
            else
            {
                lstResult.Items.Add(txtPainel.Text);
                v1 *= double.Parse(txtPainel.Text);
                operacao = "*";
                txtPainel.Clear();
                btnVirg.Enabled = true;
                lstResult.Items.Add("*");
            }

        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            if ((v1 == 0) || (operacao == "="))
            {
                lstResult.Items.Clear();
                lstResult.Items.Add(txtPainel.Text);
                v1 = double.Parse(txtPainel.Text);
                operacao = "÷";
                txtPainel.Clear();
                btnVirg.Enabled = true;
                lstResult.Items.Add("÷");
            }
            else
            {
                lstResult.Items.Add(txtPainel.Text);
                v1 /= double.Parse(txtPainel.Text);
                operacao = "÷";
                txtPainel.Clear();
                btnVirg.Enabled = true;
                lstResult.Items.Add("÷");
            }

        }

        private void btnInv_Click(object sender, EventArgs e)
        {
            v2 = double.Parse(txtPainel.Text);
            v2 *= -1;
            txtPainel.Text = v2.ToString();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if ((v1 == 0) || (operacao == "="))
            {
                lstResult.Items.Clear();
                lstResult.Items.Add(txtPainel.Text);
                v1 = double.Parse(txtPainel.Text);
                operacao = "+";
                txtPainel.Clear();
                btnVirg.Enabled = true;
                lstResult.Items.Add("+");
            }
            else
            {
                lstResult.Items.Add(txtPainel.Text);
                v1 += double.Parse(txtPainel.Text);
                operacao = "+";
                txtPainel.Clear();
                btnVirg.Enabled = true;
                lstResult.Items.Add("+");
            }
        }
    }
}
