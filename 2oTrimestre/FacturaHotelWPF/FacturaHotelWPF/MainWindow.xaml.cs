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

namespace FacturaHotelWPF
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    /// 75 euros la habitacion por noche, invidual, en doble 125 y la suite 200
    /// desayuno 15 euros, almuerzo 40
    /// Factura de la estancioa en el hotel
    /// Nombre del cliente: Pedro Pérez García
    /// Habitación doble: 125€ por noche
    /// Almuerzo: 40€ al día
    /// Número de días de estancia: 3
    /// El total a pagar es de 495€
    /// el textbox del nombre de cliente tiene que sacarte un cuadrito con "inserte aquí nombre cliente", grande y en rojo, en 3 líneas
    /// En el numero de días, hay que poner otro cuadrito con inserte aqui el numero de días
    /// El boton de facturas debe de poder pulsarse con Alt + F,
    /// al usar tabulador, recorrer todos los controles menos el textbox final, que será solo de lectura
    /// Al menos un radio botón del tipo de habitación debe de estar pulsado
    /// alt c, alt d, alt f
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();            
        }

        private void PulsarBotonFactura(object sender, RoutedEventArgs e)
        {            
            string nombreCliente = txbNombre.Text;
            string habitacion = "";
            string comida = "";
            int numDias;
            if (int.TryParse(txbNumeroDias.Text, out int numDiasInt) && numDiasInt > 0)
            {
                numDias = numDiasInt;
                int costeFactura = 0;
                string factura = "Factura de la estancia en el hotel \n";
                factura += "Nombre del cliente: " + nombreCliente + "\n";

                if ((bool)radioIndividual.IsChecked)
                {
                    habitacion = "Habitación individual: 75€ por noche \n";
                    costeFactura += 75;
                }
                else if ((bool)radioDoble.IsChecked)
                {
                    habitacion = "Habitación doble: 125€ por noche \n";
                    costeFactura += 125;
                }
                else if ((bool)radioSuite.IsChecked)
                {
                    habitacion = "Habitación suite: 200€ por noche \n";
                    costeFactura += 200;
                }
                factura += habitacion;

                if ((bool)checkDesayuno.IsChecked)
                {
                    comida += "Desayuno: 15€ al día \n";
                    costeFactura += 40;
                }
                if ((bool)checkAlmuerzo.IsChecked)
                {
                    comida += "Almuerzo: 40€ al día \n";
                    costeFactura += 15;
                }

                factura += comida;

                factura += "Número de días de estancia: " + numDiasInt + "\n";
                factura += "El total a pagar es de: " + costeFactura;

                if (nombreCliente != "")
                {
                    txbFactura.Text = factura;
                }
            }
            else
            {
                MessageBox.Show("Se debe de escribir una cifra numérica distinta de 0", "Atención", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}
