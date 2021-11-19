using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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
            groupBox1.Text = "Vehículos";

            string[] archivos = Directory.GetFiles("Imagenes");
            ImageList imageLists = new ImageList();
            foreach (string archivo in archivos)
            {
                imageLists.Images.Add(Image.FromFile(archivo));
            }


            //ImageList imageList = new ImageList();
            //imageList.ImageSize = new Size(50, 50);
            //imageList.Images.Add(Image.FromFile("bmw.png"));
            //imageList.Images.Add(Image.FromFile("audi.png"));
            //imageList.Images.Add(Image.FromFile("dacia.jpg"));
            //imageList.Images.Add(Image.FromFile("ford.png"));
            //imageList.Images.Add(Image.FromFile("honda.jpg"));
            imageLists.ImageSize = new Size(50, 50);
            listView1.LargeImageList = imageLists;


            listView1.Groups.Add(coches);
            listView1.Items.Add(new ListViewItem("BMW", 0, coches));
            listView1.Items.Add(new ListViewItem("Audi", 1, coches));
            listView1.Items.Add(new ListViewItem("Dacia", 2, coches));
            listView1.Items.Add(new ListViewItem("Ford", 3, coches));
            listView1.Items.Add(new ListViewItem("Honda", 4, coches));

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

        private void button2_Click_1(object sender, EventArgs e)
        {
            listView1.Items.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listView1.SelectedItems[0].Remove();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listView1.SelectedItems[0].Text = textBox1.Text;
            listView1.SelectedItems[0].ImageIndex = Convert.ToInt32(textBox2.Text);
        }
    }
}
