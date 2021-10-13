using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa01_03M
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
            calculadora("suma");
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            calculadora("resta");
        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            calculadora("multiplicacion");
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            calculadora("division");
        }


        public int suma(int a, int b)
        {
            return a + b;
        }
        public int resta(int a, int b)
        {
            return a - b;
        }
        public int multiplicacion(int a, int b)
        {
            return a * b;
        }
        public int division(int a, int b)
        {
            if (b != 0)
                return a / b;
            else
                return 0;
        }
        public void funcionSumar()
        {
            if (int.TryParse(txtbA.Text, out int a) && int.TryParse(txtbB.Text, out int b))
            {
                lblResultado.Text = suma(a, b).ToString();
            }
            else
            {
                lblResultado.Text = "Alguno de los parámetros introducidos no es válido";
            }
        }
        public void funcionRestar()
        {
            if (int.TryParse(txtbA.Text, out int a) && int.TryParse(txtbB.Text, out int b))
            {
                lblResultado.Text = resta(a, b).ToString();
            }
            else
            {
                lblResultado.Text = "Alguno de los parámetros introducidos no es válido";
            }
        }
        public void funcionMultiplicar()
        {
            if (int.TryParse(txtbA.Text, out int a) && int.TryParse(txtbB.Text, out int b))
            {
                lblResultado.Text = multiplicacion(a, b).ToString();
            }
            else
            {
                lblResultado.Text = "Alguno de los parámetros introducidos no es válido";
            }
        }
        public void funcionDividir()
        {
            if (int.TryParse(txtbA.Text, out int a) && int.TryParse(txtbB.Text, out int b))
            {
                if (b != 0)
                    lblResultado.Text = division(a, b).ToString();
                else
                    lblResultado.Text = "No puedes dividir entre 0";
            }
            else
            {
                lblResultado.Text = "Alguno de los parámetros introducidos no es válido";
            }
        }
        public void calculadora(string operacion)
        {
            switch(operacion)
            {
                case "suma":
                    funcionSumar();
                    break;
                case "resta":
                    funcionRestar();
                    break;
                case "multiplicacion":
                    funcionMultiplicar();
                    break;
                case "division":
                    funcionDividir();
                    break;
            }
        }
    }
}
