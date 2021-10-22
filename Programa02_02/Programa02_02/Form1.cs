using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa02_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Que abra otro formulario, lo abre en un mudo que no te deja regresar al anterior hasta que cierres el segundo
            //Form.ShowDialog
            Form2 formulario = new Form2();
            formulario.ShowDialog();            
            //formulario.Show();            
        }
    }
}
