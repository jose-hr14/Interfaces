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

namespace Programa07_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            lblProcesado1.Text = "";
            lblProcesado2.Text = "";

            //mktxbNombre.Mask = "LLLLL"; //obligatorio
            //mktxbEdad.Mask = "00"; //obligatorio

            mktxbNombre.Mask = "?????"; //opcional
            mktxbEdad.Mask = "99"; //opcional

            mktxbNombre.PromptChar = ' '; //ocultar la vista previal del masked textbox
            mktxbEdad.PromptChar = ' '; //ocultar la vista previal del masked textbox
        }

        private void btnProcesar1_Click(object sender, EventArgs e)
        {
            if(mktxbNombre.Text.Length > 0 && mktxbEdad.Text.Length > 0)
            {
                lblProcesado1.Text = mktxbNombre.Text + " tiene una edad de " + mktxbEdad.Text;
            }
        }

        private void btnProcesar2_Click(object sender, EventArgs e)
        {
            if (txbNombre1.Text.Length > 0 && txbEdad1.Text.Length > 0)
            {
                lblProcesado2.Text = mktxbNombre.Text + " tiene una edad de " + mktxbEdad.Text;
            }
        }

        private void txbNombre1_KeyPress(object sender, KeyPressEventArgs e)
        {
            txbNombre1.MaxLength = 5; //Para limitar los carácteres a 5

            bool esNombreCorrecto;

            esNombreCorrecto = Regex.IsMatch(e.KeyChar.ToString(), "^[a-z|A-Z]$");

            //tecla 8 es tecla de borrar, y el 32 es el espacio en blanco
            //se permitirá escribir 
            if(esNombreCorrecto || e.KeyChar == (char)8 || e.KeyChar == (char)32)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txbEdad1_KeyPress(object sender, KeyPressEventArgs e)
        {
            txbEdad1.MaxLength = 2; //Para limitar los carácteres a 5

            bool noEsEdadCorrecta;

            //esNombreCorrecto = Regex.IsMatch(e.KeyChar.ToString(), "^[^0-9]$"); cuando ponemos el ^, significa el contrario, como el ! de los bool
            noEsEdadCorrecta = Regex.IsMatch(e.KeyChar.ToString(), "^[^0-9]$");

            //tecla 8 es tecla de borrar, y el 32 es el espacio en blanco
            //se permitirá escribir 
            if (noEsEdadCorrecta && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }
    }
}
