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
    public partial class FrmPerfeitos : Form
    {
        public FrmPerfeitos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ni = 0; int nf = 0;
            int contador = 0; int soma = 0;

            ni = int.Parse(txtNI.Text);
            nf = int.Parse(txtNF.Text);
            if (ni > nf)
            {
                int aux = ni;
                ni = nf;
                nf = aux;
            }
            for (contador = ni; contador < nf; contador++)
            {
                soma = 0;
                for (int contador2 = 1; contador2 < contador; contador2++)
                {
                    if (contador % contador2 == 0)
                    {
                        soma =soma + contador2;
                    }
                }
                if (soma == contador)
                {
                    listBox1.Items.Add(contador.ToString());
                }
            }
            button1.Enabled = false;
        }
    }
}
