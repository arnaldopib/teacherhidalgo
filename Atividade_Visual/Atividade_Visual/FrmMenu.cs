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
    public partial class FrmMenu : Form
    {
        public int nv = 0;
        public FrmMenu()
        {
            InitializeComponent();
        }

        public FrmMenu(string info)
        {
            InitializeComponent();
            toolStripStatusLabel1.Text = info.ToString();
        }
        public FrmMenu(string info, int nivel)
        {
            nv = nivel;
            InitializeComponent();
            if (nv == 1)
            {
                loucoToolStripMenuItem.Visible = false;
            }
            else
            {
                if(nv == 2)
                {
                    primosToolStripMenuItem.Enabled = false;
                }
            }
            toolStripStatusLabel1.Text = info.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = DateTime.Now.ToLongTimeString();
            toolStripStatusLabel3.Text = DateTime.Now.ToShortDateString();

        }

        private void primosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPrimo primo = new FrmPrimo();
            primo.Show();
        }

        private void perfeitosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPerfeitos perfeitos = new FrmPerfeitos();
            perfeitos.Show();
        }

        private void fibbonacciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFibonnacci fibo = new FrmFibonnacci();
            fibo.Show();
        }
    }
}
