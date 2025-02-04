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
    public partial class ConsultaCliente : Form
    {
        public ConsultaCliente()
        {
            InitializeComponent();
        }

        private void ConsultaCliente_Load(object sender, EventArgs e)
        {

        }
        private void ListarClientes()
        {

        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            // Definindo a string de conexão
            string connectionString = "Server=localhost;Port=3306;Database=bd_sistema;User ID=root;Password=;";

            try
            {
                // Cria a conexão com o banco de dados MySQL
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    // Abre a conexão
                    conn.Open();

                    // Consulta SQL para selecionar todos os clientes
                    string query = "SELECT id_Cliente , NomeCompleto, CPF, Telefone FROM tb_clientes";

                    // Cria o comando MySQL
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        // Executa a consulta e obtém os resultados
                        MySqlDataReader reader = cmd.ExecuteReader();

                        // Cria uma lista para armazenar os registros
                        DataTable dtClientes = new DataTable();
                        dtClientes.Load(reader);

                        // Atribui a tabela de dados ao DataGridView
                        dgvClientes.DataSource = dtClientes;
                    }
                }
            }
            catch (Exception ex)
            {
                // Exibe erro caso haja falha
                MessageBox.Show("Erro ao listar clientes: " + ex.Message);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count > 0)
            {
                // Pega o ID do cliente da linha selecionada (assumindo que o ID é a primeira coluna)
                int clienteId = Convert.ToInt32(dgvClientes.SelectedRows[0].Cells["id_Cliente"].Value);

                // Confirmação de exclusão
                DialogResult result = MessageBox.Show("Tem certeza que deseja excluir este cliente?", "Confirmar Exclusão", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    // String de conexão com o banco de dados MySQL
                    string connectionString = "Server=localhost;Port=3306;Database=bd_sistema;User ID=root;Password=;";

                    try
                    {
                        // Conecta com o banco de dados MySQL
                        using (MySqlConnection conn = new MySqlConnection(connectionString))
                        {
                            conn.Open();

                            // SQL para excluir o cliente
                            string query = "DELETE FROM tb_clientes WHERE id_Cliente = @id_Cliente";

                            // Cria o comando MySQL
                            using (MySqlCommand cmd = new MySqlCommand(query, conn))
                            {
                                // Adiciona o parâmetro ID
                                cmd.Parameters.AddWithValue("@id_Cliente", clienteId);

                                // Executa o comando de exclusão
                                int rowsAffected = cmd.ExecuteNonQuery();

                                // Se a exclusão for bem-sucedida, atualiza a lista de clientes
                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Cliente excluído com sucesso!");
                                    
                                }
                                else
                                {
                                    MessageBox.Show("Falha ao excluir o cliente.");
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        // Exibe erro em caso de falha na exclusão
                        MessageBox.Show("Erro: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecione um cliente para excluir.");
            }
        }
    }
    }

