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

namespace Sitema2
{
    public partial class GerenciamentoClientes : Form
    {
        public GerenciamentoClientes()
        {
            InitializeComponent();
        }

        private void buttonPequisar_Click(object sender, EventArgs e)
        {

            //Defina sua string de conexão com o banco
            string connectionString = "Server=localhost; Port=3306; Database=bd_sistema; Uid=root; Pwd=;";

            try
            {
                //Cria uma conexão com o banco de dados Mysql
                using (MySqlConnection consulta = new MySqlConnection(connectionString))
                {
                    //abre a conexão 
                    consulta.Open();
                    //consulta SQL para selecionar os clientes
                    string listagem = "SELECT id_Cliente, nomeCompleto, Telefone FROM tb_clientes";

                    //Cria o comando Mysql
                    using (MySqlCommand cmd = new MySqlCommand(listagem, consulta))
                    {
                        //Executa a consulta e obtém o resultados
                        MySqlDataReader reader = cmd.ExecuteReader();

                        //Cria uma lista para armazenar os registros
                        DataTable dadosClientes = new DataTable();
                        dadosClientes.Load(reader);

                        //Atribui a tabela de dados ao DataGridView
                        dgvClientes.DataSource = dadosClientes;
                     }
                }
            }
            catch ( Exception ex)
            {
                MessageBox.Show("Erro ao listar os clientes:" + ex.Message);
            }

        }
    }
}
