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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        Docente docente = new Docente();
        private void btnEscribir_Click(object sender, EventArgs e)
        {
            //Leer los datos
            string apellidos = txtApellidos.Text.Trim();
            string nombres = txtNombres.Text.Trim();
            string celular = txtCelular.Text.Trim();
            string fechaNac = txtFechaNac.Text.Trim();
            string correo = txtCorreo.Text.Trim();
            string especialidad = txtEspecialidad.Text.Trim();
            // Escribir datos del Alumno en el objeto
            docente.Apellidos = apellidos;
            docente.Nombres = nombres;
            docente.Celular = celular;
            docente.FechaNac = fechaNac;
            docente.Correo = correo;
            docente.Especialidad = especialidad;
            // Confirmar que se ha escrito en el objeto
            MessageBox.Show("Se ha escrito correctamente en el objeto");
            // Limpiar las cajas de texto
            txtApellidos.Clear();
            txtNombres.Clear();
            txtCelular.Clear();
            txtFechaNac.Clear();
            txtCorreo.Clear();
            txtEspecialidad.Clear();
            // Hacer que el mouse este en el apellido
            txtApellidos.Focus();
        }
        private void btnLeer_Click(object sender, EventArgs e)
        {
            // Leer las propuiedades del objeto
            string apellidos = docente.Apellidos;
            string nombres = docente.Nombres;
            string fechaNac = docente.FechaNac;
            string celular = docente.Celular;
            string correo = docente.Correo;
            string especialidad = docente.Especialidad;
            MessageBox.Show("Datos del docente" + "\n" + "Apellidos: " + apellidos + "\n" + "Nombres: " + nombres + "\n" + "Fecha de Nacimiento: " +
                            fechaNac + "\n" + "Celular: " + celular + "\n" + "Correo: " + correo + "\n" + "Especialidad: " + especialidad + "\n");
        }

        private void btnMetodo1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(docente.Caminar());
        }

        private void btnMetod2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(docente.Comer());
        }

        private void btnMetodo3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(docente.Pensar());
        }

        private void btnMetodo4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(docente.Aprobar());
        }

        private void btnMetodo5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(docente.Enseñar());
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPrincipal frmPrincipal = new frmPrincipal();
            frmPrincipal.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
