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

            this.ActiveControl = null;
        }


        private void f_operacoes(object sender, EventArgs e)
        {
            vNumAnt = decimal.Parse(lblVisor.Text);
            vOperacao = ((Button)sender).Text;
            vLimparVisor = true;
            lblHistorico.Text = "";
            lblHistorico.Text += vNumAnt + " " + vOperacao + " ";
            this.ActiveControl = null;
        }


        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void calculadorapropia_Load(object sender, EventArgs e)
        {

        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            
        }

        private void btnVirgula_Click(object sender, EventArgs e)
        {
            if(!lblVisor.Text.Contains(","))
            {
                lblVisor.Text += ",";
            }
            this.ActiveControl = null;
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            vNumAnt = 0;
            lblVisor.Text = "0";
            lblHistorico.Text = "";
            this.ActiveControl = null;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            lblVisor.Text = lblVisor.Text.Substring(0, lblVisor.Text.Length - 1);
            if(lblVisor.Text == "0")
            {
                lblVisor.Text = "";
            }
            if (lblVisor.Text == "")
            {
                lblVisor.Text = "0";
            }
            this.ActiveControl = null;
        }

        private void btnMM_Click(object sender, EventArgs e)
        {
            if (double.TryParse(lblVisor.Text, out double valor))
            {
                valor *= -1;
                lblVisor.Text = valor.ToString();
            }
            this.ActiveControl = null;
        }

        private void calculadorapropia_KeyDown(object sender, KeyEventArgs e)
        {
            
            Button botao = new Button();

            if(e.KeyCode == Keys.Back)
            {
                lblVisor.Text = lblVisor.Text.Substring(0, lblVisor.Text.Length - 1);
                if (lblVisor.Text == "0")
                {
                    lblVisor.Text = "";
                }
                if (lblVisor.Text == "")
                {
                    lblVisor.Text = "0";
                }
                this.ActiveControl = null;
            }

            if (e.KeyCode == Keys.Escape) 
            {
                Close();
            }

            if (e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9)
            {
                botao.Text = e.KeyCode.ToString().Substring(1);
                foreach (Control ctr in flowLayoutPanel1.Controls)
                {
                    if (((Button)ctr).Text == botao.Text)
                    {
                        ctr.BackColor = Color.LightBlue;
                    }
                }
                f_digitos(botao, e);
            }
            if (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9)
            {
                botao.Text = e.KeyCode.ToString().Substring(6);
                foreach (Control ctr in flowLayoutPanel1.Controls)
                {
                    if (((Button)ctr).Text == botao.Text)
                    {
                        ctr.BackColor = Color.LightBlue;
                    }
                }
                f_digitos(botao, e);
            }

            switch(e.KeyCode)
            {
                case Keys.Add:
                    botao.Text = "+";
                    f_operacoes(botao, e);
                    break;
                case Keys.Subtract:
                    botao.Text = "-";
                    f_operacoes(botao, e);
                    break;
                case Keys.Divide:
                    botao.Text = "/";
                    f_operacoes(botao, e);
                    break;
                case Keys.Multiply:
                    botao.Text = "*";
                    f_operacoes(botao, e);
                    break;
                case Keys.Return:
                    btn_iGual_Click(botao, e);
                    break;
            }

            this.KeyPreview = true;
        }

        private void calculadorapropia_Shown(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void btnIgual_Enter(object sender, EventArgs e)
        {

        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            if (vNumAnt != 0)
            {
                lblVisor.Text = "";
                
            }
            else
            {
                lblVisor.Text = "";
                vNumAnt = 0;
            }
            this.ActiveControl = null;
        }

        private void btn_iGual_Click(object sender, EventArgs e)
        {
            decimal vNumAtual = decimal.Parse(lblVisor.Text);

            switch (vOperacao)
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
                    if (vNumAtual == 0)
                    {
                        MessageBox.Show("Não é possível dividir por zero.", "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                        lblVisor.Text = "0";
                        return;
                    }
                    lblVisor.Text = (vNumAnt / vNumAtual).ToString();
                    break;
                case "^":
                    lblVisor.Text = (Math.Pow((double)vNumAnt, (double)vNumAtual)).ToString();
                    break;
            }
            lblHistorico.Text += vNumAtual + " = ";
            this.ActiveControl = null;
        }

        private void calculadorapropia_KeyUp(object sender, KeyEventArgs e)
        {
            foreach (Control ctr in flowLayoutPanel1.Controls)
            {
                if (ctr is Button)
                {
                    ctr.BackColor = SystemColors.ButtonHighlight;
                }
            }
        }
    }
}
