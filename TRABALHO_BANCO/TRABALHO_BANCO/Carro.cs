using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace TRABALHO_BANCO
{
    public partial class Carro : Form
    {
        public Carro()
        {
            InitializeComponent();
        }

        private void Carro_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tRABALHO_BANCODataSet.DataTable1' table. You can move, or remove it, as needed.
            this.dataTable1TableAdapter.FillGridView(this.tRABALHO_BANCODataSet.DataTable1);

        }

        private void LimparForm()
        {
           
            txPlaca.Clear();
            txAnoFabric.Clear();

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
                "INSERT INTO CARRO (CAR_PLACA, CAR_ANOFABRIC, CAR_MODCOD, CAR_CLIID) " +
                "VALUES (@CAR_PLACA, @CAR_ANOFABRIC, @MARC_COD, @CAR_CLIID)", conn);



            comm.Parameters.Add("@CAR_CLIID", System.Data.SqlDbType.Int);
            comm.Parameters["@CAR_CLIID"].Value = cbCliente.SelectedValue;

            comm.Parameters.Add("@CAR_PLACA", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@CAR_PLACA"].Value = txPlaca.Text;

            comm.Parameters.Add("@CAR_ANOFABRIC", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@CAR_ANOFABRIC"].Value = txAnoFabric.Text;

            comm.Parameters.Add("@MARC_COD", System.Data.SqlDbType.Int);
            comm.Parameters["@MARC_COD"].Value = cbMarca.SelectedValue;

            comm.Parameters.Add("@MOD_COD", System.Data.SqlDbType.Int);
            comm.Parameters["@MOD_COD"].Value = cbModelo.SelectedValue;


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
                    MessageBox.Show("Carro cadastrado com sucesso!",
                            "INSERT",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                    // Atualizar a lista de cidades

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
                "DELETE FROM CARRO " +
                "WHERE CAR_PLACA = @CAR_PLACA", conn);

            // Declara e atribui os valores para as variáveis
            comm.Parameters.Add("@CAR_PLACA", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@CAR_PLACA"].Value = txPlaca.Text;


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
                    MessageBox.Show("Carro deletado com sucesso!",
                            "DELETE",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                    // Atualizar a lista de cidades 

                }
            }

            LimparForm();
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
                "UPDATE CARRO SET CARRO.CAR_PLACA=@CAR_PLACA, CARRO.CAR_ANOFABRIC=@CAR_ANOFABRIC, CARRO.CAR_MODCOD=@MARC_COD, CARRO.CAR_CLIID=@CLI_ID " +              
                "WHERE CAR_PLACA = @CAR_PLACA ", conn);
         
         
            // Declara e atribui os valores para as variáveis
            comm.Parameters.Add("@CLI_ID", System.Data.SqlDbType.Int);
            comm.Parameters["@CLI_ID"].Value = cbCliente.SelectedValue;

            comm.Parameters.Add("@CAR_PLACA", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@CAR_PLACA"].Value = txPlaca.Text;

            comm.Parameters.Add("@CAR_ANOFABRIC", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@CAR_ANOFABRIC"].Value = txAnoFabric.Text;

            comm.Parameters.Add("@MARC_COD", System.Data.SqlDbType.Int);
            comm.Parameters["@MARC_COD"].Value = cbMarca.SelectedValue;

            comm.Parameters.Add("@MOD_COD", System.Data.SqlDbType.Int);
            comm.Parameters["@MOD_COD"].Value = cbModelo.SelectedValue;

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
                    MessageBox.Show("Carro alterado com sucesso!",
                            "UPDATE",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                    // Atualizar a lista de cidades 

                }
            }

            LimparForm();
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
                "SELECT CARRO.CAR_PLACA, CARRO.CAR_ANOFABRIC, MODELO.MOD_MODELO, MARCA.MARC_MARCA, CLIENTE.CLI_NOME " +
                "FROM CARRO " +
                "INNER JOIN MODELO ON CARRO.CAR_MODCOD = MODELO.MOD_COD " +
                "INNER JOIN MARCA ON MODELO.MOD_MARCCOD = MARCA.MARC_COD " +
                "INNER JOIN CLIENTE ON CARRO.CAR_CLIID = CLIENTE.CLI_ID " + 
                "WHERE CAR_PLACA = @CAR_PLACA ", conn);

            // Declara e atribui os valores para as variáveis
    

            comm.Parameters.Add("@CAR_PLACA", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@CAR_PLACA"].Value = txPlaca.Text;

            comm.Parameters.Add("@CAR_CLIID", System.Data.SqlDbType.Int);
            comm.Parameters["@CAR_CLIID"].Value = cbCliente.SelectedValue;

            comm.Parameters.Add("@CAR_MODCOD", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@CAR_MODCOD"].Value = cbModelo.SelectedValue;


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
                        cbCliente.Text = reader["CLI_NOME"].ToString();
                        txPlaca.Text = reader["CAR_PLACA"].ToString();
                        txAnoFabric.Text = reader["CAR_ANOFABRIC"].ToString();
                        cbMarca.Text = reader["MARC_MARCA"].ToString();
                        cbModelo.Text = reader["MOD_MODELO"].ToString();

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
    }
}



