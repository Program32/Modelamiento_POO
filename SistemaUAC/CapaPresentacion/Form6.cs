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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        //Llamar un objeto de la clase
        Asignatura asignatura = new Asignatura(); 
        private void btnEscribir_Click(object sender, EventArgs e)
        {
            //Leer datos
            string nombreAsignatura = txtNombreAsignatura.Text.Trim();
            string docentes = txtDocentes.Text.Trim();
            string horarios = txtHorarios.Text.Trim();
            string creditos = txtCreditos.Text.Trim();
            string facultad = txtFacultad.Text.Trim();
            //Escribir los datos de la asignatura en el objeto
            asignatura.NombresAsignatura = nombreAsignatura;
            asignatura.Docentes = docentes;
            asignatura.Horarios = horarios;
            asignatura.Creditos = creditos;
            asignatura.Facultad = facultad;
            //Confirmar que se ha escrito el mensaje
            MessageBox.Show("Se ha escrito correctamente el objeto");
            //Limpiar las cajas de texto
            txtNombreAsignatura.Clear();
            txtDocentes.Clear();
            txtHorarios.Clear();
            txtCreditos.Clear();
            txtFacultad.Clear();
            //Hacer que el mause este en nombreasignatura
            txtNombreAsignatura.Focus();
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            //Leer las propiedades del objeto
            string nombreAsignatura = asignatura.NombresAsignatura;
            string docentes = asignatura.Docentes;
            string horarios = asignatura.Horarios;
            string creditos = asignatura.Creditos;
            string facultad = asignatura.Facultad;
            MessageBox.Show("Datos de la Asignatura" + "\n" + "Nombre de la Asignatura: " + nombreAsignatura + "\n" + "Docente: " + docentes + "\n" +
                                "Horarios: " + horarios + "\n" + "Creditos: " + creditos + "\n" + "Facultad: " + facultad + "\n");
        }

        private void btnMetodo1_Click(object sender, EventArgs e)
        {
            //Lllamar al metodo
            MessageBox.Show(asignatura.Instruir());
        }

        private void btnMetodo2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(asignatura.Actualizar());
        }

        private void btnMetodo3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(asignatura.Capacitar());
        }

        private void btnMetodo4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(asignatura.Argumentar());
        }

        private void btnMetodo5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(asignatura.Aplicar());
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPrincipal frmPrincipal = new frmPrincipal();
            frmPrincipal.Show();
        }
    }
}
