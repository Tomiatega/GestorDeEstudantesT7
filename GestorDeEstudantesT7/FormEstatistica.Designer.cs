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
            this.panelMeninos = new System.Windows.Forms.Panel();
            this.panelTotaldeEstudantes = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelMeninas.SuspendLayout();
            this.panelMeninos.SuspendLayout();
            this.panelTotaldeEstudantes.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMeninas
            // 
            this.panelMeninas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panelMeninas.Controls.Add(this.label3);
            this.panelMeninas.Location = new System.Drawing.Point(466, 213);
            this.panelMeninas.Name = "panelMeninas";
            this.panelMeninas.Size = new System.Drawing.Size(293, 178);
            this.panelMeninas.TabIndex = 0;
            this.panelMeninas.MouseEnter += new System.EventHandler(this.panelMeninas_MouseEnter);
            // 
            // panelMeninos
            // 
            this.panelMeninos.BackColor = System.Drawing.Color.Blue;
            this.panelMeninos.Controls.Add(this.label2);
            this.panelMeninos.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelMeninos.Location = new System.Drawing.Point(38, 213);
            this.panelMeninos.Name = "panelMeninos";
            this.panelMeninos.Size = new System.Drawing.Size(313, 178);
            this.panelMeninos.TabIndex = 1;
            this.panelMeninos.MouseEnter += new System.EventHandler(this.panelMeninos_MouseEnter);
            // 
            // panelTotaldeEstudantes
            // 
            this.panelTotaldeEstudantes.BackColor = System.Drawing.Color.Fuchsia;
            this.panelTotaldeEstudantes.Controls.Add(this.label1);
            this.panelTotaldeEstudantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelTotaldeEstudantes.Location = new System.Drawing.Point(38, 25);
            this.panelTotaldeEstudantes.Name = "panelTotaldeEstudantes";
            this.panelTotaldeEstudantes.Size = new System.Drawing.Size(735, 164);
            this.panelTotaldeEstudantes.TabIndex = 2;
            this.panelTotaldeEstudantes.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            this.panelTotaldeEstudantes.MouseEnter += new System.EventHandler(this.panelTotaldeEstudantes_MouseEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(291, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total de estudantes: 999";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Meninos: 50%";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(83, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 26);
            this.label3.TabIndex = 1;
            this.label3.Text = "Meninas: 50%";
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}