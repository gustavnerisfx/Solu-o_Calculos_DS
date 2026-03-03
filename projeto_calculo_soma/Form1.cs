using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto_calculo_soma
{
    public partial class CalculadoraSoma : Form
    {
        public CalculadoraSoma()
        {
            InitializeComponent();
        }

        private void CalculadoraSoma_Load(object sender, EventArgs e)
        {

        }

        private void textnum1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textnum2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            
            label3.Text = "+";
            try
            {
                double a = double.Parse(textnum1.Text);
                double b = double.Parse(textnum2.Text);
                lblResultado.Text = (a + b).ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, insira números válidos.");
            }
            

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            label3.Text = "?";
            lblResultado.Text = "?";
            textnum1.Clear();
            textnum2.Clear();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label3.Text = "/";
            try
            {
                double a = double.Parse(textnum1.Text);
                double b = double.Parse(textnum2.Text);
                lblResultado.Text = (a / b).ToString();
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

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            label1.Text = "-";
            try
            {
                double a = double.Parse(textnum1.Text);
                double b = double.Parse(textnum2.Text);
                lblResultado.Text = (a - b).ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, insira números válidos.");
            }
            
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            label3.Text = "*";
            try
            {
                double a = double.Parse(textnum1.Text);
                double b = double.Parse(textnum2.Text);
                lblResultado.Text = (a * b).ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, insira números válidos.");
            }
            
        }

        private void btnParImpar_Click(object sender, EventArgs e)
        {
            
            double aa = double.Parse(lblResultado.Text);

            string resultado = ( aa % 2 == 0) ? "par" : "ímpar";
            lblResultado.Text = $"{aa} é {resultado}";

        }

        private void btnComparar_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textnum1.Text);
            double b = double.Parse(textnum2.Text);

            if (a > b)
            {
                lblResultado.Text = (a + " é maior que " + b);
            }
            else if (a < b)
            {
                lblResultado.Text = (a + " é menor que " + b);
            }
            else
            {
                lblResultado.Text = (a + " é igual a " + b);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
