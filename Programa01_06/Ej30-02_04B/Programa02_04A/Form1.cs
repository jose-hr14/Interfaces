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
    public partial class Form1 : Form
    {
        string mensaje01;
        string mensaje02;
        Form2 formulario2;
        public Form1()
        {
            InitializeComponent();
            lblMensaje01.Text = "";
            lblMensaje02.Text = "";
        }
        public string Mensaje01
        {
            get
            {
                return this.mensaje01;
            }
            set
            {
                this.mensaje01 = value;
                lblMensaje01.Text = mensaje01;
            }
        }
        public string Mensaje02
        {
            get
            {
                return this.mensaje02;
            }
            set
            {
                this.mensaje02 = value;
                lblMensaje02.Text = mensaje02;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult;
            
            formulario2 = new Form2(this);                          
                
            dialogResult = formulario2.ShowDialog();

            if(dialogResult == DialogResult.OK)
            {
                lblMensaje01.Text = mensaje01;
                lblMensaje02.Text = mensaje02;
                formulario2.Close();
            }
            if(dialogResult == DialogResult.Cancel)
            {
                formulario2.Close();
                MessageBox.Show("Envío cancelado");

            }
        }
    }
}
