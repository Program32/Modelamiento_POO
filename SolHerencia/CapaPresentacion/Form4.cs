using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        Persona persona = new Persona();
        private void btnEscribir_Click(object sender, EventArgs e)
        {
            //Leer los datos
            string apellidos = txtApellidos.Text.Trim();
            string nombres = txtNombres.Text.Trim();
            string celular = txtCelular.Text.Trim();
            string fechaNac = txtFechaNac.Text.Trim();
            // Escribir datos del Alumno en el objeto
            persona.Apellidos = apellidos;
            persona.Nombres = nombres;
            persona.Celular = celular;
            persona.FechaNac = fechaNac;
            // Confirmar que se ha escrito en el objeto
            MessageBox.Show("Se ha escrito correctamente en el objeto");
            // Limpiar las cajas de texto
            txtApellidos.Clear();
            txtNombres.Clear();
            txtCelular.Clear();
            txtFechaNac.Clear();
            // Hacer que el mouse este en el apellido
            txtApellidos.Focus();
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            // Leer las propuiedades del objeto
            string apellidos = persona.Apellidos;
            string nombres = persona.Nombres;
            string fechaNac = persona.FechaNac;
            string celular = persona.Celular;
            MessageBox.Show("Datos de la persona" + "\n" + "Apellidos: " + apellidos + "\n" + "Nombres: " + nombres + "\n" + "Fecha de Nacimiento: " +
                            fechaNac + "\n" + "Celular: " + celular + "\n");
        }

        private void btnMetodo1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(persona.Caminar());
        }

        private void btnMetodo2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(persona.Comer());
        }

        private void btnMetodo3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(persona.Pensar());
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPrincipal frmPrincipal = new frmPrincipal();
            frmPrincipal.Show();
        }
    }
}
