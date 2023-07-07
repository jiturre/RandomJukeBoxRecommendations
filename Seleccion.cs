using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace Proyecto1
{
    public partial class Seleccion : Form
    {
        // Declaración de variables globales
        private int numAlbum; // Número del álbum seleccionado
        private int cambios; // Contador de cambios de imagen
        private Timer timer; // Temporizador para cambiar las imágenes gradualmente
        private Random aleatorio; // Generador de números aleatorios
        private string album; // Nombre del álbum seleccionado
        private string genero; // Género del álbum seleccionado
        

        public Seleccion(string albumSeleccionado, string nombreGenero)
        {
            InitializeComponent();

            
            album = albumSeleccionado;
            cambios = 0;
            

            genero = nombreGenero;

            btnVolver.Visible = false;

            timer = new Timer();
            timer.Interval = 1000; // Intervalo de tiempo para cambiar las imágenes (en milisegundos)
            timer.Tick += CambiarImagenesGradualmente; // Evento Tick para cambiar las imágenes gradualmente
            timer.Start();

            aleatorio = new Random();
        }

        private void CambiarImagenesGradualmente(object sender, EventArgs e)
        {
            cambios++;

            // Cambiar las imágenes gradualmente
            if (cambios <= 10)
            {
                // Generar índices aleatorios para las imágenes
                int img1;
                int img2;
                int img3;
                do
                {
                    img1 = aleatorio.Next(1, 5);
                    img2 = aleatorio.Next(1, 5);
                    img3 = aleatorio.Next(1, 5);
                } while (img1 == img2 || img1 == img3 || img2 == img3);

                // Cargar las imágenes correspondientes en los PictureBox
                pbIzquierda.Image = Image.FromFile("C:\\Users\\54381\\OneDrive\\Desktop\\Facultad\\Laboratorio\\ProyectoLaboratorio\\RandomJukeBoxRecommendations\\Resources\\" + genero + "\\" + img1 + ".jpeg");
                pbMedio.Image = Image.FromFile("C:\\Users\\54381\\OneDrive\\Desktop\\Facultad\\Laboratorio\\ProyectoLaboratorio\\RandomJukeBoxRecommendations\\Resources\\" + genero + "\\" + img2 + ".jpeg");
                pbDerecha.Image = Image.FromFile("C:\\Users\\54381\\OneDrive\\Desktop\\Facultad\\Laboratorio\\ProyectoLaboratorio\\RandomJukeBoxRecommendations\\Resources\\" + genero + "\\" + img3 + ".jpeg");

                Refresh();
                Thread.Sleep(100); // Agregar un breve retraso entre cambios de imagen
            }
            else
            {
                timer.Stop();

                // Mostrar solo el PictureBox del medio y ocultar los demás
                pbIzquierda.Visible = false;
                pbDerecha.Visible = false;
                btnVolver.Visible = true;
                vueltasImagenes();
                pbMedio.Size = new Size(250, 450);
            }
        }

        private void vueltasImagenes()
        {
            numAlbum = imagenAlbumSeleccionado(genero);

            // Cargar la imagen del álbum seleccionado en el PictureBox del medio
            pbMedio.Image = Image.FromFile("C:\\Users\\54381\\OneDrive\\Desktop\\Facultad\\Laboratorio\\ProyectoLaboratorio\\RandomJukeBoxRecommendations\\Resources\\" + genero + "\\" + numAlbum + ".jpeg");
        }

        private int imagenAlbumSeleccionado(string generoAlbum)
        {
            // Asignar un número a cada álbum basado en el género y el nombre del álbum
            if (generoAlbum == "Pop")
            {
                switch (album)
                {
                    case "Future Nostalgia Moonlight Edition ( Dua Lipa )":
                        numAlbum = 1;
                        break;
                    case "Bad ( Michael Jackson )":
                        numAlbum = 2;
                        break;
                    case "Finally Enough Love: 50 number Ones ( Madonna )":
                        numAlbum = 3;
                        break;
                    case "Fine Line ( Harry Styles )":
                        numAlbum = 4;
                        break;
                }
            }
            else if (generoAlbum == "Rock")
            {
                switch (album)
                {
                    case "Aftermath ( The Rolling Stones )":
                        numAlbum = 1;
                        break;
                    case "Highway To Hell ( AC/DC )":
                        numAlbum = 2;
                        break;
                    case "Appetite For Destruction ( Guns N' Roses )":
                        numAlbum = 3;
                        break;
                    case "Bule Hawaii ( Elvis Presley )":
                        numAlbum = 4;
                        break;
                }
            }
            else if (generoAlbum == "Latino")
            {
                switch (album)
                {
                    case "Un Verano Sin ti ( Bad Bunny )":
                        numAlbum = 1;
                        break;
                    case "Me verás volver ( Soda Stereo )":
                        numAlbum = 2;
                        break;
                    case "Barrio Fino Bonus Track Version ( Daddy Yankee)":
                        numAlbum = 3;
                        break;
                    case "LALI ( Lali )":
                        numAlbum = 4;
                        break;
                }
            }
            else
            {
                switch (album)
                {
                    case "Don't Get To Close ( Skrillex )":
                        numAlbum = 1;
                        break;
                    case "True ( Avicci )":
                        numAlbum = 2;
                        break;
                    case "Nothing But The Beat Ultimate Edition ( David Guetta )":
                        numAlbum = 3;
                        break;
                    case "Feel Again ( Armin Van Buuren )":
                        numAlbum = 4;
                        break;
                }
            }

            return numAlbum;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            // Mostrar el formulario anterior (JukeBox) y cerrar el formulario actual (Seleccion)
            JukeBox formAnterior = new JukeBox();
            this.Close();
            formAnterior.Show();
        }

        private void btnVolver_MouseHover(object sender, EventArgs e)
        {
            // Cambiar los colores de fondo y de texto del botón "Volver" cuando el mouse se coloca sobre él
            btnVolver.BackColor = Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(3)))), ((int)(((byte)(179)))));
            btnVolver.ForeColor = Color.Black;
        }

        private void btnVolver_MouseLeave(object sender, EventArgs e)
        {
            // Restaurar los colores de fondo y de texto del botón "Volver" cuando el mouse sale de él
            btnVolver.BackColor = Color.Black;
            btnVolver.ForeColor = Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(3)))), ((int)(((byte)(179)))));
        }


    }

}
