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
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form2 formulario2 = new Form2(txbParametros.Text);
            formulario2.Mensaje = txbPropiedades.Text;
            formulario2.ShowDialog();
        }
    }
}
