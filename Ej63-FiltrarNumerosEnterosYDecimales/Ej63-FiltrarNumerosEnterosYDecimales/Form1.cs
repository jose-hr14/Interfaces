using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej63_FiltrarNumerosEnterosYDecimales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblNumeroProcesado.Text = "";
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if(Double.TryParse(txbNumeroProcesar.Text, out double numero))
            {
                lblNumeroProcesado.Text = txbNumeroProcesar.Text;
            }
            else
            {
                errorProvider1.SetError(txbNumeroProcesar, "No has introducido un número entero o decimal");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (!Double.TryParse(txbNumeroProcesar.Text, out double numero))
            {
                errorProvider1.SetError(txbNumeroProcesar, "No has introducido un número entero o decimal");
            }         
        }
    }
}
