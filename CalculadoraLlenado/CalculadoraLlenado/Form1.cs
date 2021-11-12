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
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            /*
             * horas = tiempollenado entero / 3600;
             * minutos = tiempollenadoentero % 3600 / 60;
             * segundos = tiempollenadoentero % 3600 % 60;
             */
            // 250cm3/seg y 50dm3 = 0horas 33 minuts 20 segundos
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int tiempoLlenado = Convert.ToInt32(textBox2.Text) / Convert.ToInt32(conversion());
            double horas = (Convert.ToInt32(textBox2.Text) / Convert.ToInt32(textBox1.Text)) / 3600;
            double minutos = tiempoLlenado % 3600 / 60;
            double segundos = tiempoLlenado % 3600 % 60;
            label3.Text = "Tiempo estimado requerido para el llenado: " + horas + " horas " + minutos + " minutos " + segundos + " segundos";
        }
        private double conversion()
        {
            double resultado = 0;
            switch(comboBox1.SelectedItem.ToString())
            {
                case "cm3/seg":
                switch(comboBox2.SelectedItem.ToString())
                    {
                        case "cm3":
                            resultado = Convert.ToInt32(textBox1.Text.ToString());
                            break;
                        case "dm3":
                            resultado = cm3dm3(Convert.ToInt32(textBox1.Text.ToString()));
                            break;
                        case "m3":
                            resultado = cm3m3(Convert.ToInt32(textBox1.Text.ToString()));
                            break;
                    }
                    break;
                case "dm3/seg":
                    switch (comboBox2.SelectedItem.ToString())
                    {
                        case "cm3":
                            resultado = dm3cm3(Convert.ToInt32(textBox1.Text.ToString()));
                            break;
                        case "dm3":
                            resultado = Convert.ToInt32(textBox1.Text.ToString());
                            break;
                        case "m3":
                            resultado = dm3m3(Convert.ToInt32(textBox1.Text.ToString()));
                            break;
                    }
                    break;
                case "m3/seg":
                    switch (comboBox2.SelectedItem.ToString())
                    {
                        case "cm3":
                            resultado = m3cm3(Convert.ToInt32(textBox1.Text.ToString()));
                            break;
                        case "dm3":
                            resultado = m3dm3(Convert.ToInt32(textBox1.Text.ToString()));
                            break;
                        case "m3":
                            resultado = Convert.ToInt32(textBox1.Text.ToString());
                            break;
                    }
                    break;
            }
            return resultado;
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
            return cantidad * 1000;
        }
        private double cm3m3(double cantidad)
        {
            return cantidad * 1000 * 1000;
        }
        private double dm3cm3(double cantidad)
        {
            return cantidad / 1000;
        }
        private double dm3m3(double cantidad)
        {
            return cantidad * 1000;
        }
        private double m3dm3(double cantidad)
        {
            return cantidad / 1000;
        }
        private double m3cm3(double cantidad)
        {
            return cantidad / 1000 / 1000;
        }
    }
}
