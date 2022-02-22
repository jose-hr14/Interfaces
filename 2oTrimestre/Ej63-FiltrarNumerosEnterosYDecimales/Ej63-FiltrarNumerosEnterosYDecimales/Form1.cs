using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej63_FiltrarNumerosEnterosYDecimales
{    
    public partial class Form1 : Form
    {
        private bool esCorrecto;
        public Form1()
        {
            InitializeComponent();
            lblNumeroProcesado.Text = "";
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            //Regex regex = new  Regex("^[0-9999999]([,][0000001-9999999])$");
            //Regex regex = new Regex("^[0-9]+$");
            Regex regex = new Regex("^[0-9]{1,}([,][0-9]{1,}){0,1}$");
            if (regex.IsMatch(txbNumeroProcesar.Text))
            {
                lblNumeroProcesado.Text = txbNumeroProcesar.Text;
            }
            else
            {
                lblNumeroProcesado.Text = "No has introducido un número entero o decimal";
            }
            //errorProvider1.Clear();
            //if(Double.TryParse(txbNumeroProcesar.Text, out double numero))
            //{
            //    lblNumeroProcesado.Text = txbNumeroProcesar.Text;
            //}
            //else
            //{
            //    errorProvider1.SetError(txbNumeroProcesar, "No has introducido un número entero o decimal");
            //}
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            Regex regex = new Regex("^[0-9]{1,}([,][0-9]{1,}){0,1}$");
            if (!regex.IsMatch(txbNumeroProcesar.Text))
            {
                errorProvider1.SetError(txbNumeroProcesar, "No has introducido un número entero o decimal");
            }
            //errorProvider1.Clear();
            //if (!Double.TryParse(txbNumeroProcesar.Text, out double numero))
            //{
            //    errorProvider1.SetError(txbNumeroProcesar, "No has introducido un número entero o decimal");
            //}         
        }
    }
}
