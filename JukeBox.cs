using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proyecto1
{
    public partial class JukeBox : Form
    {
        /* Matriz para almacenar géneros y álbumes */
        string[,] genxAlb = { 
            // Géneros en la primera fila
            {"Pop","Electronica", "Rock", "Latino"},
            // Álbumes correspondientes a cada género en las filas siguientes
            {"Future Nostalgia Moonlight Edition ( Dua Lipa )","Aftermath ( The Rolling Stones )", "Un Verano Sin ti ( Bad Bunny )", "Don't Get To Close ( Skrillex )"},
            {"Bad ( Michael Jackson )", "Highway To Hell ( AC/DC )", "Me verás volver ( Soda Stereo )",  "True ( Avicci )"},
            {"Finally Enough Love: 50 number Ones ( Madonna )","Appetite For Destruction ( Guns N' Roses )","Barrio Fino Bonus Track Version ( Daddy Yankee)","Nothing But The Beat Ultimate Edition ( David Guetta )"},
            {"Fine Line ( Harry Styles )", "Bule Hawaii ( Elvis Presley )", "LALI ( Lali )", "Feel Again ( Armin Van Buuren )" }
        };

        int indexGenero; // Índice del género seleccionado
        int indexAlbum; // Índice del álbum seleccionado
        int tiradas = 3; // Número de tiradas restantes
        string albumSeleccionado; // Álbum seleccionado
        string generoSeleccionado; // Género seleccionado
        bool encendido = false; // Estado del JukeBox (encendido o apagado)
        Random aleatorio = new Random(); // Objeto para generar números aleatorios

        public JukeBox(Form formInicio)
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Configuración inicial del formulario
            btnEncendido.Text = "ON";
            btnGeneros.Enabled = encendido;
            btnAlbum.Enabled = encendido;

            // Agregar los géneros al ComboBox
            for (int i = 0; i < genxAlb.GetLength(1); i++)
            {
                cmbGenero.Items.Add(genxAlb[0, i]);
            }

            // Configurar la imagen de fondo y ocultar el label del álbum
            this.BackgroundImage = Image.FromFile("C:\\Users\\54381\\OneDrive\\Desktop\\Facultad\\Laboratorio\\ProyectoLaboratorio\\RandomJukeBoxRecommendations\\Resources\\assets\\Jukebox.jpeg");
            lblTiradas.Text = "Tiradas restantes: " + tiradas;
            lblAlbum.Visible = false;
        }

        private void btnEncendido_Click(object sender, EventArgs e)
        {
            // Cambiar el estado del JukeBox y habilitar/deshabilitar botones
            btnGeneros.Enabled = !encendido;
            btnAlbum.Enabled = false;
            encendido = !encendido;
            cmbGenero.Visible = false;

            // Actualizar el texto del botón de encendido/apagado
            if (encendido)
            {
                btnEncendido.Text = "OFF";
            }
            else
            {
                btnEncendido.Text = "ON";
            }
        }

        private void cmbGenero_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtener el género seleccionado y habilitar el botón de álbum
            generoSeleccionado = cmbGenero.SelectedItem.ToString();
            btnAlbum.Enabled = true;

            // Determinar el índice del género seleccionado
            if (generoSeleccionado == "Pop")
            {
                indexGenero = 0;
            }
            else if (generoSeleccionado == "Rock")
            {
                indexGenero = 1;
            }
            else if (generoSeleccionado == "Latino")
            {
                indexGenero = 2;
            }
            else
            {
                indexGenero = 3;
            }
        }

        private void btnGeneros_Click(object sender, EventArgs e)
        {
            // Mostrar u ocultar el ComboBox de géneros al hacer clic en el botón "Generos"
            if (cmbGenero.Visible)
            {
                cmbGenero.Visible = false;
            }
            else
            {
                cmbGenero.Visible = true;
            }
        }

        private void btnAlbum_Click(object sender, EventArgs e)
        {
            // Descontar una tirada
            tiradas--;

            // Generar un índice aleatorio para seleccionar un álbum del género actual
            indexAlbum = aleatorio.Next(1, 5);
            lblAlbum.Visible = true;

            // Obtener el álbum seleccionado basado en los índices de género y álbum
            albumSeleccionado = genxAlb[indexAlbum, indexGenero];

            // Crear una nueva instancia del formulario Seleccion y mostrarlo como un diálogo
            Seleccion form2 = new Seleccion(albumSeleccionado, generoSeleccionado, this, tiradas);
            form2.ShowDialog();

            // Actualizar el estado del JukeBox
            ActualizarJukeBox();
        }

        private void ActualizarJukeBox()
        {
            // Actualizar el texto y la visibilidad del label del álbum
            lblTiradas.Text = "Tiradas restantes: " + tiradas;
            lblAlbum.Visible = true;
            lblAlbum.Text = "Ultima recomendación: " + albumSeleccionado;

            // Deshabilitar el botón de álbum y ocultar el ComboBox de géneros
            btnAlbum.Enabled = false;
            cmbGenero.Visible = false;

            // Desuscribir y volver a suscribir el evento SelectedIndexChanged del ComboBox de géneros
            cmbGenero.SelectedIndexChanged -= cmbGenero_SelectedIndexChanged;
            cmbGenero.SelectedIndex = -1;
            cmbGenero.SelectedIndexChanged += cmbGenero_SelectedIndexChanged;

            // Verificar si se agotaron las tiradas y actualizar el estado en consecuencia
            if (tiradas == 0)
            {
                MessageBox.Show("Se agotaron las tiradas");
                btnGeneros.Enabled = false;
                btnEncendido.Enabled = false;
                btnVolverInicio.Visible = true;
             
            }
        }

        private void btnVolverInicio_Click(object sender, EventArgs e)
        {
            // Volver al formulario de inicio
            Inicio inicio = new Inicio();
            inicio.Show();
            this.Close();
        }
    }
}