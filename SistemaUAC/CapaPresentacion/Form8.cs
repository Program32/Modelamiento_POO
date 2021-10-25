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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }
        //Declarar un objeto de la clase
        JefePractica jefePractica = new JefePractica();
        private void btnEscribir_Click(object sender, EventArgs e)
        {
            //Leer datos
            string nombres = txtNombres.Text.Trim();
            string codigo = txtCodigo.Text.Trim();
            string celular = txtCelular.Text.Trim();
            string correo = txtCorreo.Text.Trim();
            string especialidad = txtEspecialidad.Text.Trim();
            //Escribir los datos del JefePractica en el objetos
            jefePractica.Nombres = nombres;
            jefePractica.Codigo = codigo;
            jefePractica.Celular = celular;
            jefePractica.Correo = correo;
            jefePractica.Especialidad = especialidad;
            //Confirmar que se ha escrito el mensaje
            MessageBox.Show("Se ha escrito correctamente el objeto");
            //Limipar las cajas de texto
            txtNombres.Clear();
            txtCodigo.Clear();
            txtCelular.Clear();
            txtCorreo.Clear();
            txtEspecialidad.Clear();
            //Hace que el mause este en nombres
            txtNombres.Focus();
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            //Leer las propiedades del objeto
            string nombres = jefePractica.Nombres;
            string codigo = jefePractica.Codigo;
            string celular = jefePractica.Celular;
            string correo = jefePractica.Correo;
            string especialidad = jefePractica.Especialidad;
            MessageBox.Show("Datos del Jefe de Practica" + "\n" + "Nombres: " + nombres + "\n" + "Codigo: " + codigo + "\n" + "Celular: " + celular + "\n" +
                            "Correo: " + correo + "\n" + "Especialidad: " + especialidad + "\n");
        }

        private void btnMetodo1_Click(object sender, EventArgs e)
        {
            //llamar al metodo
            MessageBox.Show(jefePractica.Liderar());
        }

        private void btnMetodo2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(jefePractica.Ensenar());
        }

        private void btnMetodo3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(jefePractica.Orientar());
        }

        private void btnMetodo4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(jefePractica.Colaborar());
        }

        private void btnMetodo5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(jefePractica.Investigar());
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPrincipal frmPrincipal = new frmPrincipal();
            frmPrincipal.Show();
        }
    }
}
