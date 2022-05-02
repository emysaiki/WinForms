namespace WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            double nota1, nota2, nota3, mediaFinal;
            Int16 numeroFaltas;
            numeroFaltas = Convert.ToInt16(txtNumeroFaltas.Text);
            nota1 = Convert.ToInt16(txtNota1.Text);
            nota2 = Convert.ToInt16(txtNota2.Text);
            nota3 = Convert.ToInt16(txtNota3.Text);

            if (numeroFaltas > 18)
            {
                MessageBox.Show("O aluno está reprovado");
            }
            else
            {
                mediaFinal = ((nota1 + nota2 + nota3) / 3);
                if (mediaFinal >= 7)
                {
                    MessageBox.Show("O aluno está aprovado");
                }
                else if (mediaFinal >= 5 && mediaFinal < 7)
                {
                    MessageBox.Show("O aluno está em recuperação");
                }
                else
                {
                    MessageBox.Show("O aluno está reprovado");
                }
            }

        }
    }
}