using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorDeEstudantesT7
{
    public partial class FormEstatistica : Form
    {
        public FormEstatistica()
        {
            InitializeComponent();
        }

        Color corPainelTotal;
        Color corPainelMeninos;
        Color corPainelMeninas;

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormEstatistica_Load(object sender, EventArgs e)
        {
            corPainelTotal = panelTotaldeEstudantes.BackColor;
            corPainelMeninos =panelMeninos.BackColor;
            corPainelMeninas =panelMeninas.BackColor;

        }

        private void panelMeninos_MouseEnter(object sender, EventArgs e)
        {
            panelTotaldeEstudantes.BackColor = Color.Black;
            labelTotalDeEstudantes.ForeColor = corPainelTotal;


        }

        private void panelTotaldeEstudantes_MouseEnter(object sender, EventArgs e)
        {

        }

        private void panelMeninas_MouseEnter(object sender, EventArgs e)
        {

        }
    }
}
