using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa07_04Verdadero
{
    // Dentro de la carpeta de la solucion, carpetas fotos para cargar y fotos para guardar
    // Open file dialog y save file dialog, mostrar la ruta de la imagen entre los botones
    // y el picture box
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            pictureBox.BorderStyle = BorderStyle.None;
            lblRutaImg.Text = "";

            if(!Directory.Exists("..\\..\\..\\Imagenes para guardar"))
            {
                Directory.CreateDirectory(".\\..\\..\\..\\Imagenes para guardar");
            }
            if (!Directory.Exists("..\\..\\..\\Imagenes para cargar"))
            {
                Directory.CreateDirectory(".\\..\\..\\..\\Imagenes para cargar");
            }
        }

        private void btnCargarImagen_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "C:\\Users\\José\\Documents\\GitHub\\Interfaces\\Programa07_04Verdadero\\Imagenes para cargar";
                openFileDialog.Filter = "imagenes jpg (*.jpg)|*.jpg|Todos los ficheros (*.*)|*.*"; openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                { 
                    lblRutaImg.Text = openFileDialog.FileName;
                    pictureBox.ImageLocation = openFileDialog.FileName;
                }
            }
        }

        private void btnGuardarImagen_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.InitialDirectory = "C:\\Users\\José\\Documents\\GitHub\\Interfaces\\Programa07_04Verdadero\\Imagenes para guardar";
                saveFileDialog.FileName = "imagen.jpg";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pictureBox.Image.Save(saveFileDialog.FileName);

                    lblRutaImg.Text = saveFileDialog.FileName;
                }
            }
        }

        private void lblRutaImg_Click(object sender, EventArgs e)
        {

        }
    }
}
