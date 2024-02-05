namespace Projeto_Exercicio___Aula_3
{
    public partial class FrmHome : Form
    {
        public FrmHome()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void alunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAluno Aluno = new FrmAluno();
            Aluno.ShowDialog();
        }

        private void calculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCalculo Calculo = new FrmCalculo();
            Calculo.ShowDialog();
        }
    }
}
