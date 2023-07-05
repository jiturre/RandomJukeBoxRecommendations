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
    public partial class Form1 : Form
    {

        string[,] genxAlb = {{"Pop","Electronica", "Rock", "Latino"},
                            {"Future Nostalgia Moonlight Edition ( Dua Lipa )","Aftermath ( The Rolling Stones )", "Un Verano Sin ti ( Bad Bunny )", "Don't Get To Close ( Skrillex )"},
                            {"Bad ( Michael Jackson )", "Highway To Hell ( AC/DC )", "Me verás volver ( Soda Stereo )",  "True ( Avicci )"},
                            {"Finally Enough Love: 50 number Ones ( Madonna )","Appetite For Destruction ( Guns N' Roses )","Barrio Fino Bonus Track Version ( Daddy Yankee)","Nothing But The Beat Ultimate Edition ( David Guetta )"},
                            {"Fine Line ( Harry Styles )", "Bule Hawaii ( Elvis Presley )", "LALI ( Lali )", "Feel Again ( Armin Van Buuren )" } };
        int indexGenero;
        int indexAlbum;
        string albumSeleccionado;
        string generoSeleccionado;
        bool encendido = false;
        bool moviendoMoneda = false;
        int offsetX;
        int offsetY;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnEncendido.Enabled = false;
            btnGeneros.Enabled = encendido;
            btnAlbum.Enabled = encendido;
            for (int i = 0; i < genxAlb.GetLength(1); i++)
            {
                cmbGenero.Items.Add(genxAlb[0, i]);
            }


            // Asignar los manejadores de eventos necesarios
            pbMoneda.MouseDown += pbMoneda_MouseDown;
            pbMoneda.MouseMove += pbMoneda_MouseMove;
            pbMoneda.MouseUp += pbMoneda_MouseUp;

            // Cargar la imagen en el PictureBox
            pbMoneda.Image = Image.FromFile("C:\\Users\\54381\\OneDrive\\Desktop\\Facultad\\Laboratorio\\ProyectoLaboratorio\\RandomJukeBoxRecommendations\\Resources\\assets\\coin.png");
        }

        private void btnEncendido_Click(object sender, EventArgs e)
        {
            btnGeneros.Enabled = !encendido;
            btnAlbum.Enabled = false;
            encendido = !encendido;
            cmbGenero.Visible = false;

        }


        private void cmbGenero_SelectedIndexChanged(object sender, EventArgs e)
        {
            generoSeleccionado = cmbGenero.SelectedItem.ToString();
            btnAlbum.Enabled = true;
            if (generoSeleccionado == "Pop")
            {
                indexGenero = 0;
            } else if (generoSeleccionado == "Rock")
            {
                indexGenero = 1;
            } else if (generoSeleccionado == "Latino")
            {
                indexGenero = 2;
            } else
            {
                indexGenero = 3;
            }
        }
         
        private void btnGeneros_Click(object sender, EventArgs e)
        {
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
            Random aleatorio = new Random();
            indexAlbum = aleatorio.Next(1, 5);
            lblAlbum.Visible = true;

            albumSeleccionado = genxAlb[indexAlbum, indexGenero];
            lblAlbum.Text = albumSeleccionado;

            Form2 form2 = new Form2(albumSeleccionado, generoSeleccionado, this);
            form2.Show();
            this.Hide();
        }

        private void pbMoneda_MouseDown(object sender, MouseEventArgs e)
        {
            moviendoMoneda = true;
            offsetX = e.X;
            offsetY = e.Y;
        }

        private void pbMoneda_MouseMove(object sender, MouseEventArgs e)
        {
            if (moviendoMoneda)
            {
                pbMoneda.Left = e.X + pbMoneda.Left - offsetX;
                pbMoneda.Top = e.Y + pbMoneda.Top - offsetY;
            }
        }

        private void pbMoneda_MouseUp(object sender, MouseEventArgs e)
        {
            moviendoMoneda = false;
            int rangoX = 10;
            int rangoY = 10;

            // Verificar si la posición de la moneda está dentro del rango aceptable
            if (Math.Abs(pbMoneda.Left - 264) <= rangoX && Math.Abs(pbMoneda.Top - 116) <= rangoY)
            {
                btnEncendido.Enabled = true;
            }
           
        }

    }
}
