using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto_calculo_soma.Formularios
{
    public partial class frmRadio : Form
    {
        public frmRadio()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioSubtra_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioDividir_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioMulti_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEXC_Click(object sender, EventArgs e)
        {
            string execucao = string.Empty;

            if (radioSoma.Checked == true)
            {
                label1.Text = "+";
                try
                {
                    decimal a = decimal.Parse(textBox1.Text);
                    decimal b = decimal.Parse(textBox2.Text);
                    label3.Text = (a + b).ToString();
                }
                catch (FormatException)
                {
                    MessageBox.Show("Por favor, insira números válidos.");
                }
            }
            if (radioSubtra.Checked == true)
            {
                label1.Text = "-";
                try
                {
                    decimal a = decimal.Parse(textBox1.Text);
                    decimal b = decimal.Parse(textBox2.Text);
                    label3.Text = (a - b).ToString();

                }
                catch (FormatException)
                {
                    MessageBox.Show("Por favor, insira números válidos.");
                }
            }
            if (radioDividir.Checked == true)
            {
                label1.Text = "/";
                try
                {
                    decimal a = decimal.Parse(textBox1.Text);
                    decimal b = decimal.Parse(textBox2.Text);
                    label3.Text = (a / b).ToString();
                }
                catch (FormatException)
                {
                    MessageBox.Show("Por favor, insira números válidos.");
                }
                catch (DivideByZeroException)
                {
                    MessageBox.Show("Não é possível dividir por zero.");
                }
            }
            if (radioMulti.Checked == true)
            {
                label1.Text = "*";
                try
                {
                    decimal a = decimal.Parse(textBox1.Text);
                    decimal b = decimal.Parse(textBox2.Text);
                    label3.Text = (a * b).ToString();
                }
                catch (FormatException)
                {
                    MessageBox.Show("Por favor, insira números válidos.");
                }
            }
            if (radioParOuImpar.Checked == true)
            {
                decimal aa = decimal.Parse(label3.Text);

                string resultado = (aa % 2 == 0) ? "par" : "ímpar";
                label3.Text = $"{aa} é {resultado}";
            }

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            label3.Text = "?";
            label1.Text = "?";
            textBox1.Clear();
            textBox2.Clear();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmRadio_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
