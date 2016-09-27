using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade_Visual
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAcesso_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Informe um usuário válido");
                textBox1.Focus();
            }
            else
            {
                if (textBox2.Text == "")
                {
                    MessageBox.Show("Informe uma senha");
                    textBox2.Focus();
                }
                else
                {
                    if ((textBox1.Text == "Admin") && (textBox2.Text == "123456"))
                    {
                        MessageBox.Show("Bem vindo Sr. Administrador");
                        FrmMenu menu = new FrmMenu("Arnaldo Martins Hidalgo Junior");
                        menu.Show();
                    }
                    else
                    {
                        if ((textBox1.Text == "Usuario") && (textBox2.Text == "0000"))
                        {

                            MessageBox.Show("Bem vindo Sra. Secretaria");
                            FrmMenu menu = new FrmMenu("Renata Hidalgo");
                            menu.Show();
                        }
                        else
                        {


                            MessageBox.Show("Usuário não encontrado. Tente novamente...");
                            textBox1.Text = "";
                            textBox2.Text = "";
                            textBox1.Focus();
                        }

                    }
                }
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
