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
    public partial class Form2 : Form
    {
        //Declaración variables globales 
        private int numAlbum;
        private int cambios;
        private Timer timer;
        private Random aleatorio;
        private Form formAnterior;
        private string album;
        private string genero;
        public Form2(string albumSeleccionado, string nombreGenero, Form form1)
        {
            InitializeComponent();

            formAnterior = form1;
            album = albumSeleccionado;
            cambios = 0;

            genero = nombreGenero;

            btnVolver.Visible = false;


            timer = new Timer();
            // Intervalo de tiempo para cambiar las imágenes (en milisegundos)
            timer.Interval = 1000; 
            timer.Tick += Timer_Tick;
            timer.Start();

            aleatorio = new Random();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            cambios++;

            // Cambiar las imágenes gradualmente
            if (cambios <= 10)
            {
                int img1 = aleatorio.Next(1, 5);
                int img2 = aleatorio.Next(1, 5);
                int img3 = aleatorio.Next(1, 5);
                pbIzquierda.Image = Image.FromFile("C:\\Users\\54381\\OneDrive\\Desktop\\Facultad\\Laboratorio\\ProyectoLaboratorio\\RandomJukeBoxRecommendations\\Resources\\" + genero + "\\" + img1 + ".jpg");
                pbMedio.Image = Image.FromFile("C:\\Users\\54381\\OneDrive\\Desktop\\Facultad\\Laboratorio\\ProyectoLaboratorio\\RandomJukeBoxRecommendations\\Resources\\" + genero + "\\" + img2 + ".jpg");
                pbDerecha.Image = Image.FromFile("C:\\Users\\54381\\OneDrive\\Desktop\\Facultad\\Laboratorio\\ProyectoLaboratorio\\RandomJukeBoxRecommendations\\Resources\\" + genero + "\\" + img3 + ".jpg");

                Refresh();
                Thread.Sleep(100); // Agregar un breve retraso entre cambios de imagen
            }
            else
            {
                timer.Stop();

                // Mostrar solo el PictureBox del medio y ocultar los demás
                pbIzquierda.Visible = false;
                pbDerecha.Visible = false;
                pbMedio.Size = new Size(350, 300);
                btnVolver.Visible = true;
                vueltasImagenes();
                label1.Text = album;
            }
        }
        private void vueltasImagenes()
        {
            numAlbum = imagenAlbumSeleccionado(genero);

            pbMedio.Image = Image.FromFile("C:\\Users\\54381\\OneDrive\\Desktop\\Facultad\\Laboratorio\\ProyectoLaboratorio\\RandomJukeBoxRecommendations\\Resources\\" + genero + "\\" + numAlbum + ".jpg");
        }
        private int imagenAlbumSeleccionado(string generoAlbum)
        {
            // Asignar un número a cada álbum
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
            formAnterior.Show();
            this.Hide();
        }

        private void btnVolver_MouseHover(object sender, EventArgs e)
        {
            btnVolver.BackColor = Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(3)))), ((int)(((byte)(179)))));
            btnVolver.ForeColor = Color.Black;
        }

        private void btnVolver_MouseLeave(object sender, EventArgs e)
        {
            btnVolver.BackColor = Color.Black;
            btnVolver.ForeColor = Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(3)))), ((int)(((byte)(179)))));
        }
    }
}
