using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej44
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Text = "";
            domainUpDown1.Items.Add("Memoria RAM");
            domainUpDown1.Items.Add("Placa base");
            domainUpDown1.Text = "Componentes";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            domainUpDown1.Items.Add(textBox1.Text);
            domainUpDown1.SelectedIndex = domainUpDown1.Items.Count - 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(domainUpDown1.SelectedIndex != -1)
            {
                domainUpDown1.Items.RemoveAt(domainUpDown1.SelectedIndex);
                if (domainUpDown1.Items.Count > 0)
                    domainUpDown1.SelectedIndex = 0;
                else
                {
                    domainUpDown1.Text = "";
                    label1.Text = "";
                }                                  
            }            
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {
            if(domainUpDown1.SelectedIndex != -1)
                label1.Text = "Usted ha seleccionado " + domainUpDown1.SelectedItem.ToString();
        }
    }
}
