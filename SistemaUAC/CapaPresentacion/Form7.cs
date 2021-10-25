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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        //Declarar un objeto de la clase
        Rector rector = new Rector();
        private void btnLeer_Click(object sender, EventArgs e)
        {
            //Leer datos
            string nombres = txtNombres.Text.Trim();
            string apellidos = txtApellidos.Text.Trim();
            string profesion = txtProfesion.Text.Trim();
            string correo = txtCorreo.Text.Trim();
            string celular = txtCelular.Text.Trim();
            //Escribir los datos del rector en el objeto
            rector.Nombres = nombres;
            rector.Apellidos = apellidos;
            rector.Profesion = profesion;
            rector.Correo = correo;
            rector.Celular = celular;
            //Confirmar que se ha escrito el objeto
            MessageBox.Show("Se ha escrito correctamente el objeto");
            //Limpiar las cajas de texto
            txtNombres.Clear();
            txtApellidos.Clear();
            txtProfesion.Clear();
            txtCorreo.Clear();
            txtCelular.Clear();
            //Hacer que el mause este en nombres
            txtNombres.Focus();
        }

        private void btnEscribir_Click(object sender, EventArgs e)
        {
            //Leer las propiedades del objeto
            string nombres = rector.Nombres;
            string apellidos = rector.Apellidos;
            string profesion = rector.Profesion;
            string correo = rector.Correo;
            string celular = rector.Celular;
            MessageBox.Show("Datos del Rector" + "\n" + "Nombres: " + nombres + "\n" + "Apellidos: " + apellidos + "\n" + "Profesion: " + profesion + "\n" +
                                "Correo: " + correo + "\n" + "Celular: " + celular + "\n");
        }

        private void btnMetodo1_Click(object sender, EventArgs e)
        {
            //Llamar al metodo
            MessageBox.Show(rector.Supervizar());
        }

        private void btnMetodo2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(rector.Liderar());
        }

        private void btnMetodo3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(rector.Promover());
        }

        private void btnMetodo4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(rector.Ayudar());
        }

        private void btnMetodo5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(rector.Calificar());
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPrincipal frmPrincipal = new frmPrincipal();
            frmPrincipal.Show();
        }
    }
}
