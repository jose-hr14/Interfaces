using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa02_04
{
    public partial class Form2 : Form
    {
        private string mensaje;
        private Form1 formulario1;
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(Form1 formulario)
        {
            InitializeComponent();
            formulario = formulario1;
        }
        public Form2(string cadena)
        {
            InitializeComponent();
            lblParametro.Text = cadena;
        }
        public string Mensaje
        {
            get
            {
                return mensaje;
            }
            set
            {
                mensaje = value;
                lblParametro.Text = mensaje;
            }
        }
       
    }
}
