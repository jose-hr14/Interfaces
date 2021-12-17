using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej06_05FlowLayout
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            for(int i = 1; i < 21; i++)
            {
                Button btnButton = new Button();
                btnButton.Name = "btnDentroDelFLP " + i;
                btnButton.Text = "Botón" + i;
                btnButton.Width = 58; 
                btnButton.Height = 24;

                flpBotones.Controls.Add(btnButton);
            }
        }
    }
}
