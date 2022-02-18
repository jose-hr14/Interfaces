using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Febrero04_Access
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLibros_Click(object sender, EventArgs e)
        {
            Libros libros = new Libros(this);
            this.Hide();
            libros.Show();
        }

        private void btnLibreria_Click(object sender, EventArgs e)
        {
            Libreria libreria = new Libreria(this);
            this.Hide();
            libreria.Show();
        }

        private void btnAutores_Click(object sender, EventArgs e)
        {

        }
    }
}
