using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej60_TextoColorinesConBoton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
			lblTextoPrueba.ForeColor = Color.Chocolate;
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.ShowDialog();
            Color color =  colorDialog.Color;
            lblTextoPrueba.ForeColor = color;
        }
    }
}
