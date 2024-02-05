using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_equacoes
{
    public partial class FrmHome : Form
    {
        public FrmHome()
        {
            InitializeComponent();
        }

        private void FrmHome_Load(object sender, EventArgs e)
        {

        }

        private void calculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 Calculator = new Form1();
            Calculator.ShowDialog();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUsuario Usuario = new FrmUsuario();
            Usuario.ShowDialog();
        }

        private void principalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPrincipal Principal = new FrmPrincipal();
            Principal.ShowDialog();
        }
    }
}
