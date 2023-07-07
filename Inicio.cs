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
        int vuelto = 0; // Variable para almacenar el vuelto
        int montoIngresado = 0; // Variable para almacenar el monto ingresado

        public Inicio()
        {
            InitializeComponent();
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            montoIngresado = int.Parse(txtMonto.Text); // Convertir el texto del campo txtMonto a un entero y guardarlo en montoIngresado

            if (montoIngresado >= 50) // Verificar si el monto ingresado es mayor o igual a 50
            {
                if (montoIngresado == 50) // Si el monto ingresado es exactamente 50
                {
                    MessageBox.Show("Bienvenido! Tienes 3 tiradas disponibles"); // Mostrar mensaje de bienvenida con 3 tiradas disponibles
                }
                else
                {
                    vuelto = montoIngresado - 50; // Calcular el vuelto restando 50 al monto ingresado
                    MessageBox.Show($"Bienvenido! Su vuelto es ${vuelto}. Tienes 3 tiradas disponibles"); // Mostrar mensaje de bienvenida con el vuelto y 3 tiradas disponibles
                }

                JukeBox siguienteform = new JukeBox(this); // Crear una instancia del formulario JukeBox y pasar una referencia a esta instancia de Inicio
                siguienteform.Show(); // Mostrar el formulario JukeBox
                this.Hide(); // Ocultar el formulario actual (Inicio)
            }
            else
            {
                MessageBox.Show("Ingrese un monto mayor a $50"); // Mostrar mensaje de error si el monto ingresado es menor a 50
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Cerrar la aplicación
        }
    }
}
