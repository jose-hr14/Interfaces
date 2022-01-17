using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LlenadoEnWPF
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int tiempoInt, horas, minutos, segundos;
        private double tiempoDouble, caudal, deposito;

        private void BotonLimpiar(object sender, RoutedEventArgs e)
        {
            txbCaudalAgua.Text = "";
            txbDeposito.Text = "";
            lblResultado.Content = "";
            comboUnidadesCaudal.SelectedIndex = 0;
            comboUnidadesDispositivo.SelectedIndex = 0;
        }

        private void BotonTerminar(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        public MainWindow()
        {
            InitializeComponent();

            txbCaudalAgua.Text = "";
            txbDeposito.Text = "";
            comboUnidadesCaudal.SelectedIndex = 0;
            comboUnidadesDispositivo.SelectedIndex = 0;
            lblResultado.Content = "";
        }

        private void BotonCalcular(object sender, RoutedEventArgs e)
        {
            caudal = Convert.ToDouble(txbCaudalAgua.Text);
            deposito = Convert.ToDouble(txbDeposito.Text);

            if (comboUnidadesCaudal.SelectedIndex == 0)
            {
                switch (comboUnidadesDispositivo.SelectedIndex)
                {
                    case 0:
                        tiempoDouble = deposito / caudal;
                        break;
                    case 1:
                        tiempoDouble = deposito * Math.Pow(10, 3) / caudal;
                        break;
                    case 2:
                        tiempoDouble = (deposito * Math.Pow(10, 6)) / caudal;
                        break;
                }
            }
            else if (comboUnidadesCaudal.SelectedIndex == 1)
            {
                switch (comboUnidadesDispositivo.SelectedIndex)
                {
                    case 0:
                        tiempoDouble = deposito / (caudal * Math.Pow(10, 3));
                        break;
                    case 1:
                        tiempoDouble = deposito / caudal;
                        break;
                    case 2:
                        tiempoDouble = (deposito * Math.Pow(10, 3)) / caudal;
                        break;
                }
            }
            else if (comboUnidadesCaudal.SelectedIndex == 2)
            {
                switch (comboUnidadesDispositivo.SelectedIndex)
                {
                    case 0:
                        tiempoDouble = deposito / (caudal * Math.Pow(10, 6));
                        break;
                    case 1:
                        tiempoDouble = deposito / (caudal * Math.Pow(10, 3));
                        break;
                    case 2:
                        tiempoDouble = deposito / caudal;
                        break;
                }
            }

            horas = minutos = segundos = 0;
            tiempoInt = Convert.ToInt32(tiempoDouble);
            horas = tiempoInt / 3600;
            minutos = (tiempoInt % 3600) / 60;
            segundos = (tiempoInt % 3600) % 60;

            if (tiempoDouble < 1)
            {
                lblResultado.Content = "Tiempo estimado de llenado: menos de un segundo";
            }
            else
            {
                lblResultado.Content = "Tiempo estimado de llenado: " + horas + " horas, " + minutos + " minutos y " + segundos + " segundos";
            }
        }
    }

}
    