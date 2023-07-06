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
    public partial class Inicio : Form
    {
        int vuelto = 0;
        int montoIngresado = 0;
        
        public Inicio()
        {
            InitializeComponent();
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            montoIngresado = int.Parse(txtMonto.Text);

            if (montoIngresado >= 50)
            {
                if (montoIngresado == 50)
                {
                    MessageBox.Show("Bienvenido! Tienes 3 tiradas disponibles");
                    
                } else
                {
                    vuelto = montoIngresado - 50;
                    MessageBox.Show($"Bienvenido! Su vuelto es ${vuelto}. Tienes 3 tiradas disponibles");
                }
                JukeBox siguienteform = new JukeBox(this);
                siguienteform.Show();
                this.Hide();
            } else
            {
                MessageBox.Show("Ingrese un monto mayor a $50");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
    }
}
