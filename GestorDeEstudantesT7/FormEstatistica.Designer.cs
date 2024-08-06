namespace GestorDeEstudantesT7
{
    partial class FormEstatistica
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
            this.panelMeninas = new System.Windows.Forms.Panel();
            this.labelMeninas = new System.Windows.Forms.Label();
            this.panelMeninos = new System.Windows.Forms.Panel();
            this.labelMeninos = new System.Windows.Forms.Label();
            this.panelTotaldeEstudantes = new System.Windows.Forms.Panel();
            this.labelTotalDeEstudantes = new System.Windows.Forms.Label();
            this.panelMeninas.SuspendLayout();
            this.panelMeninos.SuspendLayout();
            this.panelTotaldeEstudantes.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMeninas
            // 
            this.panelMeninas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panelMeninas.Controls.Add(this.labelMeninas);
            this.panelMeninas.Location = new System.Drawing.Point(466, 213);
            this.panelMeninas.Name = "panelMeninas";
            this.panelMeninas.Size = new System.Drawing.Size(293, 178);
            this.panelMeninas.TabIndex = 0;
            // 
            // labelMeninas
            // 
            this.labelMeninas.AutoSize = true;
            this.labelMeninas.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMeninas.Location = new System.Drawing.Point(83, 83);
            this.labelMeninas.Name = "labelMeninas";
            this.labelMeninas.Size = new System.Drawing.Size(150, 26);
            this.labelMeninas.TabIndex = 1;
            this.labelMeninas.Text = "Meninas: 50%";
            this.labelMeninas.MouseEnter += new System.EventHandler(this.labelMeninas_MouseEnter);
            this.labelMeninas.MouseLeave += new System.EventHandler(this.labelMeninas_MouseLeave);
            // 
            // panelMeninos
            // 
            this.panelMeninos.BackColor = System.Drawing.Color.Blue;
            this.panelMeninos.Controls.Add(this.labelMeninos);
            this.panelMeninos.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelMeninos.Location = new System.Drawing.Point(38, 213);
            this.panelMeninos.Name = "panelMeninos";
            this.panelMeninos.Size = new System.Drawing.Size(313, 178);
            this.panelMeninos.TabIndex = 1;
            // 
            // labelMeninos
            // 
            this.labelMeninos.AutoSize = true;
            this.labelMeninos.Location = new System.Drawing.Point(94, 83);
            this.labelMeninos.Name = "labelMeninos";
            this.labelMeninos.Size = new System.Drawing.Size(150, 26);
            this.labelMeninos.TabIndex = 1;
            this.labelMeninos.Text = "Meninos: 50%";
            this.labelMeninos.MouseEnter += new System.EventHandler(this.labelMeninos_MouseEnter);
            this.labelMeninos.MouseLeave += new System.EventHandler(this.labelMeninos_MouseLeave);
            // 
            // panelTotaldeEstudantes
            // 
            this.panelTotaldeEstudantes.BackColor = System.Drawing.Color.Fuchsia;
            this.panelTotaldeEstudantes.Controls.Add(this.labelTotalDeEstudantes);
            this.panelTotaldeEstudantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelTotaldeEstudantes.Location = new System.Drawing.Point(38, 25);
            this.panelTotaldeEstudantes.Name = "panelTotaldeEstudantes";
            this.panelTotaldeEstudantes.Size = new System.Drawing.Size(735, 164);
            this.panelTotaldeEstudantes.TabIndex = 2;
            // 
            // labelTotalDeEstudantes
            // 
            this.labelTotalDeEstudantes.AutoSize = true;
            this.labelTotalDeEstudantes.Location = new System.Drawing.Point(291, 67);
            this.labelTotalDeEstudantes.Name = "labelTotalDeEstudantes";
            this.labelTotalDeEstudantes.Size = new System.Drawing.Size(249, 26);
            this.labelTotalDeEstudantes.TabIndex = 0;
            this.labelTotalDeEstudantes.Text = "Total de estudantes: 999";
            this.labelTotalDeEstudantes.MouseEnter += new System.EventHandler(this.labelTotalDeEstudantes_MouseEnter);
            this.labelTotalDeEstudantes.MouseLeave += new System.EventHandler(this.labelTotalDeEstudantes_MouseLeave);
            // 
            // FormEstatistica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelTotaldeEstudantes);
            this.Controls.Add(this.panelMeninos);
            this.Controls.Add(this.panelMeninas);
            this.Name = "FormEstatistica";
            this.Text = "FormEstatistica";
            this.Load += new System.EventHandler(this.FormEstatistica_Load);
            this.panelMeninas.ResumeLayout(false);
            this.panelMeninas.PerformLayout();
            this.panelMeninos.ResumeLayout(false);
            this.panelMeninos.PerformLayout();
            this.panelTotaldeEstudantes.ResumeLayout(false);
            this.panelTotaldeEstudantes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMeninas;
        private System.Windows.Forms.Panel panelMeninos;
        private System.Windows.Forms.Panel panelTotaldeEstudantes;
        private System.Windows.Forms.Label labelTotalDeEstudantes;
        private System.Windows.Forms.Label labelMeninas;
        private System.Windows.Forms.Label labelMeninos;
    }
}