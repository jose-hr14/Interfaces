using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraLlenado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label3.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Text = "Tiempo estimado requerido para el llenado: ";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label3.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private double cm3dm3(double cantidad)
        {
            return cantidad / 1000;
        }
        private double cm3m3(double cantidad)
        {
            return cantidad / 1000 / 1000;
        }
        private double dm3cm3(double cantidad)
        {
            return cantidad * 1000;
        }
        private double dm3m3(double cantidad)
        {
            return cantidad / 1000;
        }
        private double m3dm3(double cantidad)
        {
            return cantidad / 1000;
        }
    }
}
