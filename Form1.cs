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
    public partial class Form1 : Form
    {
        string[,] genxAlb = {{"Pop","Rock", "Latino", "Electronica"},
                            {"Pop1", "Rock1", "Latino", "Electronica1"}};
        bool encendido = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnGeneros.Enabled = encendido;
            btnAlbum.Enabled = encendido;
            for (int i = 0; i < genxAlb.GetLength(0); i++)
            {
                cmbGenero.Items.Add(genxAlb[i,0]);
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
    }
}
