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
    public partial class navegador : Form
    {
        public navegador()
        {
            InitializeComponent();

        }

        private void navegador_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://duckduckgo.com/");
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(txtNavigator.Text);
        }

        private void txtNavigator_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
