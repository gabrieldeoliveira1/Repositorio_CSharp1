using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Exercicio___Aula_3
{
    public partial class FrmAluno : Form
    {
        public FrmAluno()
        {
            InitializeComponent();
        }

        private void FrmAluno_Load(object sender, EventArgs e)
        {

        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmHome Home = new FrmHome();
            Home.ShowDialog();
        }

        private void calculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCalculo Calculo = new FrmCalculo();
            Calculo.ShowDialog();
        }
    }
}
