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
        public calculadorapropia()
        {
            InitializeComponent();
        }

        private void f_digitos(object sender, EventArgs e)
        {
            string digitos = ((Button)sender).Text;
            if(lblVisor.Text == "0")
            {
                lblVisor.Text = "";
            }
            lblVisor.Text += digitos;
        }


        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {

        }
    }
}
