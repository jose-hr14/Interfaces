using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej48
{
    public partial class Form1 : Form
    {
        int contador = -1;
        public Form1()
        {
            InitializeComponent();
            label1.Text = "";
            
            
            //profundidad de color de 32 bits
            //image size 1-256, 256x291
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(contador < imageList1.Images.Count - 1)
            {
                contador++;
                label1.Image = imageList1.Images[contador];
            }
            if (contador == imageList1.Images.Count - 1)
                contador = -1;
        }
    }
}
