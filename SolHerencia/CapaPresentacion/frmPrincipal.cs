using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void personaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Llamar al formulario persona
            this.Hide();
            Form4 form4 = new Form4();
            form4.Show();
        }

        private void aumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Llamar al formulario alumno
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void docenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Llamar al formulario docente
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void administrativoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Llamar al formulario administrativo
            this.Hide();
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                MessageBox.Show("Se cerro el programa");
                Application.Exit();
            }
        }

        private void mantenimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
