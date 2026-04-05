using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace projeto_calculo_soma.Formularios
{
    public partial class navegador : Form
    {
        public navegador()
        {
            InitializeComponent();
        }

        private void navegador_Load(object sender, EventArgs e)
        {
            webBrowser1.ScriptErrorsSuppressed = true;
            webBrowser1.Navigate("https://duckduckgo.com/");
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Pesquisar(txtNavigator.Text);
        }

        private void txtNavigator_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void Pesquisar(string url)
        {
            if(txtNavigator.Text != " ")
            {
                webBrowser1.Navigate(url);
            }
            else 
            {
                MessageBox.Show("Digite alguma coisa na barra de endereço");
               txtNavigator.Focus();
            }
        }

        private void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            txtNavigator.Text = webBrowser1.Url.ToString();
        }

        private void txtNavigator_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Pesquisar(txtNavigator.Text);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
           Pesquisar(webBrowser1.Url.ToString());
        }
    }
}
