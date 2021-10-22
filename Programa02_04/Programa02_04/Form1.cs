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
    public partial class Form1 : Form
    {
        Form2 nuevoFormulario;
        public Form1()
        {
            InitializeComponent();
            nuevoFormulario = new Form2();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.Count == 1)
            {
                nuevoFormulario = new Form2();
            }
            nuevoFormulario.Mensaje = textBox1.Text;
            nuevoFormulario.Mensaje2 = textBox2.Text;
            nuevoFormulario.Show();
        }
    }
}
