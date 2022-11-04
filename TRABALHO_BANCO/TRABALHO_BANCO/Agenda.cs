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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TRABALHO_BANCO
{
    public partial class Agenda : Form
    {
        public Agenda()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void LimparForm()
        {

            txCod.Clear();
            rtbDesc.Clear();
        }

        private void Agenda_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tRABALHO_BANCODataSet.DataTable2' table. You can move, or remove it, as needed.
            this.dataTable2TableAdapter.FillDataGridAgenda(this.tRABALHO_BANCODataSet.DataTable2);
            // TODO: This line of code loads data into the 'tRABALHO_BANCODataSet.CARRO' table. You can move, or remove it, as needed.
            this.cARROTableAdapter.Fill(this.tRABALHO_BANCODataSet.CARRO);
            // TODO: This line of code loads data into the 'tRABALHO_BANCODataSet.DataTable2' table. You can move, or remove it, as needed.

            //cbPlaca.Items.Insert(0, string.Empty);           


            //cbPlaca.SelectedIndex = -1;

        }

        private void label3_Click(object sender, EventArgs e)
        {

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
                 "INSERT INTO AGENDA (AGENDA_DESC, AGENDA_DATA, AGENDA_CARPLACA) " +
                 "VALUES (@AGENDA_DESC, @AGENDA_DATA, @AGENDA_CARPLACA)", conn);


            comm.Parameters.Add("@AGENDA_DESC", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@AGENDA_DESC"].Value = rtbDesc.Text;

            comm.Parameters.Add("@AGENDA_DATA", System.Data.SqlDbType.Date);
            comm.Parameters["@AGENDA_DATA"].Value = dtpData.Text;

            comm.Parameters.Add("@AGENDA_CARPLACA", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@AGENDA_CARPLACA"].Value = cbPlaca.Text;

            this.dataTable2TableAdapter.FillDataGridAgenda(this.tRABALHO_BANCODataSet.DataTable2);
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
                     MessageBox.Show("Agendamento cadastrado com sucesso!",
                             "INSERT",
                             MessageBoxButtons.OK,
                             MessageBoxIcon.Information);

                    // Atualizar a lista de cidades


                }
             }

             LimparForm();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
                "SELECT AGENDA.AGENDA_COD, AGENDA.AGENDA_DESC, AGENDA.AGENDA_DATA, CARRO.CAR_PLACA " +
                "FROM AGENDA " +
                "INNER JOIN CARRO ON AGENDA.AGENDA_CARPLACA = CARRO.CAR_PLACA " +
                "WHERE AGENDA_COD = @AGENDA_COD ", conn);

            // Declara e atribui os valores para as variáveis


            comm.Parameters.Add("@AGENDA_COD", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@AGENDA_COD"].Value = txCod.Text;

            comm.Parameters.Add("@AGENDA_DESC", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@AGENDA_DESC"].Value = rtbDesc.Text;

            comm.Parameters.Add("@AGENDA_DATA", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@AGENDA_DATA"].Value = dtpData.Text;

            comm.Parameters.Add("@AGENDA_CARPLACA", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@AGENDA_CARPLACA"].Value = cbPlaca.SelectedValue;

            

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
                        txCod.Text = reader["AGENDA_COD"].ToString();
                        cbPlaca.Text = reader["CAR_PLACA"].ToString();
                        dtpData.Text = reader["AGENDA_DATA"].ToString();
                        rtbDesc.Text = reader["AGENDA_DESC"].ToString();

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
            this.dataTable2TableAdapter.FillDataGridAgenda(this.tRABALHO_BANCODataSet.DataTable2);
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
                "DELETE FROM AGENDA " +
                "WHERE AGENDA_COD = @AGENDA_COD", conn);

            // Declara e atribui os valores para as variáveis
            comm.Parameters.Add("@AGENDA_COD", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@AGENDA_COD"].Value = txCod.Text;


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
                    MessageBox.Show("Agendamento deletado com sucesso!",
                            "DELETE",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                    // Atualizar a lista de agendamentos 
                    this.dataTable2TableAdapter.FillDataGridAgenda(this.tRABALHO_BANCODataSet.DataTable2);

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
                "UPDATE AGENDA SET AGENDA.AGENDA_CARPLACA=@CAR_PLACA, AGENDA.AGENDA_DESC=@AGENDA_DESC, AGENDA.AGENDA_DATA=@AGENDA_DATA " +
                "WHERE AGENDA_COD = @AGENDA_COD ", conn);


            // Declara e atribui os valores para as variáveis
            comm.Parameters.Add("@AGENDA_COD", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@AGENDA_COD"].Value = txCod.Text;

            comm.Parameters.Add("@AGENDA_DESC", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@AGENDA_DESC"].Value = rtbDesc.Text;

            comm.Parameters.Add("@AGENDA_DATA", System.Data.SqlDbType.Date);
            comm.Parameters["@AGENDA_DATA"].Value = dtpData.Text;

            comm.Parameters.Add("@CAR_PLACA", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@CAR_PLACA"].Value = cbPlaca.SelectedValue;

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
                    MessageBox.Show("Agendamento alterado com sucesso!",
                            "UPDATE",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                    // Atualizar a lista de agendamentos 
                    this.dataTable2TableAdapter.FillDataGridAgenda(this.tRABALHO_BANCODataSet.DataTable2);
                }
            }

            LimparForm();
        }

        private void cbPlaca_SelectedIndexChanged(object sender, EventArgs e)
        {          
        }
    }
}
