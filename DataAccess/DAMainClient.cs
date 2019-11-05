using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataAccess
{
    public class DAMainClient
    {
        public DAMainClient()
        {

        }

        public DataTable FilterData()//, out string errorMessage)
        {
            DataTable dataTable = new DataTable();

            try
            {
                SqlConnection connection = new SqlConnection(Properties.Resources.ConnectionString);
                connection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = connection;

                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "Select ClientId, ClientName, ClientSurname, ClientCode, PhoneNo, Email " +
                    " from TClient ";
                    //" where UserName = @UserName ";
                //SqlParameter parameter = new SqlParameter();
                //parameter.ParameterName = "@UserName";
                //parameter.DbType = System.Data.DbType.String;
                //parameter.Size = 256;
                //parameter.Direction = System.Data.ParameterDirection.Input;
                //parameter.Value = userName;

                //command.Parameters.Add(parameter);

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                //DataSet dataSet = new DataSet();   // 1 DataSet poate contine mai multe Tabele


                adapter.Fill(dataTable);

                connection.Close();


            }
            catch (Exception ex)
            {
                //errorMessage = ex; // prindem eroarea
                throw ex;
            }

            return dataTable;

        }
        public DataTable FilterDataWithParameters(ClientModel client)
        {
            DataTable dataTable = new DataTable();
            try
            {
                //Build query
                //String query = string.Format("exec procedure_Filter_AdrianR {0}, {1}, {2}, {3}, {4}",
                //                            client.ClientName, client.ClientSurname, client.ClientCode, 
                //                            client.PhoneNo, client.Email);
                //using (SqlConnection connection = new SqlConnection(Properties.Resources.ConnectionString))
                //using (SqlCommand command = new SqlCommand(query, connection))
                //{
                //    connection.Open();
                //    command.ExecuteNonQuery();
                //    connection.Close();
                //}
                //
                using (SqlConnection con = new SqlConnection(Properties.Resources.ConnectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("procedure_Filter_AdrianR", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@ClientName", client.ClientName);
                        cmd.Parameters.AddWithValue("@ClientSurname", client.ClientSurname);
                        cmd.Parameters.AddWithValue("@ClientCode", client.ClientCode);
                        cmd.Parameters.AddWithValue("@PhoneNo", client.PhoneNo);
                        cmd.Parameters.AddWithValue("@Email", client.Email);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                }
            }
            catch (Exception g)
            {
                MessageBox.Show("Error during insert: " + g.Message);
            }
            return dataTable;
        }

        public DataTable FilterDataWithParameters_v2(ClientModel client)
        {
            DataTable dataTable = new DataTable();

            try
            {
                SqlConnection connection = new SqlConnection(Properties.Resources.ConnectionString);
                connection.Open();

                SqlCommand command = new SqlCommand("procedure_Filter_AdrianR");
                command.Connection = connection;

                command.CommandType = System.Data.CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@ClientName", client.ClientName);
                command.Parameters.AddWithValue("@ClientSurname", client.ClientSurname);
                command.Parameters.AddWithValue("@ClientCode", client.ClientCode);
                command.Parameters.AddWithValue("@PhoneNo", client.PhoneNo);
                command.Parameters.AddWithValue("@Email", client.Email);


                /*SqlParameter parameter1 = new SqlParameter();
                SqlParameter parameter2 = new SqlParameter();
                SqlParameter parameter3 = new SqlParameter();
                SqlParameter parameter4 = new SqlParameter();
                SqlParameter parameter5 = new SqlParameter();
                //ClientName
                parameter1.ParameterName = "@ClientName";
                parameter1.DbType = System.Data.DbType.String;
                parameter1.Size = 256;
                parameter1.Direction = System.Data.ParameterDirection.Input;
                parameter1.Value = client.ClientName;
                //ClientSurname
                parameter2.ParameterName = "@ClientSurname";
                parameter2.DbType = System.Data.DbType.String;
                parameter2.Size = 256;
                parameter2.Direction = System.Data.ParameterDirection.Input;
                parameter2.Value = client.ClientSurname;
                //ClientCode
                parameter3.ParameterName = "@ClientCode";
                parameter3.DbType = System.Data.DbType.String;
                parameter3.Size = 256;
                parameter3.Direction = System.Data.ParameterDirection.Input;
                parameter3.Value = client.ClientCode;
                //PhoneNo
                parameter4.ParameterName = "@PhoneNo";
                parameter4.DbType = System.Data.DbType.String;
                parameter4.Size = 256;
                parameter4.Direction = System.Data.ParameterDirection.Input;
                parameter4.Value = client.PhoneNo;
                //Email
                parameter5.ParameterName = "@Email";
                parameter5.DbType = System.Data.DbType.String;
                parameter5.Size = 256;
                parameter5.Direction = System.Data.ParameterDirection.Input;
                parameter5.Value = client.Email;

                command.Parameters.Add(parameter1);
                command.Parameters.Add(parameter2);
                command.Parameters.Add(parameter3);
                command.Parameters.Add(parameter4);
                command.Parameters.Add(parameter5);*/


                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                adapter.Fill(dataTable);
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during insert: " + ex.Message);
            }

            return dataTable;

        }
        public DataTable FilterDataWithParameters_v3(ClientModel client)
        {
            DataTable dataTable = new DataTable();

            try
            {
                SqlConnection connection = new SqlConnection(Properties.Resources.ConnectionString);
                connection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = connection;

                command.CommandType = System.Data.CommandType.Text;
                String query = string.Format("exec procedure_Filter_AdrianR {0}, {1}, {2}, {3}, {4}",
                    client.ClientName, client.ClientSurname, client.ClientCode, client.PhoneNo, client.Email);
                //command.CommandText = "exec procedure_Filter_AdrianR {0}, {1}, {2}, {3}, {4}";
                command.CommandText = query;

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;

                adapter.Fill(dataTable);

                connection.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return dataTable;
        }
        public DataTable CheckInvoiceDA(int clientId)
        {
            DataTable dataTable = new DataTable();

            try
            {
                SqlConnection connection = new SqlConnection(Properties.Resources.ConnectionString);
                connection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = connection;

                command.CommandType = System.Data.CommandType.Text;
                String query = string.Format("select * from TInvoice " +
                    "where ClientId = {0}",
                    clientId);
                command.CommandText = query;

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;

                adapter.Fill(dataTable);

                connection.Close();
            }
            catch (Exception g)
            {
                MessageBox.Show("Error during insert: " + g.Message);
            }
            return dataTable;
        }
    }
}
