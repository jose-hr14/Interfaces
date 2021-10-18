using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa02_03B
{
    public partial class Form2 : Form
    {
        private string mensaje1; //siempre privada
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(string cadena)
        {            
            InitializeComponent();
            lblParametros.Text = cadena;
        }
        public string Mensaje//es una propiedad, publica
        {
            //get
            //{
            //    return mensaje1;
            //}
            set
            {
                mensaje1 = value;
                lblPropiedades.Text = mensaje1;
            }
        }
    }
}
