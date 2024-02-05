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
    public partial class FrmCalculo : Form
    {
        public FrmCalculo()
        {
            InitializeComponent();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmHome Home = new FrmHome();
            Home.ShowDialog();
        }

        private void calculoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void alunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAluno Aluno = new FrmAluno();
            Aluno.ShowDialog();
        }
    }
}
