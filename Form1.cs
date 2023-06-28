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

        string[,] genxAlb = {{"Pop","Rock", "Latino", "Electronica"},
                            {"Pop1", "Rock1", "Latino1", "Electronica1"},
                            {"Pop2", "Rock2", "Latino2", "Electronica2"},
                            {"Pop3", "Rock3", "Latino3", "Electronica3"}};
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
            btnAlbum.Enabled = !encendido;
            encendido = !encendido;

        }


        private void cmbGenero_SelectedIndexChanged(object sender, EventArgs e)
        {
            string generoSeleccionado = cmbGenero.SelectedItem.ToString();

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
            albumSeleccionado = genxAlb[indexAlbum, indexGenero];
            lblAlbum.Text = albumSeleccionado;
        }

    }
}
