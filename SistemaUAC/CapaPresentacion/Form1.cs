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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Declarar un objeto de la clase
        Alumno alumno = new Alumno();
        private void btnEscribir_Click(object sender, EventArgs e)
        {
            //Leer datos
            string apellidos = txtApellidos.Text.Trim();
            string nombres = txtNombres.Text.Trim();
            string celular = txtCelular.Text.Trim();
            string codigo = txtCodigo.Text.Trim();
            string correo = txtCorreo.Text.Trim();
            string semestreInicio = txtSemestreInicio.Text.Trim();
            string escuelaProfesional = txtEscuelaProfesional.Text.Trim();
            //Escribir los datos del alumno en el objeto
            alumno.Apellidos = apellidos;
            alumno.Nombres = nombres;
            alumno.Celular = celular;
            alumno.Codigo = codigo;
            alumno.Correo = correo;
            alumno.SemestreInicio = semestreInicio;
            alumno.EscuelaProfesional = escuelaProfesional;
            //Confirmar que se ha escrito el mensaje
            MessageBox.Show("Se ha escrito correctamente el objeto");
            //Limpiar las cajas de texto
            txtApellidos.Clear();
            txtNombres.Clear();
            txtCelular.Clear();
            txtCodigo.Clear();
            txtCorreo.Clear();
            txtSemestreInicio.Clear();
            txtEscuelaProfesional.Clear();
            //Hacer que el mouse este en apellidos
            txtApellidos.Focus();
           
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            //Leer las propiedades del objeto
            string apellidos = alumno.Apellidos;
            string nombres = alumno.Nombres;
            string celular = alumno.Celular;
            string codigo = alumno.Codigo;
            string correo = alumno.Correo;
            string semestreInicio = alumno.SemestreInicio;
            string escuelaProfesional = alumno.EscuelaProfesional;
            MessageBox.Show("Datos del alumno" + "\n" + "Apellidos: " + apellidos + "\n" +
                              "Nombres: " + nombres + "\n" + "Celular: " + celular + "\n" +
                              "Codigo: " + codigo + "\n" + "Correo: " + correo + "\n" +
                              "Semestre Inicio: " + semestreInicio + "\n" + "Escuela Profesional: " +
                                  escuelaProfesional + "\n");
        }

        private void btnMetodo1_Click(object sender, EventArgs e)
        {
            //Llamar al metodo
            MessageBox.Show(alumno.Matricular());
        }

        private void btnMetodo2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(alumno.Estudiar());
        }

        private void btnMetodo3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(alumno.Aprobar());
        }

        private void btnMetodo4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(alumno.Investigar());
        }

        private void btnMetodo5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(alumno.Sustentar());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPrincipal frmPrincipal = new frmPrincipal();
            frmPrincipal.Show();
        }
    }
}
