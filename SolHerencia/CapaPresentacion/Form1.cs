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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Alumno alumno = new Alumno();
        private void btnEscribir_Click(object sender, EventArgs e)
        {
            // Leer datos
            string apellidos = txtApellidos.Text.Trim();
            string nombres = txtNombres.Text.Trim();
            string celular = txtCelular.Text.Trim();
            string fechaNac = txtFechaNac.Text.Trim();
            string codigo = txtCodigo.Text.Trim();
            string nroCreditos = txtNroCreditos.Text.Trim();

            // Escribir datos del Alumno en el objeto
            alumno.Apellidos = apellidos;
            alumno.Nombres = nombres;
            alumno.Celular = celular;
            alumno.FechaNac = fechaNac;
            alumno.Codigo = codigo;
            alumno.NroCreditos =nroCreditos;

            // Confirmar que se ha escrito en el objeto
            MessageBox.Show("Se ha escrito correctamente en el objeto");
            // Limpiar las cajas de texto
            txtApellidos.Clear();
            txtNombres.Clear();
            txtCelular.Clear();
            txtFechaNac.Clear();
            txtCodigo.Clear();
            txtNroCreditos.Clear();

            // Hacer que el mouse este en el apellido
            txtApellidos.Focus();
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            // Leer las propuiedades del objeto
            string apellidos = alumno.Apellidos;
            string nombres = alumno.Nombres;
            string fechaNac = alumno.FechaNac;
            string celular = alumno.Celular;
            string codigo = alumno.Codigo;
            string nroCreditos = alumno.NroCreditos;

            MessageBox.Show("Datos del Alumno: " + "\n" + "Apellidos: " + apellidos + "\n" + "Nombres: " + nombres + "\n" + 
                            "Fecha de Nacimiento: " + fechaNac + "\n" + "Celular: " + celular + "\n" + "Codigo: " + codigo + "\n" +
                            "NroCreditos: " + nroCreditos + "\n");
        }

        private void btnMetodo1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(alumno.Caminar());
        }

        private void btnMetodo2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(alumno.Comer());
        }

        private void btnMetodo3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(alumno.Pensar());
        }

        private void btnMetodo4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(alumno.Estudiar());
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPrincipal frmPrincipal = new frmPrincipal();
            frmPrincipal.Show();
        }
    }
}

