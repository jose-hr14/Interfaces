using System;
using System.Windows.Forms;

namespace Programa02_05
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
                nuevoFormulario = new Form2(this);
            }
            nuevoFormulario.Mensaje = textBox1.Text;
            nuevoFormulario.Mensaje2 = textBox2.Text;
            this.Hide();
            nuevoFormulario.Show();
        }
        public void setVisible(bool visible)
        {
            this.SetVisibleCore(visible);
        }
    }
}
