using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa01_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblNombre.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblNombre.Text = "Hola " + txbNombre.Text.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lblNombre.Text = "Adios " + txbNombre.Text.ToString();
        }
    }
}
