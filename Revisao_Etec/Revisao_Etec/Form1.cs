using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Revisao_Etec
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = this.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("A informação não pode ser vazia. Redigite");
                textBox1.Focus();
            }
            else
            {
                if (String.IsNullOrWhiteSpace(comboBox1.Text))
                {
                    MessageBox.Show("Selecione um sexo Válido!!!");
                    comboBox1.Focus();
                }
                else
                {
                    if ((comboBox1.Text != "Masculino")&&(comboBox1.Text != "Feminino"))
                    {
                        MessageBox.Show("Informação inválida. Tente novamente");
                        comboBox1.Text = "";
                        comboBox1.Focus();
                    }
                    else
                    {
                        if (dateTimePicker1.Value > DateTime.Now)
                        {
                            MessageBox.Show("Data invalida. Tente novamente...!!!");
                            dateTimePicker1.Focus();
                        }
                        else
                        {
                            if (checkBox1.Checked)
                            {
                                MessageBox.Show("Usuário definido como ativo.!!!");

                            }
                            else
                            {
                                if (checkBox1.Checked == false)
                                {
                                    MessageBox.Show("Usuario definido como inativo...!!!");
                                }
                            }
                            if ((!radioButton1.Checked) && (!radioButton2.Checked))
                                    {
                                        MessageBox.Show("Selecione o Estado Civil.");
                                    }else
                                    {
                                        MessageBox.Show("Informações cadastradas com sucesso...!!!");

                                    }
                                }
                            }
                        
                    
                }
            }
        }
    }
}
