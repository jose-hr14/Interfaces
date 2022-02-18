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

namespace Febrero03_AccessCon_WPF
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            // this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnLibrosClick(object sender, RoutedEventArgs e)
        {
            this.Hide();
            WindowLibros windowLibros = new WindowLibros(this);
            windowLibros.Show();
        }

        private void btnLibrería_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            WindowLibreria windowLibreria = new WindowLibreria(this);
            windowLibreria.Show();
        }
    }
}
