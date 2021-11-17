using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej50
{
    public partial class Form1 : Form
    {
        ListViewGroup coches = new ListViewGroup("Coches", HorizontalAlignment.Center);
        ListViewGroup motos = new ListViewGroup("Motos", HorizontalAlignment.Center);
        public Form1()
        {
            InitializeComponent();
            radioButton1.Checked = true;

            listView1.Groups.Add(coches);
            listView1.Items.Add(new ListViewItem("BMW", coches));
            listView1.Items.Add(new ListViewItem("Audi", coches));
            listView1.Items.Add(new ListViewItem("Dacia", coches));
            listView1.Items.Add(new ListViewItem("Ford", coches));
            listView1.Items.Add(new ListViewItem("Honda", coches));

            listView1.Groups.Add(motos);
            listView1.Items.Add(new ListViewItem("Aprilia", motos));
            listView1.Items.Add(new ListViewItem("Benelli", motos));
            listView1.Items.Add(new ListViewItem("Cagiva", motos));
            listView1.Items.Add(new ListViewItem("Ducati", motos));
            listView1.Items.Add(new ListViewItem("Gilera", motos));            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked)
            {
                listView1.Items.Add(new ListViewItem(textBox1.Text, coches));
            }
            if (radioButton2.Checked)
            {
                listView1.Items.Add(new ListViewItem(textBox1.Text, motos));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
