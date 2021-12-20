using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa07_01A
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            lblNumeroMostrado.Text = "";
        }

        private void btnMostrarNumero_Click(object sender, EventArgs e)
        {
            if (float.TryParse(txbNumero.Text, out float numero))
                lblNumeroMostrado.Text = txbNumero.Text;
            else
                lblNumeroMostrado.Text = "No has introducido un número válido";
        }
    }
}
