using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej45
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listBox1.Items.Add("Memoria RAM");
            listBox1.Items.Add("Disco duro");
            label1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            label1.Text = textBox1.Text;
            listBox1.SelectedIndex = listBox1.Items.Count - 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex != -1)
            {
                int index = listBox1.SelectedIndex - 1;
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                listBox1.SelectedIndex = index;
                if (listBox1.Items.Count > 0)
                    label1.Text = listBox1.SelectedItem.ToString();
                else
                    label1.Text = "";
            }                
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
                label1.Text = listBox1.SelectedItem.ToString();
        }
    }
}
