using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaEscolar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtMedia.Text = "";
            txtMF.Text = "";
            txtN1.Text = "";
            txtN2.Text = "";
            txtN3.Text = "";
            txtN4.Text = "";
            btnMedia2.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            txtRec.Visible = false;
            lblSitFinal.Visible = false;
            txtMedia.Text = "";
            lblSit.Text = "";
            txtN1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtN1.Text == "")
            {
                MessageBox.Show("Informe a primeira nota","Atenção");
                txtN1.Focus();
            }
            else
            {
                if (txtN2.Text == "")
                {
                    MessageBox.Show("Informe a segunda nota", "Atenção");
                    txtN2.Focus();
                }
                else
                {
                    if (txtN3.Text == "")
                    {
                        MessageBox.Show("Informe a terceira nota", "Atenção");
                        txtN3.Focus();
                    }
                    else
                    {
                        if (txtN4.Text == "")
                        {
                            MessageBox.Show("Informe a quarta nota", "Atenção");
                            txtN4.Focus();
                        }
                        else
                        {
                            double menor = 10;
                            double n1 = 0, n2 = 0, n3 =0, n4 = 0;
                            n1 = double.Parse(txtN1.Text);
                            n2 = double.Parse(txtN2.Text);
                            n3 = double.Parse(txtN3.Text);
                            n4 = double.Parse(txtN4.Text);
                            double media = 0;
                            if (n1 < menor)
                            {
                                menor = n1;
                            }
                            if (n2 < menor)
                            {
                                menor = n2;
                            }
                            if (n3 < menor)
                            {
                                menor = n3;
                            }
                            if (n4 < menor)
                            {
                                menor = n4;
                            }
                            media = (n1 + n2 + n3 + n4) / 4;
                            if (media >= 7)
                            {
                                lblSit.Text = "Aprovado";
                            }
                            else
                            {
                                if ((media >=5) && (media < 7))
                                {
                                    lblSit.Text = "Recuperação";
                                    btnMedia2.Visible = true;
                                    label10.Visible = true;
                                    label11.Visible = true;
                                    label12.Visible = true;
                                    txtRec.Visible = true;
                                    lblSitFinal.Visible = true;                        
                                }
                                else
                                {
                                    lblSit.Text = "Reprovado";
                                }
                            }
                            txtMedia.Text = media.ToString();
                        }

                    }

                }

            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Deseja realmente Encerrar?", "Cálculo de Notas", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
