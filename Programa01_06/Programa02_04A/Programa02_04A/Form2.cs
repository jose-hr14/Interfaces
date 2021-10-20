using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa02_04A
{
    public partial class Form2 : Form
    {
        Form1 formulario1;
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(Form1 formulario1)
        {
            InitializeComponent();
            this.formulario1 = formulario1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formulario1.Mensaje01 = txbMensaje01.Text;
            formulario1.Mensaje02 = txbMensaje02.Text;
        }
    }
}
