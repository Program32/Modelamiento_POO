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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        //Declarar un objeto de la clase
        Laboratorio laboratorio = new Laboratorio();
        private void btnEscribir_Click(object sender, EventArgs e)
        {
            //Leer los datos
            string alumno = txtAlumno.Text.Trim();
            string asignatura = txtAsignatura.Text.Trim();
            string horarios = txtHorarios.Text.Trim();
            string docentes = txtDocentes.Text.Trim();
            string salon = txtSalon.Text.Trim();
            //Escribir los datos del laboratorio en el objeto
            laboratorio.Alumno = alumno;
            laboratorio.Asignatura = asignatura;
            laboratorio.Horarios = horarios;
            laboratorio.Docentes = docentes;
            laboratorio.Salon = salon;
            //Confirmar que se ha escrito el objeto
            MessageBox.Show("Se ha escrito correctamente el objeto");
            //Limpiar las cajas de texto
            txtAlumno.Clear();
            txtAsignatura.Clear();
            txtHorarios.Clear();
            txtDocentes.Clear();
            txtSalon.Clear();
            //Hacer que el mause este en alumno
            txtAlumno.Focus();
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            //Leer nlas propiedades del objeto
            string alumno = laboratorio.Alumno;
            string asignatura = laboratorio.Asignatura;
            string horarios = laboratorio.Horarios;
            string docentes = laboratorio.Docentes;
            string salon = laboratorio.Salon;
            MessageBox.Show("Datos del Laboratorio" + "\n" + "Alumno: " + alumno + "\n" + "Asignatura: " + asignatura +
                                "\n" + "Horarios: " + horarios + "\n" + "Docente: " + docentes + "\n" + "Salon: " + salon + "\n");
        }

        private void btnMetodo1_Click(object sender, EventArgs e)
        {
            //Llamar al metodo
            MessageBox.Show(laboratorio.Practicar());
        }

        private void btnMetodo2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(laboratorio.Experimentar());
        }

        private void btnMetodo3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(laboratorio.Investigar());
        }

        private void btnMetodo4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(laboratorio.Calificar());
        }

        private void btnMetodo5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(laboratorio.Sustentar());
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPrincipal frmPrincipal = new frmPrincipal();
            frmPrincipal.Show();
        }
    }
}
