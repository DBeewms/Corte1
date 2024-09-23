using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Corte1.Clases;

namespace Corte1
{
    public partial class Form1 : Form
    {
        private Registro registro = new Registro();

        public Form1()
        {
            InitializeComponent();
            LlenarComboBoxCiudades();
        }
        private void LlenarComboBoxCiudades()
        {
            cmbCiudad.Items.Add("Managua");
            cmbCiudad.Items.Add("Masaya");
            cmbCiudad.Items.Add("Granada");

            cmbCiudad.SelectedIndex = 0;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tbNombres_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbApellidos_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbCiudad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = tbNombres.Text;
            string apellido = tbApellidos.Text;
            DateTime fechaNac = dtpFecha.Value;
            string ciudad = cmbCiudad.SelectedItem != null ? cmbCiudad.SelectedItem.ToString() : "";

            // Validar que los campos no estén vacíos manualmente
            if (nombre.Trim() == "" || apellido.Trim() == "" || ciudad.Trim() == "")
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            // Crear nueva persona con los datos ingresados
            Persona nuevaPersona = new Persona(nombre, apellido, fechaNac, ciudad);

            // Intentamos agregar la persona al registro
            bool agregado = registro.AgregarPersona(nuevaPersona);
            if (agregado)
            {
                MessageBox.Show("Persona agregada.");
            }
            else
            {
                MessageBox.Show("El registro está lleno.");
            }
        }

        private void lblMayorEdad_Click(object sender, EventArgs e)
        {

        }

        private void mostrarEdad_Click(object sender, EventArgs e)
        {
            if (registro.ContadorPersonas() == 0)
            {
                MessageBox.Show("No hay personas registradas.");
                return;
            }

            int ultimoIndice = registro.ContadorPersonas() - 1;
            Persona personaSeleccionada = registro.MostrarPersonas()[ultimoIndice];

            int edad = Operacion.CalcularEdad(personaSeleccionada);
            string estado = Operacion.VerificarMayorEdad(personaSeleccionada);

            lblMayorEdad.Text = $"{personaSeleccionada.Nombre} {personaSeleccionada.Apellido} tiene {edad} años y es {estado}.";
        }
    }
}
