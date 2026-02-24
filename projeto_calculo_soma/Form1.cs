using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            double a = double.Parse(textnum1.Text);
            double b = double.Parse(textnum2.Text);
            label1.Text = "+";
            lblResultado.Text = (a + b).ToString();


        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            label1.Text = "?";
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
    }
}
