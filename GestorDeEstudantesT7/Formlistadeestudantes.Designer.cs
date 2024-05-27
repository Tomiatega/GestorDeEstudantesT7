namespace GestorDeEstudantesT7
{
    partial class Formlistadeestudantes
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
            this.dataGridViewListadealunos = new System.Windows.Forms.DataGridView();
            this.buttonCadastrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListadealunos)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewlistadealunos
            // 
            this.dataGridViewListadealunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListadealunos.Location = new System.Drawing.Point(39, 43);
            this.dataGridViewListadealunos.Name = "dataGridViewlistadealunos";
            this.dataGridViewListadealunos.Size = new System.Drawing.Size(722, 301);
            this.dataGridViewListadealunos.TabIndex = 0;
            // 
            // buttonCadastrar
            // 
            this.buttonCadastrar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCadastrar.Location = new System.Drawing.Point(39, 363);
            this.buttonCadastrar.Name = "buttonCadastrar";
            this.buttonCadastrar.Size = new System.Drawing.Size(722, 75);
            this.buttonCadastrar.TabIndex = 25;
            this.buttonCadastrar.Text = "Atualizar";
            this.buttonCadastrar.UseVisualStyleBackColor = false;
            // 
            // Formlistadeestudantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCadastrar);
            this.Controls.Add(this.dataGridViewListadealunos);
            this.Name = "Formlistadeestudantes";
            this.Text = "Formlistadeestudantes";
            this.Load += new System.EventHandler(this.Formlistadeestudantes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListadealunos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewListadealunos;
        private System.Windows.Forms.Button buttonCadastrar;
    }
}