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

        private void alumnoToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void laboratorioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Llamar al formulario laboratorio
            this.Hide();
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void pPPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Llamar al formulario PPP
            this.Hide();
            Form4 form4 = new Form4();
            form4.Show();
        }

        private void notasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Llamar al formulario notas
            this.Hide();
            Form5 form5 = new Form5();
            form5.Show();
        }

        private void asignaturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Llamar al formulario asignatura
            this.Hide();
            Form6 form6 = new Form6();
            form6.Show();
        }

        private void rectorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Llamar al formulario rector
            Form7 form7 = new Form7();
            form7.Show();
        }

        private void jefePracticaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Llamar al formulario JefePractica
            Form8 form8 = new Form8();
            form8.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                MessageBox.Show("Se cerro el programa");
                Application.Exit();
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
