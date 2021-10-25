using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Llamar a la capa negocio
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        //Delarar un objeto de la clase
        Docente docente = new Docente();

        private void btnEscribir_Click(object sender, EventArgs e)
        {
            //Leer datos
            string apellidos = txtApellidos.Text.Trim();
            string nombres = txtNombres.Text.Trim();
            string correo = txtCorreo.Text.Trim();
            string celular = txtCelular.Text.Trim();
            string especialidad = txtEspecialidad.Text.Trim();
            //Escribir los datos del docente en el objeto
            docente.Apellidos = apellidos;
            docente.Nombres = nombres;
            docente.Correo = correo;
            docente.Celular = celular;
            docente.Especialidad = especialidad;
            //Confirmar que se ha escrito el mensaje
            MessageBox.Show("Se ha escrito correctamente el objeto");
            //Limpiar las cajas de texto
            txtApellidos.Clear();
            txtNombres.Clear();
            txtCorreo.Clear();
            txtCelular.Clear();
            txtEspecialidad.Clear();
            //Hacer que el mause este en apellidos
            txtApellidos.Focus();
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            //Leer las propiedades del objeto
            string apellidos = docente.Apellidos;
            string nombres = docente.Nombres;
            string correo = docente.Correo;
            string celular = docente.Celular;
            string especialidad = docente.Especialidad;
            MessageBox.Show("Datos del Docente" + "\n" + "Apellidos: " + apellidos + "\n" + "Nombres: " + nombres + "\n" +
                                "Correo: " + correo + "\n" + "Celular: " + celular + "\n" + "Especialidad: " + especialidad + "\n");
        }

        private void btnMetodo1_Click(object sender, EventArgs e)
        {
            //Llamar al metodo
            MessageBox.Show(docente.Ensenar());
        }

        private void btnMetodo2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(docente.Revisar());
        }

        private void btnMetodo3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(docente.Orientar());
        }

        private void btnMetodo4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(docente.Diagnosticar());
        }

        private void btnMetodo5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(docente.Motivar());
        }

        private void btnMetodo6_Click(object sender, EventArgs e)
        {
            MessageBox.Show(docente.Aprobar());
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPrincipal frmPrincipal = new frmPrincipal();
            frmPrincipal.Show();
        }
    }
}
