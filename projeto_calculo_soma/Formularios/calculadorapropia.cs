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
    public partial class calculadorapropia : Form
    {
        decimal vNumAnt;
        string vOperacao;
        bool vLimparVisor;
        public calculadorapropia()
        {
            InitializeComponent();
        }

        private void f_digitos(object sender, EventArgs e)
        {
            string digitos = ((Button)sender).Text;
            if(lblVisor.Text == "0" || vLimparVisor)
            {
                lblVisor.Text = "";
                vLimparVisor = false;
            }
            lblVisor.Text += digitos;
        }

        private void f_operacoes(object sender, EventArgs e)
        {
            vNumAnt = decimal.Parse(lblVisor.Text);
            vOperacao = ((Button)sender).Text;
            vLimparVisor = true;
        }


        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void calculadorapropia_Load(object sender, EventArgs e)
        {

        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            decimal vNumAtual = decimal.Parse(lblVisor.Text);

            switch(vOperacao)
            {
                case "+":
                    lblVisor.Text = (vNumAnt + vNumAtual).ToString();
                    break;
                case "-":
                    lblVisor.Text = (vNumAnt - vNumAtual).ToString();
                    break;
                case "*":
                    lblVisor.Text = (vNumAnt * vNumAtual).ToString();
                    break;
                case "/":
                    lblVisor.Text = (vNumAnt / vNumAtual).ToString();
                    break;
                case "^":
                    lblVisor.Text = (Math.Pow((double)vNumAnt, (double)vNumAtual)).ToString();
                    break;
            }
        }

        private void btnVirgula_Click(object sender, EventArgs e)
        {
            if(!lblVisor.Text.Contains(","))
            {
                lblVisor.Text += ",";
            }

        }

        private void btnC_Click(object sender, EventArgs e)
        {
            vNumAnt = 0;
            lblVisor.Text = "0";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            lblVisor.Text = lblVisor.Text.Substring(0, lblVisor.Text.Length - 1);
            if(lblVisor.Text == "0")
            {
                lblVisor.Text = "";
            }
        }

        private void btnMM_Click(object sender, EventArgs e)
        {
            if (double.TryParse(lblVisor.Text, out double valor))
            {
                valor *= -1;
                lblVisor.Text = valor.ToString();
            }
        }
    }
}
