using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Llamar a la capac negocio
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        //Declarar un objeto a la clase
        Notas notas = new Notas();
        private void btnEscribir_Click(object sender, EventArgs e)
        {
            //Leer datos
            string promedio = txtPromedio.Text.Trim();
            string curso = txtCurso.Text.Trim();
            string rubrica = txtRubrica.Text.Trim();
            string notaAprobatoria = txtnotaAprobatoria.Text.Trim();
            string ponderado = txtPonderado.Text.Trim();
            //Escribir los datos de la nota en el proyecto
            notas.Promedio = promedio;
            notas.Curso = curso;
            notas.Rubrica = rubrica;
            notas.NotaAprobatoria = notaAprobatoria;
            notas.Ponderada = ponderado;
            //Confirmar que se ha escrito el mensaje
            MessageBox.Show("Se ha escrito correctamente el objeto");
            //Limpiar las cajas de texto
            txtPromedio.Clear();
            txtCurso.Clear();
            txtRubrica.Clear();
            txtnotaAprobatoria.Clear();
            txtPonderado.Clear();
            //Hacer que el mause este en promedio
            txtPromedio.Focus();
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            //Leer las propiedades del objeto
            string promedio = notas.Promedio;
            string curso = notas.Curso;
            string rubrica = notas.Rubrica;
            string notaAprobatoria = notas.NotaAprobatoria;
            string ponderado = notas.Ponderada;
            MessageBox.Show("Datos de las notas" + "\n" + "Promedio: " + promedio + "\n" + "Curso: " + curso + "\n" +
                                "Rubrica: " + rubrica + "\n" + "Nota Aprobatoria: " + notaAprobatoria + "\n" + "Ponderado: " + ponderado + "\n");
        }

        private void btnMetodo1_Click(object sender, EventArgs e)
        {
            //Llamar al metodo
            MessageBox.Show(notas.Aprobar());
        }

        private void btnMetodo2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(notas.Desaprobar());
        }

        private void btnMetodo3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(notas.Valorar());
        }

        private void btnMetodo4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(notas.Justificar());
        }

        private void btnMetodo5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(notas.Evaluar());
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPrincipal frmPrincipal = new frmPrincipal();
            frmPrincipal.Show();
        }
    }
}
