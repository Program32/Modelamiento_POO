
namespace CapaPresentacion
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.btnSalir = new System.Windows.Forms.Button();
            this.mantenimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alumnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.docenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laboratorioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asignaturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rectorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jefePracticaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pPPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSalir.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(644, 368);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(96, 40);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // mantenimientoToolStripMenuItem
            // 
            this.mantenimientoToolStripMenuItem.BackColor = System.Drawing.Color.LightBlue;
            this.mantenimientoToolStripMenuItem.CheckOnClick = true;
            this.mantenimientoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alumnoToolStripMenuItem,
            this.docenteToolStripMenuItem,
            this.laboratorioToolStripMenuItem,
            this.notasToolStripMenuItem,
            this.asignaturaToolStripMenuItem,
            this.rectorToolStripMenuItem,
            this.jefePracticaToolStripMenuItem,
            this.pPPToolStripMenuItem});
            this.mantenimientoToolStripMenuItem.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mantenimientoToolStripMenuItem.ForeColor = System.Drawing.Color.DarkRed;
            this.mantenimientoToolStripMenuItem.Name = "mantenimientoToolStripMenuItem";
            this.mantenimientoToolStripMenuItem.Size = new System.Drawing.Size(138, 26);
            this.mantenimientoToolStripMenuItem.Text = "Mantenimiento";
            // 
            // alumnoToolStripMenuItem
            // 
            this.alumnoToolStripMenuItem.BackColor = System.Drawing.SystemColors.Info;
            this.alumnoToolStripMenuItem.Name = "alumnoToolStripMenuItem";
            this.alumnoToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.alumnoToolStripMenuItem.Text = "> Alumno";
            this.alumnoToolStripMenuItem.Click += new System.EventHandler(this.alumnoToolStripMenuItem_Click);
            // 
            // docenteToolStripMenuItem
            // 
            this.docenteToolStripMenuItem.BackColor = System.Drawing.SystemColors.Info;
            this.docenteToolStripMenuItem.Name = "docenteToolStripMenuItem";
            this.docenteToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.docenteToolStripMenuItem.Text = "> Docente";
            this.docenteToolStripMenuItem.Click += new System.EventHandler(this.docenteToolStripMenuItem_Click);
            // 
            // laboratorioToolStripMenuItem
            // 
            this.laboratorioToolStripMenuItem.BackColor = System.Drawing.SystemColors.Info;
            this.laboratorioToolStripMenuItem.Name = "laboratorioToolStripMenuItem";
            this.laboratorioToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.laboratorioToolStripMenuItem.Text = "> Laboratorio";
            this.laboratorioToolStripMenuItem.Click += new System.EventHandler(this.laboratorioToolStripMenuItem_Click);
            // 
            // notasToolStripMenuItem
            // 
            this.notasToolStripMenuItem.BackColor = System.Drawing.SystemColors.Info;
            this.notasToolStripMenuItem.Name = "notasToolStripMenuItem";
            this.notasToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.notasToolStripMenuItem.Text = "> Notas";
            this.notasToolStripMenuItem.Click += new System.EventHandler(this.notasToolStripMenuItem_Click);
            // 
            // asignaturaToolStripMenuItem
            // 
            this.asignaturaToolStripMenuItem.BackColor = System.Drawing.SystemColors.Info;
            this.asignaturaToolStripMenuItem.Name = "asignaturaToolStripMenuItem";
            this.asignaturaToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.asignaturaToolStripMenuItem.Text = "> Asignatura ";
            this.asignaturaToolStripMenuItem.Click += new System.EventHandler(this.asignaturaToolStripMenuItem_Click);
            // 
            // rectorToolStripMenuItem
            // 
            this.rectorToolStripMenuItem.BackColor = System.Drawing.SystemColors.Info;
            this.rectorToolStripMenuItem.Name = "rectorToolStripMenuItem";
            this.rectorToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.rectorToolStripMenuItem.Text = "> Rector";
            this.rectorToolStripMenuItem.Click += new System.EventHandler(this.rectorToolStripMenuItem_Click);
            // 
            // jefePracticaToolStripMenuItem
            // 
            this.jefePracticaToolStripMenuItem.BackColor = System.Drawing.SystemColors.Info;
            this.jefePracticaToolStripMenuItem.Name = "jefePracticaToolStripMenuItem";
            this.jefePracticaToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.jefePracticaToolStripMenuItem.Text = "> JefePractica";
            this.jefePracticaToolStripMenuItem.Click += new System.EventHandler(this.jefePracticaToolStripMenuItem_Click);
            // 
            // pPPToolStripMenuItem
            // 
            this.pPPToolStripMenuItem.BackColor = System.Drawing.SystemColors.Info;
            this.pPPToolStripMenuItem.Name = "pPPToolStripMenuItem";
            this.pPPToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.pPPToolStripMenuItem.Text = "> PPP";
            this.pPPToolStripMenuItem.Click += new System.EventHandler(this.pPPToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema Administrativo UAC";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alumnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem docenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem laboratorioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asignaturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rectorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jefePracticaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pPPToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}