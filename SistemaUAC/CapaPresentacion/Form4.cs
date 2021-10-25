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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        //Declarar un objeto de la clase
        PPP ppp = new PPP();

        private void btnEscribir_Click(object sender, EventArgs e)
        {
            //Leer datos
            string carrera = txtCarrera.Text.Trim();
            string requisitos = txtRequisitos.Text.Trim();
            string creditaje = txtCreditaje.Text.Trim();
            string duracion = txtDuracion.Text.Trim();
            string lugar = txtLugar.Text.Trim();
            string supervisor = txtSupervisor.Text.Trim();
            //Escribir los datos del PPP en el objeto
            ppp.Carrera = carrera;
            ppp.Requisitos = requisitos;
            ppp.Creditaje = creditaje;
            ppp.Duracion = duracion;
            ppp.Lugar = lugar;
            ppp.Supervisor = supervisor;
            //Confirmar se ha escrito el mensaje
            MessageBox.Show("Se ha escrito correctamente el objeto");
            //Limpiar las cajas de texto
            txtCarrera.Clear();
            txtRequisitos.Clear();
            txtCreditaje.Clear();
            txtDuracion.Clear();
            txtLugar.Clear();
            txtSupervisor.Clear();
            //Hacer que el mouse este en carrera
            txtCarrera.Focus();
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            //Leer las propiedades del objeto
            string carrera = ppp.Carrera;
            string requisitos = ppp.Requisitos;
            string creditaje = ppp.Creditaje;
            string duracion = ppp.Duracion;
            string lugar = ppp.Lugar;
            string supervisor = ppp.Supervisor;
            MessageBox.Show("Datos de las PPP" + "\n" + "Carrera: " + carrera + "\n" + "Requisitos: " + requisitos + "\n" +
                                "Creditaje: " + creditaje + "\n" + "Duracion" + duracion + "\n" + "Lugar: " + lugar + "\n" +
                                    "Supervisor: " + supervisor + "\n");
        }

        private void btnMetodo1_Click(object sender, EventArgs e)
        {
            //Llamar al metodo
            MessageBox.Show(ppp.Practicar());
        }

        private void btnMetodo2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ppp.Aprender());
        }

        private void btnMetodo3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ppp.Trabajar());
        }

        private void btnMetodo4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ppp.Capacitar());
        }

        private void btnMetodo5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ppp.Interactuar());
        }

        private void btnMetodo6_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ppp.Experimentar());
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPrincipal frmPrincipal = new frmPrincipal();
            frmPrincipal.Show();
        }
    }
}
