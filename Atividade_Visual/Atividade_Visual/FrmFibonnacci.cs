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
    public partial class FrmFibonnacci : Form
    {
        public FrmFibonnacci()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int fibo = 0;
            int a = 0;
            int p = 1;
            listBox1.Items.Add(a.ToString());
            listBox1.Items.Add(p.ToString());
            fibo = int.Parse(txtNum.Text);
            for (int i = 1; i <=fibo; i++)
            {
                int x = a + p;
                listBox1.Items.Add(x.ToString());
                a = p;
                p = x;
            }
        }
    }
}
