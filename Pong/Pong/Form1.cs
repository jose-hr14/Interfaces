using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pong
{
    public partial class Form1 : Form
    {
        private Random numAleatorio;
        bool arriba = false;
        bool abajo = true;
        bool derecha = true;
        bool izquierda = false;
        public Form1()
        {
            InitializeComponent();
            numAleatorio = new Random();            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int avanceHaciaLaDerecha = 0;
            int avanceHaciaLaAbajo = 0;


            avanceHaciaLaDerecha = numAleatorio.Next(3, 6);
            avanceHaciaLaAbajo = numAleatorio.Next(3, 6);

            if (derecha)
                pictureBox1.Left = pictureBox1.Left + avanceHaciaLaDerecha;
            if (izquierda)
                pictureBox1.Left = pictureBox1.Left - avanceHaciaLaDerecha;
            if (abajo)
                pictureBox1.Top = pictureBox1.Top + avanceHaciaLaAbajo;
            if (arriba)
                pictureBox1.Top = pictureBox1.Top - avanceHaciaLaAbajo;

            if (pictureBox1.Location.Y > this.Height - (pictureBox1.Height + 10))
            {
                arriba = true;
                abajo = false;
            }
            if (pictureBox1.Location.X > this.Width - (pictureBox1.Width - 17))
            {
                timer1.Enabled = false;
                derecha = false;
                izquierda = true;                
            }
            if (pictureBox1.Location.Y < 0)
            {
                arriba = false;
                abajo = true;                
            }
            if (pictureBox1.Location.X < 0 - pictureBox1.Width - 15)
            {
                timer1.Enabled = false;
                derecha = true;
                izquierda = false;               
            }
            if(pictureBox1.Location.X < pictureBox3.Location.X && pictureBox1.Location.Y < pictureBox3.Location.Y)
            {
                derecha = false;
                izquierda = true;
            }
        }

        private void Form1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if(e.KeyData == Keys.Enter && timer1.Enabled == false)
            {
                pictureBox1.Location = new Point(256, 96);
                timer1.Enabled = Enabled;
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox3.Top = MousePosition.Y - 60;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (timer1.Enabled == false)
            {
                pictureBox1.Location = new Point(256, 96);
                timer1.Enabled = Enabled;
            }
        }
    }
}
