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
                            {"Future Nostalgia Moonlight Edition ( Dua Lipa )", "Don't Get To Close ( Skrillex )", "Aftermath ( The Rolling Stones )", "Un Verano Sin ti ( Bad Bunny )"},
                            {"Bad ( Michael Jackson)", "True ( Avicci )", "Highway To Hell ( AC/DC )", "Canción Animal ( Soda Stereo )"},
                            {"Finally Enough Love: 50 number Ones ( Madonna)", "Nothing But The Beat Ultimate Edition ( David Guetta )", "Appetite For Destruction ( Guns N' Roses )", "Barrio Fino Bonus Track Version ( Daddy Yankee)"}};
        int indexGenero;
        int indexAlbum;
        string albumSeleccionado;
        bool encendido = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnGeneros.Enabled = encendido;
            btnAlbum.Enabled = encendido;
            for (int i = 0; i < genxAlb.GetLength(1); i++)
            {
                cmbGenero.Items.Add(genxAlb[0, i]);
            }

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
            string generoSeleccionado = cmbGenero.SelectedItem.ToString();
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
            indexAlbum = aleatorio.Next(1, 4);
            lblAlbum.Visible = true;
            albumSeleccionado = genxAlb[indexAlbum, indexGenero];
            lblAlbum.Text = albumSeleccionado;
        }

    }
}
