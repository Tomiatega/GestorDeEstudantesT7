using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GestorDeEstudantesT7
{
    public partial class Formlistadeestudantes : Form
    {
        public Formlistadeestudantes()
        {
            InitializeComponent();
        }
        Estudante estudante = new Estudante();  
        private void Formlistadeestudantes_Load(object sender, EventArgs e)
        {
            //Preenche o dataGaeidView com as informações dos estudantes
            MySqlCommand comando = new MySqlCommand("SELECT * `estudantes`");
            //Impede que os dados na tabela sejam alterados.
            dataGridViewListadealunos.ReadOnly = true;
            //Cria uma coluna para exibir as fotos dos alunos.
            DataGridViewImageColumn colunaDeFotos = new DataGridViewImageColumn();
            //Determine uma altura padrão para as linhas de tabela
            dataGridViewListadealunos.RowTemplate.Height = 80;
            //Determina a origem dos dados da tabela.
            dataGridViewListadealunos.DataSource = estudante.getEstudantes(comando);
            //Preenche a coluna com as imagens.
            colunaDeFotos = (DataGridViewImageColumn)dataGridViewListaDeAlunos.Columns[7];
            colunaDeFotos.ImageLayout = DataGridViewImageCellLayout.Stretch;
            //Impede o usuário de incluir linhas.
            dataGridViewListaDeAlunos.AllowUserToAddRows = false;


        }

    }
}
