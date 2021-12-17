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

namespace ProgWPF01
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            btnXAML.Click += new RoutedEventHandler(BtnXAML_Click);
            MostrarlblCSharp();
        }

        private void MostrarlblCSharp()
        {
            Label lblCSharp = new Label();            
            lblCSharp.Content = "Etiqueta creada desde CSharp";
            lblCSharp.HorizontalAlignment = HorizontalAlignment.Left;
            lblCSharp.VerticalAlignment = VerticalAlignment.Top;
            lblCSharp.Margin = new Thickness(429, 132, 0, 0);
            griRejilla.Children.Add(lblCSharp);
        }

        private void btnCuadroHerramientas_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Se ha pulsado el botón creado desde el cuadro de herramientas");
        }
        private void BtnXAML_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Se ha pulsado el botón creado desde XAML");
        }
    }
}
