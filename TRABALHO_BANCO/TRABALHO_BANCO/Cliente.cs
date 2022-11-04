using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRABALHO_BANCO
{
    public partial class Cliente : Form
    {
        public Cliente()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tRABALHO_BANCODataSet.CLIENTE' table. You can move, or remove it, as needed.
            this.cLIENTETableAdapter.Fill(this.tRABALHO_BANCODataSet.CLIENTE);

        }

        private void LimparForm()
        {
            txId.Clear();
            txName.Clear();
            txEmail.Clear();
            mtxCPF.Clear();
            mtxTelefone.Clear();
        }

        private void btInserir_Click(object sender, EventArgs e)
        {
            SqlConnection conn;
            SqlCommand comm;
            bool isOK = true;

            // Recupera a string de conexão com os dados do servidor e da base de dados
            string connectionString = Properties.Settings.Default.TRABALHO_BANCOConnectionString;

            // Iniciar a conexão com o Banco de Dados
            conn = new SqlConnection(connectionString);

            // Cria o comando SQL
            comm = new SqlCommand(
                "INSERT INTO CLIENTE (CLI_NOME, CLI_CPF, CLI_TELEFONE, CLI_EMAIL) " +
                "VALUES (@CLI_NOME, @CLI_CPF, @CLI_TELEFONE, @CLI_EMAIL)", conn);

            // Declara e atribui os valores para as variáveis

            comm.Parameters.Add("@CLI_NOME", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@CLI_NOME"].Value = txName.Text;

            comm.Parameters.Add("@CLI_CPF", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@CLI_CPF"].Value = mtxCPF.Text;

            comm.Parameters.Add("@CLI_TELEFONE", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@CLI_TELEFONE"].Value = mtxTelefone.Text;

            comm.Parameters.Add("@CLI_EMAIL", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@CLI_EMAIL"].Value = txEmail.Text;


            try
            {
                // Tentar abrir uma conexão com o Servidor/Base de dados
                try
                {
                    conn.Open();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message,
                        "Erro ao abrir conexão com o Banco de Dados",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    isOK = false;
                }

                // Tentar executar o comando SQL
                try
                {
                    comm.ExecuteNonQuery();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message,
                        "Erro ao tentar executar o comando SQL",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    isOK = false;
                }
            }
            catch { }
            finally
            {
                conn.Close(); // Fecha a conexão com o Banco de Dados

                if (isOK == true)
                {
                    MessageBox.Show("Cliente cadastrado com sucesso!",
                            "INSERT",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                    // Atualizar a lista de cidades 
                    this.cLIENTETableAdapter.Fill(this.tRABALHO_BANCODataSet.CLIENTE);
                }
            }

            LimparForm();

        }

        private void btDeletar_Click(object sender, EventArgs e)
        {
            SqlConnection conn;
            SqlCommand comm;
            bool isOK = true;

            // Recupera a string de conexão com os dados do servidor e da base de dados
            string connectionString = Properties.Settings.Default.TRABALHO_BANCOConnectionString;

            // Iniciar a conexão com o Banco de Dados
            conn = new SqlConnection(connectionString);

            // Cria o comando SQL
            comm = new SqlCommand(
                "DELETE FROM CLIENTE " +
                "WHERE CLI_ID = @CLI_ID", conn);

            // Declara e atribui os valores para as variáveis
            comm.Parameters.Add("@CLI_ID", System.Data.SqlDbType.Int);
            comm.Parameters["@CLI_ID"].Value = Convert.ToInt32(txId.Text);


            try
            {
                // Tentar abrir uma conexão com o Servidor/Base de dados
                try
                {
                    conn.Open();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message,
                        "Erro ao abrir conexão com o Banco de Dados",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    isOK = false;
                }

                // Tentar executar o comando SQL
                try
                {
                    comm.ExecuteNonQuery();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message,
                        "Erro ao tentar executar o comando SQL",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    isOK = false;
                }
            }
            catch { }
            finally
            {
                conn.Close(); // Fecha a conexão com o Banco de Dados

                if (isOK == true)
                {
                    MessageBox.Show("Cliente deletado com sucesso!",
                            "DELETE",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                    // Atualizar a lista de cidades 
                    this.cLIENTETableAdapter.Fill(this.tRABALHO_BANCODataSet.CLIENTE);
                }
            }

            LimparForm();

        } // FIM DO EVENTO btExcluir_Click

        private void mtxCPF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btConsultar_Click(object sender, EventArgs e)
        {
            SqlConnection conn;
            SqlCommand comm;
            SqlDataReader reader;

            bool isOK = true;

            // Recupera a string de conexão com os dados do servidor e da base de dados
            string connectionString = Properties.Settings.Default.TRABALHO_BANCOConnectionString;

            // Iniciar a conexão com o Banco de Dados
            conn = new SqlConnection(connectionString);

            // Cria o comando SQL
            comm = new SqlCommand(
                "SELECT CLI_ID, CLI_NOME, CLI_CPF, CLI_TELEFONE, CLI_EMAIL " +
                "FROM CLIENTE " +
                "WHERE CLI_ID = @CLI_ID", conn);

            // Declara e atribui os valores para as variáveis
            comm.Parameters.Add("@CLI_ID", System.Data.SqlDbType.Int);
            comm.Parameters["@CLI_ID"].Value = Convert.ToInt32(txId.Text);



            try
            {
                // Tentar abrir uma conexão com o Servidor/Base de dados
                try
                {
                    conn.Open();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message,
                        "Erro ao abrir conexão com o Banco de Dados",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    isOK = false;
                }

                // Tentar executar o comando SQL
                try
                {
                    reader = comm.ExecuteReader();

                    if (reader.Read())
                    {
                        txName.Text = reader["CLI_NOME"].ToString();
                        mtxCPF.Text = reader["CLI_CPF"].ToString();
                        mtxTelefone.Text = reader["CLI_TELEFONE"].ToString();
                        txEmail.Text = reader["CLI_EMAIL"].ToString();
                    }

                    reader.Close();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message,
                        "Erro ao tentar executar o comando SQL",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    isOK = false;
                }
            }
            catch { }
            finally
            {
                conn.Close(); // Fecha a conexão com o Banco de Dados                
            }
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            SqlConnection conn;
            SqlCommand comm;
            bool isOK = true;

            // Recupera a string de conexão com os dados do servidor e da base de dados
            string connectionString = Properties.Settings.Default.TRABALHO_BANCOConnectionString;

            // Iniciar a conexão com o Banco de Dados
            conn = new SqlConnection(connectionString);

            // Cria o comando SQL
            comm = new SqlCommand(
                "UPDATE CLIENTE SET CLI_NOME=@CLI_NOME, CLI_TELEFONE=@CLI_TELEFONE, CLI_CPF=@CLI_CPF, CLI_EMAIL=@CLI_EMAIL " +
                "WHERE CLI_ID = @CLI_ID", conn);

            // Declara e atribui os valores para as variáveis
            comm.Parameters.Add("@CLI_ID", System.Data.SqlDbType.Int);
            comm.Parameters["@CLI_ID"].Value = Convert.ToInt32(txId.Text);

            comm.Parameters.Add("@CLI_NOME", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@CLI_NOME"].Value = txName.Text;

            comm.Parameters.Add("@CLI_CPF", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@CLI_CPF"].Value = mtxCPF.Text;

            comm.Parameters.Add("@CLI_TELEFONE", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@CLI_TELEFONE"].Value = mtxTelefone.Text;

            comm.Parameters.Add("@CLI_EMAIL", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@CLI_EMAIL"].Value = txEmail.Text;

            try
            {
                // Tentar abrir uma conexão com o Servidor/Base de dados
                try
                {
                    conn.Open();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message,
                        "Erro ao abrir conexão com o Banco de Dados",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    isOK = false;
                }

                // Tentar executar o comando SQL
                try
                {
                    comm.ExecuteNonQuery();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message,
                        "Erro ao tentar executar o comando SQL",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    isOK = false;
                }
            }
            catch { }
            finally
            {
                conn.Close(); // Fecha a conexão com o Banco de Dados

                if (isOK == true)
                {
                    MessageBox.Show("Cliente alterado com sucesso!",
                            "UPDATE",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                    // Atualizar a lista de cidades 
                    this.cLIENTETableAdapter.Fill(this.tRABALHO_BANCODataSet.CLIENTE);
                }
            }

            LimparForm();
        }
    }
}
