using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
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
using System.Windows.Shapes;

namespace Febrero03_AccessCon_WPF
{
    /// <summary>
    /// Lógica de interacción para WindowLibros.xaml
    /// </summary>
    /// 
    /*
     * from accesstalibros innerjoin accesstalibreria on 
     * accesstalibreria.isbn = access_talibros.isbn
     * agregar, buscar, modificar, eliminar, limpiar, salir
     * conexionConLaBD = new SqlConnection(@"server=Aula1418; database = sql_dbPersonas; integrated security = false; User Id = usutarde; Password = 7722");
     * el siguiente es como este, pro con tres tablas. la tabla autores(dni, nombre, apellido1, apellido2, dni es clave, que conecta con la tabla 
     * de accesstalibros, con el campo dni de talibros, que a su vez conecta con accesstalibreria, desde el campo isbn
     * autores: dni, nombre, apellido1, apellido2
     * libros: isbn, titulo, editorial, dni
     * libreria: isbn, cantidad, precio
     * en la pantalla libros, mostramos el nombre y apellidos de los autores, con una join de libros y autores, sin mostrar dni, que es lo que conecta ambas tablas
     * en libros, solo podemos modificar el dni del autor de ese libro, y agregar libros a ese autor, esta pantalla solo muestra libros con autor
     * solo podemos borrar autores que no tengan libros
     * En Libraria, mostramos isbn, titulo, cantidad y precio
     */
    public partial class WindowLibros : Window
    {
        MainWindow mainWindow;
        OleDbConnection conexionConLaBD;
        public WindowLibros(MainWindow mainWindow)
        {
            InitializeComponent();
            dtgLibros.CanUserAddRows = false;
            dtgLibros.CanUserDeleteRows = false;
            dtgLibros.IsReadOnly = true;

            conexionConLaBD = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;
            Data Source=C:\Users\José\Documents\GitHub\Interfaces\Febrero03_AccessCon WPF\Access_DbLibros.accdb");
            rellenarTabla();
            this.mainWindow = mainWindow;
        }

        public void rellenarTabla()
        {
            string cadenaSql = @"
                SELECT *
                FROM Access_TaLibros";
            OleDbDataAdapter puenteConLaTabla = new OleDbDataAdapter(cadenaSql, conexionConLaBD);
            DataTable tablaDeLaBD = new DataTable();
            puenteConLaTabla.Fill(tablaDeLaBD);
            dtgLibros.ItemsSource = tablaDeLaBD.DefaultView;
        }

        public void guardarRegistro()
        {
            string cadenaSql = $@"
                                 INSERT INTO Access_TaLibros
                                 (Isbn, Título, Editorial, Nombre, Apellido1, Apellido2)
                                 VALUES
                                 (@Isbn, @Título, @Editorial, @Nombre, @Apellido1, @Apellido2);";
            OleDbCommand instruccionesSql = new OleDbCommand(cadenaSql, conexionConLaBD);
            instruccionesSql.Parameters.AddWithValue("@Isbn", txbIsbn.Text);
            instruccionesSql.Parameters.AddWithValue("@Título", txbTitulo.Text);
            instruccionesSql.Parameters.AddWithValue("@Editorial", txbEditorial.Text);
            instruccionesSql.Parameters.AddWithValue("@Nombre", txbNombre.Text);
            instruccionesSql.Parameters.AddWithValue("@Apellido1", txbApellido1.Text);
            instruccionesSql.Parameters.AddWithValue("@Apellido2", txbApellido2.Text);

            conexionConLaBD.Open();
            instruccionesSql.ExecuteNonQuery();
            conexionConLaBD.Close();
            rellenarTabla();

            cadenaSql = $@"
                            INSERT INTO Access_TaLibreria
                            (Isbn, Cantidad, Precio)
                            VALUES
                            (@Isbn, @Cantidad, @Precio);";
            instruccionesSql = new OleDbCommand(cadenaSql, conexionConLaBD);
            instruccionesSql.Parameters.AddWithValue("@Isbn", txbIsbn.Text);
            instruccionesSql.Parameters.AddWithValue("@Cantidad", "0");
            instruccionesSql.Parameters.AddWithValue("@Precio", "0");
            conexionConLaBD.Open();
            instruccionesSql.ExecuteNonQuery();
            conexionConLaBD.Close();
        }

        public void modificarRegistro()
        {
            string cadenaSql = @"
                                UPDATE Access_TaLibros
                                SET
                                Título = @Título,
                                Editorial = @Editorial,
                                Nombre = @Nombre,
                                Apellido1 = @Apellido1,
                                Apellido2 = @Apellido2
                                WHERE Isbn = @Isbn;";
            OleDbCommand instruccionesSql = new OleDbCommand(cadenaSql, conexionConLaBD);
            instruccionesSql.Parameters.AddWithValue("@Título", txbTitulo.Text);
            instruccionesSql.Parameters.AddWithValue("@Editorial", txbEditorial.Text);
            instruccionesSql.Parameters.AddWithValue("@Nombre", txbNombre.Text);
            instruccionesSql.Parameters.AddWithValue("@Apellido1", txbApellido1.Text);
            instruccionesSql.Parameters.AddWithValue("@Apellido2", txbApellido2.Text);
            instruccionesSql.Parameters.AddWithValue("@Isbn", txbIsbn.Text);

            conexionConLaBD.Open();
            instruccionesSql.ExecuteNonQuery();
            conexionConLaBD.Close();
            rellenarTabla();
        }

        public void buscarRegistro()
        {
            string cadenaSql = @"
                         SELECT *
                         FROM Access_TaLibros
                         WHERE Isbn = @Isbn;";
            OleDbCommand instruccionesSql = new OleDbCommand(cadenaSql, conexionConLaBD);
            instruccionesSql.Parameters.AddWithValue("@Isbn", txbIsbn.Text);
            conexionConLaBD.Open();
            OleDbDataReader registro = instruccionesSql.ExecuteReader();
            if (registro.Read())
            {
                txbIsbn.Text = registro[0].ToString();
                txbTitulo.Text = registro[1].ToString();
                txbEditorial.Text = registro[2].ToString();
                txbNombre.Text = registro[3].ToString();
                txbApellido1.Text = registro[4].ToString();
                txbApellido2.Text = registro[5].ToString();
            }
            conexionConLaBD.Close();
        }

        public void borrarRegistro()
        {
            string cadenaSql = $@"
                                 DELETE FROM Access_TaLibros
                                 WHERE Isbn = @Isbn;";
            OleDbCommand instruccionesSql = new OleDbCommand(cadenaSql, conexionConLaBD);
            instruccionesSql.Parameters.AddWithValue("@Isbn", txbIsbn.Text);

            conexionConLaBD.Open();
            instruccionesSql.ExecuteNonQuery();
            conexionConLaBD.Close();
            rellenarTabla();
        }

        private void btnAgregar_Click(object sender, RoutedEventArgs e)
        {
            guardarRegistro();
            LimpiarCampos();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            mainWindow.Show();
        }

        private void btnBuscar_Click(object sender, RoutedEventArgs e)
        {
            buscarRegistro();
            txbIsbn.IsEnabled = false;
            txbIsbn.IsEnabled = false;
        }

        private void btnModificar_Click(object sender, RoutedEventArgs e)
        {
            if (!txbIsbn.IsEnabled)
            {
                modificarRegistro();
                txbIsbn.IsEnabled = true;
                txbIsbn.IsEnabled = true;
                LimpiarCampos();
            }
        }
        private void btnBorrar_Click(object sender, RoutedEventArgs e)
        {
            if (!txbIsbn.IsEnabled)
            {
                borrarRegistro();
                txbIsbn.IsEnabled = true;
                txbIsbn.IsEnabled = true;
                LimpiarCampos();
            }
        }

        private void btnSalir_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.Show();
            this.Close();
        }

        private void btnLimpiar_Click(object sender, RoutedEventArgs e)
        {
            LimpiarCampos();
            txbIsbn.IsEnabled = true;
            txbIsbn.IsEnabled = true;
        }

        private void LimpiarCampos()
        {
            txbIsbn.Text = "";
            txbTitulo.Text = "";
            txbEditorial.Text = "";
            txbNombre.Text = "";
            txbApellido1.Text = "";
            txbApellido2.Text = "";
            txbIsbn.Text = "";
        }
    }
}
