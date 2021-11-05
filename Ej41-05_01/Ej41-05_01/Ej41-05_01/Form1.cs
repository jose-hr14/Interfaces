using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej41_05_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            checkedListBox1.Items.Add("Memoria RAM");
            checkedListBox1.Items.Add("Disco duro", true);            
            //checkedListBox1.SetItemChecked(3, true);
            label1.Text = "";
            label2.Text = "";
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Text = checkedListBox1.SelectedIndex.ToString();
            label2.Text = checkedListBox1.SelectedItem.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            checkedListBox1.Items.Add(textBox1.Text);
            

            
        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.Index == 2 && e.NewValue == CheckState.Checked)
                MessageBox.Show("Tenemos memoria RAM");         
        }
    }
}
