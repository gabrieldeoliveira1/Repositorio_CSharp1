using System.Security.AccessControl;

namespace Calculadora_equacoes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Gray;
            textBox2.ForeColor = Color.Gray;
            textBox3.ForeColor = Color.Gray;
            textBox1.Text = "Insira um número:";
            textBox2.Text = "Insira um número:";
            textBox3.Text = "Insira um número:";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            mover();
            watermark("Insira um número:", textBox1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float valor1 = (float)Convert.ToDouble(textBox1.Text);
            float valor2 = (float)Convert.ToDouble(textBox2.Text);
            float valor3 = (float)Convert.ToDouble(textBox3.Text);

            double delta = Math.Pow(valor2, 2) - 4 * valor1 * valor3;

            if (delta < 0)
            {
                MessageBox.Show("A equação não possui raízes reais.");
            }
            else if (delta == 0)
            {
                double x = -valor2 / (2 * valor1);
                MessageBox.Show($"A equação possui uma raiz real: x = {x}");
            }
            else
            {

                double x1 = (-valor2 + Math.Sqrt(delta)) / (2 * valor1);
                double x2 = (-valor2 - Math.Sqrt(delta)) / (2 * valor1);

                MessageBox.Show($"A equação possui duas raizes reais: x1 = {x1}, x2 = {x2}");
            }
        }

        void mover()
        {
            if (textBox1.ContainsFocus)
            {
                textBox1.KeyDown += (sender, e) =>
                {
                    if (textBox1.Focused && e.KeyCode == Keys.Enter)
                    {
                        textBox2.Focus();
                    }
                };
            }
            if (textBox2.ContainsFocus)
            {
                textBox2.KeyDown += (sender, e) =>
                {
                    if (textBox2.Focused && e.KeyCode == Keys.Enter)
                    {
                        textBox3.Focus();
                    }
                };
            }
            if (textBox3.ContainsFocus)
            {
                textBox3.KeyDown += (sender, e) =>
                {
                    if (textBox3.Focused && e.KeyCode == Keys.Enter)
                    {
                        textBox1.Focus();
                    }
                };
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            mover();
            watermark("Insira um número:", textBox2);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            mover();
            watermark("Insira um número:", textBox3);
        }


        void watermark(String MyText, TextBox textBox)
        {
            textBox.Paint += (sender, e) =>
            {
                if (string.IsNullOrEmpty(textBox.Text))
                {
                    textBox.ForeColor = Color.Gray;
                    textBox.Text = MyText;
                }
            };

            textBox.Enter += (sender, e) =>
            {
                if (textBox.Text == MyText)
                {
                    textBox.Clear();
                    textBox.ForeColor = Color.Black;
                }
            };

            textBox.Leave += (sender, e) =>
            {
                if (string.IsNullOrEmpty(textBox.Text))
                {
                    textBox.ForeColor = Color.Gray;
                    textBox.Text = MyText;
                }
            };

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Chamando nova tela;
            //Nome da Tela;
            //Usuario nome criado na tela
            FrmUsuario usuario = new FrmUsuario();
            usuario.ShowDialog();
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 Calculator = new Form1();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmHome Home = new FrmHome();
            Home.ShowDialog();
        }

        private void principalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPrincipal Principal = new FrmPrincipal();
            Principal.ShowDialog();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUsuario Usuario = new FrmUsuario();
            Usuario.ShowDialog();
        }
    }
}
