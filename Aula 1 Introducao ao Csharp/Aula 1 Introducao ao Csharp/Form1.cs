namespace Aula_1_Introducao_ao_Csharp
{
    public partial class Form_Calculadora : Form
    {
        Int32 soma;
        Int32 sub;
        float div;
        Int32 multi;
        float pot;
        double raiz;
        double pow;
        double elevado;
        Int32 check;
        public Form_Calculadora()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            //Converte o conteúdo da caixa de texto para número inteiro.
            Int32 valor1 = Convert.ToInt32(textBox1.Text);
            Int32 valor2 = Convert.ToInt32(textBox2.Text);
            soma = valor1 + valor2;

            check = 1;

        }

        private void button22_Click(object sender, EventArgs e)
        {
            Int32 valor1 = Convert.ToInt32(textBox1.Text);
            Int32 valor2 = Convert.ToInt32(textBox2.Text);
            div = valor1 / valor2;

            check = 5;
        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //verifica se está vazio ou não o campo
            //método string função IsNullorEmpty
            //Valida o campo textBox
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Campo Vazio");
                textBox1.Focus();//volta o cursor para o texBox
                return;//para o comando
            }

            switch (check)
            {
                case 1:
                    textBox3.Text = ("Resultado: " + soma.ToString());
                    break;
                case 2:
                    textBox3.Text = ("Resultado: " + raiz.ToString());
                    break;
                case 3:
                    textBox3.Text = ("Resultado: " + pot.ToString());
                    break;
                case 4:
                    textBox3.Text = ("Resultado: " + sub.ToString());
                    break;
                case 5:
                    textBox3.Text = ("Resultado: " + div.ToString());
                    break;
                case 6:
                    textBox3.Text = ("Resultado: " + multi.ToString());
                    break;
              }
        
    }


        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

    private void button20_Click(object sender, EventArgs e)
    {
            check = 4;
        Int32 valor1 = Convert.ToInt32(textBox1.Text);
        Int32 valor2 = Convert.ToInt32(textBox2.Text);
        sub = valor1 - valor2;



    }

    private void button21_Click(object sender, EventArgs e)
        {
            check = 6;
            Int32 valor1 = Convert.ToInt32(textBox1.Text);
            Int32 valor2 = Convert.ToInt32(textBox2.Text);
            multi = valor1 * valor2;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            check = 2;
            double raiz = Convert.ToDouble(textBox1.Text);
            MessageBox.Show("Resultado da Raiz é: " + Math.Sqrt(raiz));

        }

        private void button23_Click(object sender, EventArgs e)
        {
            check = 3;
            double pow = Convert.ToDouble(textBox1.Text);
            double elevado = Convert.ToDouble(textBox2.Text);
            MessageBox.Show("Resultado da Potência é: " + Math.Pow(pow, elevado));
        }
    }
}
