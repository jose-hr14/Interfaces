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

namespace Ej31_TablaMultiplicarWindowsForms
{
    //Funcion para filtrar el número con regex, un solo dígito
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Regex numRegex = new Regex("^[1-9]{1}$");
            string texto = "";

            if(numRegex.IsMatch(textBox1.Text))
            {
                int num = Convert.ToInt32(textBox1.Text);
                for(int i = 1; i <= 10; i++)
                {
                    texto += num + " * " + i + " = " + (num * i) + "\r\n";
                    Console.WriteLine(num + " * " + i + " = " + (num * i));
                }
                textBox2.Text = texto;
            }
            
        }
    }
}
