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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        Administrativo administrativo = new Administrativo();
        private void btnEscribir_Click(object sender, EventArgs e)
        {
            //Leer los datos
            string apellidos = txtApellidos.Text.Trim();
            string nombres = txtNombres.Text.Trim();
            string celular = txtCelular.Text.Trim();
            string fechaNac = txtFechaNac.Text.Trim();
            string areaTrabajo = txtAreaTrabajo.Text.Trim();
            string correo = txtCorreo.Text.Trim();
            string dni = txtDni.Text.Trim();
            // Escribir datos del Alumno en el objeto
            administrativo.Apellidos = apellidos;
            administrativo.Nombres = nombres;
            administrativo.Celular = celular;
            administrativo.FechaNac = fechaNac;
            administrativo.AreaTrabajo = areaTrabajo;
            administrativo.Correo = correo;
            administrativo.Dni = dni;
            // Confirmar que se ha escrito en el objeto
            MessageBox.Show("Se ha escrito correctamente en el objeto");
            // Limpiar las cajas de texto
            txtApellidos.Clear();
            txtNombres.Clear();
            txtCelular.Clear();
            txtFechaNac.Clear();
            txtAreaTrabajo.Clear();
            txtCorreo.Clear();
            txtDni.Clear();
            // Hacer que el mouse este en el apellido
            txtApellidos.Focus();
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            // Leer las propuiedades del objeto
            string apellidos = administrativo.Apellidos;
            string nombres = administrativo.Nombres;
            string fechaNac = administrativo.FechaNac;
            string celular = administrativo.Celular;
            string areaTrabajo = administrativo.AreaTrabajo;
            string correo = administrativo.Correo;
            string dni = administrativo.Dni;
            MessageBox.Show("Datos del Administrativo" + "\n" + "Apellidos: " + apellidos + "\n" + "Nombres: " + nombres + "\n" + "Fecha de Nacimiento: " +
                            fechaNac + "\n" + "Celular: " + celular + "\n" + "Area de Trabajo: " + areaTrabajo + "\n" + "Correo: " + correo + "\n" +
                            "Dni: " + dni + "\n");
        }

        private void btnMetodo1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(administrativo.Caminar());
        }

        private void btnMetodo2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(administrativo.Comer());
        }

        private void btnMetodo3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(administrativo.Pensar());
        }

        private void btnMetodo4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(administrativo.Controlar());
        }

        private void btnMetodo5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(administrativo.Informar());
        }

        private void btnMetodo6_Click(object sender, EventArgs e)
        {
            MessageBox.Show(administrativo.Organizar());
        }

        private void btnMetodo7_Click(object sender, EventArgs e)
        {
            MessageBox.Show(administrativo.Recepcionar());
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPrincipal frmPrincipal = new frmPrincipal();
            frmPrincipal.Show();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
