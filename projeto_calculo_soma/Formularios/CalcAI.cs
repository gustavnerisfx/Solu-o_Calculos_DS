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
    public partial class CalcAI : Form
    {
        private TextBox display;

        private double valorAtual = 0;
        private string operacao = "";
        private bool novoNumero = true;

        public CalcAI()
        {
            InitializeComponent();
            InicializarUI();
        }

        private void CalcAI_Load(object sender, EventArgs e)
        {
            // pode deixar vazio mesmo
        }

        private void InicializarUI()
        {
            this.Text = "CalcAI";
            this.Size = new Size(300, 450);
            this.BackColor = Color.FromArgb(30, 30, 30);

            display = new TextBox();
            display.Text = "0";
            display.Font = new Font("Segoe UI", 24);
            display.Dock = DockStyle.Top;
            display.MinimumSize = new Size(0, 70);
            display.MaximumSize = new Size(0, 70);
            display.TextAlign = HorizontalAlignment.Right;
            display.BackColor = Color.Black;
            display.ForeColor = Color.White;
            
            var painel = new TableLayoutPanel();
            painel.RowCount = 6;
            painel.ColumnCount = 4;
            painel.Dock = DockStyle.Fill;

            for (int i = 0; i < 6; i++)
                painel.RowStyles.Add(new RowStyle(SizeType.Percent, 100f / 6f));

            for (int i = 0; i < 4; i++)
                painel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25));

            this.Controls.Add(painel);
            this.Controls.Add(display);

            string[,] botoes = {
                { "CE", "C", "←", "^" },
                { "7", "8", "9", "/" },
                { "4", "5", "6", "*" },
                { "1", "2", "3", "-" },
                { "±", "0", ",", "+" },
                { "", "", "=", "" }
            };

            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (botoes[i, j] == "") continue;

                    var btn = CriarBotao(botoes[i, j]);
                    painel.Controls.Add(btn, j, i);
                }
            }
        }

        private Button CriarBotao(string texto)
        {
            var btn = new Button();
            btn.Text = texto;
            btn.Dock = DockStyle.Fill;
            btn.Font = new Font("Segoe UI", 12);
            btn.BackColor = Color.FromArgb(50, 50, 50);
            btn.ForeColor = Color.White;

            btn.Click += Botao_Click;

            return btn;
        }

        private void Botao_Click(object sender, EventArgs e)
        {
            string valor = ((Button)sender).Text;

            if (char.IsDigit(valor, 0))
            {
                if (display.Text == "0" || novoNumero)
                    display.Text = valor;
                else
                    display.Text += valor;

                novoNumero = false;
            }
            else
            {
                switch (valor)
                {
                    case ",":
                        if (!display.Text.Contains(","))
                            display.Text += ",";
                        break;

                    case "C":
                        display.Text = "0";
                        valorAtual = 0;
                        operacao = "";
                        break;

                    case "CE":
                        display.Text = "0";
                        break;

                    case "←":
                        if (display.Text.Length > 1)
                            display.Text = display.Text.Substring(0, display.Text.Length - 1);
                        else
                            display.Text = "0";
                        break;

                    case "±":
                        if (display.Text != "0")
                        {
                            if (display.Text.StartsWith("-"))
                                display.Text = display.Text.Substring(1);
                            else
                                display.Text = "-" + display.Text;
                        }
                        break;

                    case "+":
                    case "-":
                    case "*":
                    case "/":
                    case "^":
                        Calcular();
                        operacao = valor;
                        valorAtual = Convert.ToDouble(display.Text);
                        novoNumero = true;
                        break;

                    case "=":
                        Calcular();
                        operacao = "";
                        break;
                }
            }
        }

        private void Calcular()
        {
            double numero = Convert.ToDouble(display.Text);

            switch (operacao)
            {
                case "+":
                    valorAtual += numero;
                    break;
                case "-":
                    valorAtual -= numero;
                    break;
                case "*":
                    valorAtual *= numero;
                    break;
                case "/":
                    if (numero != 0)
                        valorAtual /= numero;
                    else
                    {
                        MessageBox.Show("Divisão por zero!");
                        return;
                    }
                    break;
                case "^":
                    valorAtual = Math.Pow(valorAtual, numero);
                    break;
                default:
                    valorAtual = numero;
                    break;
            }

            display.Text = valorAtual.ToString();
            novoNumero = true;
        }
    }
}
