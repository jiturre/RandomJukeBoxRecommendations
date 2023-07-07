using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto1
{
    public partial class Nosotros : Form
    {
        // Arreglos de imágenes y nombres
        string[] imagenes = { "ComicFacundo", "ComicVictoria", "ComicJoaquin", "ComicLaureano", "ComicJulian", "ComicMario" };
        string[] nombres = { "Acosta Facundo", "Cavanna Victoria", "Iturre Joaquin", "Caceres Laureano", "Figueroa Julian", "Chavez Mario" };

        // Variables de configuración
        int tamañoImagen = 150; // Tamaño de imagen
        int espaciado = 50; // Espacio entre las imágenes
        int índiceActual = 0; // Índice actual de la imagen que se mostrará

        // Temporizador y generador de números aleatorios
        Timer temporizador = new Timer();
        Random random = new Random();

        public Nosotros()
        {
            InitializeComponent();
        }

        private void Nosotros_Load(object sender, EventArgs e)
        {
            temporizador.Interval = 1000; // Intervalo de tiempo entre la aparición de cada imagen (en milisegundos)
            temporizador.Tick += MostrarSiguienteImagen; // Evento Tick para mostrar la siguiente imagen
            temporizador.Start();
        }

        void MostrarSiguienteImagen(object sender, EventArgs e)
        {
            int filas = 2; // Número de filas
            int columnas = imagenes.Length / filas; // Número de columnas

            if (índiceActual < imagenes.Length)
            {
                int índiceFila = índiceActual / columnas;
                int índiceColumna = índiceActual % columnas;

                int x = 50 + índiceColumna * (tamañoImagen + espaciado);
                int y = 100 + índiceFila * (tamañoImagen + espaciado);

                string imagenAleatoria = imagenes[índiceActual];
                string nombreTexto = nombres[índiceActual];

                // Crear PictureBox
                PictureBox pictureBox = new PictureBox();
                pictureBox.Image = Image.FromFile($"C:\\Users\\54381\\OneDrive\\Desktop\\Facultad\\Laboratorio\\ProyectoLaboratorio\\RandomJukeBoxRecommendations\\Resources\\assets\\{imagenAleatoria}.jpeg");
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.Size = new Size(tamañoImagen, tamañoImagen);
                pictureBox.Location = new Point(x, y);
                Controls.Add(pictureBox);

                // Crear Label
                Label label = new Label();
                label.Text = nombreTexto;
                label.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                label.ForeColor = Color.Black;
                label.BackColor = Color.Transparent;
                label.AutoSize = true;
                label.Location = new Point(x, y - 30); // Ubicación del nombre sobre el PictureBox
                Controls.Add(label);

                índiceActual++;
            }
            else
            {
                temporizador.Stop(); // Detener el temporizador cuando se hayan mostrado todas las imágenes
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio();
            this.Hide();
            inicio.Show();
        }
    }

}

