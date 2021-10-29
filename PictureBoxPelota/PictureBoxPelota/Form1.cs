﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace PictureBoxPelota
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


            avanceHaciaLaDerecha = numAleatorio.Next(0, 3);
            avanceHaciaLaAbajo = numAleatorio.Next(0, 3);
            if(derecha)
                pictureBox1.Left = pictureBox1.Left + avanceHaciaLaDerecha;
            if(izquierda)
                pictureBox1.Left = pictureBox1.Left - avanceHaciaLaDerecha;
            if (abajo)
                pictureBox1.Top = pictureBox1.Top + avanceHaciaLaAbajo;

            if(arriba)
                pictureBox1.Top = pictureBox1.Top - avanceHaciaLaAbajo;

            if (pictureBox1.Top == this.Height - pictureBox1.Height)
            {
                arriba = true;
                abajo = false;
            }
            if (pictureBox1.Left == this.Width - pictureBox1.Width)
            {
                derecha = false;
                izquierda = true;
            }
            if(pictureBox1.Top == 0)
            {
                arriba = false;
                abajo = true;
            }
        }
    }
}
