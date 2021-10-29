
namespace CapaPresentacion
{
    partial class Form4
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
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.txtFechaNac = new System.Windows.Forms.TextBox();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.btnLeer = new System.Windows.Forms.Button();
            this.btnEscribir = new System.Windows.Forms.Button();
            this.btnMetodo1 = new System.Windows.Forms.Button();
            this.btnMetodo2 = new System.Windows.Forms.Button();
            this.btnMetodo3 = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtApellidos
            // 
            this.txtApellidos.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtApellidos.Location = new System.Drawing.Point(239, 46);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(244, 20);
            this.txtApellidos.TabIndex = 0;
            // 
            // txtNombres
            // 
            this.txtNombres.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtNombres.Location = new System.Drawing.Point(239, 96);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(244, 20);
            this.txtNombres.TabIndex = 1;
            // 
            // txtFechaNac
            // 
            this.txtFechaNac.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtFechaNac.Location = new System.Drawing.Point(239, 139);
            this.txtFechaNac.Name = "txtFechaNac";
            this.txtFechaNac.Size = new System.Drawing.Size(244, 20);
            this.txtFechaNac.TabIndex = 2;
            // 
            // txtCelular
            // 
            this.txtCelular.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtCelular.Location = new System.Drawing.Point(239, 183);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(244, 20);
            this.txtCelular.TabIndex = 3;
            // 
            // btnLeer
            // 
            this.btnLeer.BackColor = System.Drawing.SystemColors.Info;
            this.btnLeer.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeer.Location = new System.Drawing.Point(414, 242);
            this.btnLeer.Name = "btnLeer";
            this.btnLeer.Size = new System.Drawing.Size(94, 44);
            this.btnLeer.TabIndex = 4;
            this.btnLeer.Text = "Leer";
            this.btnLeer.UseVisualStyleBackColor = false;
            this.btnLeer.Click += new System.EventHandler(this.btnLeer_Click);
            // 
            // btnEscribir
            // 
            this.btnEscribir.BackColor = System.Drawing.SystemColors.Info;
            this.btnEscribir.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEscribir.Location = new System.Drawing.Point(199, 242);
            this.btnEscribir.Name = "btnEscribir";
            this.btnEscribir.Size = new System.Drawing.Size(94, 44);
            this.btnEscribir.TabIndex = 5;
            this.btnEscribir.Text = "Escribir";
            this.btnEscribir.UseVisualStyleBackColor = false;
            this.btnEscribir.Click += new System.EventHandler(this.btnEscribir_Click);
            // 
            // btnMetodo1
            // 
            this.btnMetodo1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnMetodo1.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMetodo1.Location = new System.Drawing.Point(170, 348);
            this.btnMetodo1.Name = "btnMetodo1";
            this.btnMetodo1.Size = new System.Drawing.Size(88, 39);
            this.btnMetodo1.TabIndex = 6;
            this.btnMetodo1.Text = "Metodo 1 ( )";
            this.btnMetodo1.UseVisualStyleBackColor = false;
            this.btnMetodo1.Click += new System.EventHandler(this.btnMetodo1_Click);
            // 
            // btnMetodo2
            // 
            this.btnMetodo2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnMetodo2.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMetodo2.Location = new System.Drawing.Point(314, 348);
            this.btnMetodo2.Name = "btnMetodo2";
            this.btnMetodo2.Size = new System.Drawing.Size(88, 39);
            this.btnMetodo2.TabIndex = 7;
            this.btnMetodo2.Text = "Metodo 2 ( )";
            this.btnMetodo2.UseVisualStyleBackColor = false;
            this.btnMetodo2.Click += new System.EventHandler(this.btnMetodo2_Click);
            // 
            // btnMetodo3
            // 
            this.btnMetodo3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnMetodo3.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMetodo3.Location = new System.Drawing.Point(458, 348);
            this.btnMetodo3.Name = "btnMetodo3";
            this.btnMetodo3.Size = new System.Drawing.Size(88, 39);
            this.btnMetodo3.TabIndex = 8;
            this.btnMetodo3.Text = "Metodo 3 ( )";
            this.btnMetodo3.UseVisualStyleBackColor = false;
            this.btnMetodo3.Click += new System.EventHandler(this.btnMetodo3_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnVolver.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(634, 242);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(104, 52);
            this.btnVolver.TabIndex = 9;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnMetodo3);
            this.Controls.Add(this.btnMetodo2);
            this.Controls.Add(this.btnMetodo1);
            this.Controls.Add(this.btnEscribir);
            this.Controls.Add(this.btnLeer);
            this.Controls.Add(this.txtCelular);
            this.Controls.Add(this.txtFechaNac);
            this.Controls.Add(this.txtNombres);
            this.Controls.Add(this.txtApellidos);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.TextBox txtFechaNac;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.Button btnLeer;
        private System.Windows.Forms.Button btnEscribir;
        private System.Windows.Forms.Button btnMetodo1;
        private System.Windows.Forms.Button btnMetodo2;
        private System.Windows.Forms.Button btnMetodo3;
        private System.Windows.Forms.Button btnVolver;
    }
}