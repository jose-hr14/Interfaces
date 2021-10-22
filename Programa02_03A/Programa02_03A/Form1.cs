using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa02_03A
{
    public partial class Form1 : Form
    {
        string cadena1;
        string cadena2;

        public string getCadena1()
        {
            return cadena1;
        }
        public string getCadena2()
        {
            return cadena2;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cadena1 = textBox1.Text;
            cadena2 = textBox2.Text;
            Form2 nuevoFormulario = new Form2(cadena1, cadena2);
            nuevoFormulario.ShowDialog();
        }
    }
}
