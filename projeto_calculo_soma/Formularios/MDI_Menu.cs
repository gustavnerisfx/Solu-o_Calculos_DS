using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace projeto_calculo_soma.Formularios
{
    public partial class MDI_Menu : Form
    {
        public MDI_Menu()
        {
            InitializeComponent();
        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void MDI_Menu_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            foreach (Form filho in this.MdiChildren)
            {
                if (filho is CalculadoraSoma)
                {
                    filho.Focus();
                    return;
                }
            }

            CalculadoraSoma objCalBot = new CalculadoraSoma();
            objCalBot.MdiParent = this;
            objCalBot.Show();
        }

        private void comBotõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form filho in this.MdiChildren)
            {
                if (filho is CalculadoraSoma)
                {
                    filho.Focus();
                    return;
                }
            }

            CalculadoraSoma objCalBot = new CalculadoraSoma();
            objCalBot.MdiParent = this;
            objCalBot.Show();
        }

        private void MDI_Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja sair?", "Saindo...", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void staDataHora_Click(object sender, EventArgs e)
        {

        }

        private void staMensagem_Click(object sender, EventArgs e)
        {

        }

        private void staUsuario_Click(object sender, EventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            staDataHora.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void comRadioButtonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form filho in this.MdiChildren)
            {
                if (filho is frmRadio)
                {
                    filho.Focus();
                    return;
                }
            }

            frmRadio objCalBot = new frmRadio();
            objCalBot.MdiParent = this;
            objCalBot.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            foreach (Form filho in this.MdiChildren)
            {
                if (filho is frmRadio)
                {
                    filho.Focus();
                    return;
                }
            }

            frmRadio objCalBot = new frmRadio();
            objCalBot.MdiParent = this;
            objCalBot.Show();
        }

        private void cascataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);

        }

        private void horizontalmenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void verticalmenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void blocoDeNotasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("notepad.exe");
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("Calc.exe");
        }

        private void webToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://duckduckgo.com/",
                UseShellExecute = true
            });
        }

        private void calculadoraPropriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form filho in this.MdiChildren)
            {
                if (filho is calculadorapropia)
                {
                    filho.Focus();
                    return;
                }
            }

            calculadorapropia objCalBot = new calculadorapropia();
            objCalBot.MdiParent = this;
            objCalBot.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            foreach (Form filho in this.MdiChildren)
            {
                if (filho is calculadorapropia)
                {
                    filho.Focus();
                    return;
                }
            }

            calculadorapropia objCalBot = new calculadorapropia();
            objCalBot.MdiParent = this;
            objCalBot.Show();
        }

        private void desenvolvedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "Gustavo Neris Silva, Lucas Lozano Marsola"; 
            string title = "Desenvolvedores";
            MessageBox.Show(message, title);
        }

        private void navegadorLocalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form filho in this.MdiChildren)
            {
                if (filho is navegador)
                {
                    filho.Focus();
                    return;
                }
            }

            navegador objCalBot = new navegador();
            objCalBot.Show();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            foreach (Form filho in this.MdiChildren)
            {
                if (filho is navegador)
                {
                    filho.Focus();
                    return;
                }
            }

            navegador objCalBot = new navegador();
            objCalBot.Show();
        }
    }
}
