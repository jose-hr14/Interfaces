using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa01_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblResultado.Text = "";
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            if(int.TryParse(txtbA.Text, out int a) && int.TryParse(txtbB.Text, out int b))
            {
                lblResultado.Text = (a + b).ToString();
            }
            else
            {
                lblResultado.Text = "Alguno de los parámetros introducidos no es válido";
            }
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtbA.Text, out int a) && int.TryParse(txtbB.Text, out int b))
            {
                lblResultado.Text = (a - b).ToString();
            }
            else
            {
                lblResultado.Text = "Alguno de los parámetros introducidos no es válido";
            }
        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtbA.Text, out int a) && int.TryParse(txtbB.Text, out int b))
            {
                lblResultado.Text = (a * b).ToString();
            }
            else
            {
                lblResultado.Text = "Alguno de los parámetros introducidos no es válido";
            }
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtbA.Text, out int a) && int.TryParse(txtbB.Text, out int b))
            {
                if (b != 0)
                    lblResultado.Text = (a / b).ToString();
                else
                    lblResultado.Text = "No puedes dividir entre 0";
            }
            else
            {
                lblResultado.Text = "Alguno de los parámetros introducidos no es válido";
            }
        }
    }
}
