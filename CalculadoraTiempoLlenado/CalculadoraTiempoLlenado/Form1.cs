using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraTiempoLlenado
{
    public partial class Form1 : Form
    {
        private int tiempoInt, horas, minutos, segundos;
        private double tiempoDouble, caudal, deposito;

        public Form1()
        {
            InitializeComponent();
            lblTiempoEstimado.Text = "";
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            caudal = Convert.ToDouble(txbCaudal.Text);
            deposito = Convert.ToDouble(txbDeposito.Text);

            if(cbCaudal.SelectedIndex == 0)
            {
                switch(cbDeposito.SelectedIndex)
                {
                    case 0: tiempoDouble = deposito / caudal;
                        break;
                    case 1: tiempoDouble = deposito * Math.Pow(10, 3) / caudal;
                        break;
                    case 2: tiempoDouble = (deposito * Math.Pow(10, 6)) / caudal;
                        break;
                }  
            }
            else if(cbCaudal.SelectedIndex == 1)
            {
                switch(cbDeposito.SelectedIndex)
                {
                    case 0: tiempoDouble = deposito / (caudal * Math.Pow(10, 3));
                        break;
                    case 1: tiempoDouble = deposito / caudal;
                        break;
                    case 2: tiempoDouble = (deposito * Math.Pow(10, 3)) / caudal;
                        break;
                }
            }
            else if(cbCaudal.SelectedIndex == 2)
            {
                switch(cbDeposito.SelectedIndex)
                {
                    case 0: tiempoDouble = deposito / (caudal * Math.Pow(10, 6));
                        break;
                    case 1: tiempoDouble = deposito / (caudal * Math.Pow(10, 3));
                        break;
                    case 2: tiempoDouble = deposito / caudal;
                        break;
                }
            }

            horas = minutos = segundos = 0;
            tiempoInt = Convert.ToInt32(tiempoDouble);
            horas = tiempoInt / 3600;
            minutos = (tiempoInt % 3600) / 60;
            segundos = (tiempoInt % 3600) % 60;

            if(tiempoDouble < 1)
            {
                lblTiempoEstimado.Text = "Tiempo estimado de llenado: menos de un segundo";
            }
            else
            {
                lblTiempoEstimado.Text = "Tiempo estimado de llenado: " + horas + " horas, " + minutos + " minutos y " + segundos + " segundos";
            }
        }

        private void btnTerminar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txbCaudal.Text = "";
            txbDeposito.Text = "";
            cbCaudal.Text = "Seleccionar";
            cbDeposito.Text = "Seleccionar";
        }
    }
}
