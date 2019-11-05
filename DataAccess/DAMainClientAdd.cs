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
    public class DAMainClientAdd
    {
        public DAMainClientAdd()
        {

        }

        public void AddClientToDataBase(ClientModel client)
        {

            try
            {
                SqlConnection connection = new SqlConnection(Properties.Resources.ConnectionString);
                connection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = connection;


                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "declare @ClientId int " +
"exec GetNextId 0, 'TClient', @ClientId out, 0, 1 " +
"insert into TClient(ClientId, ClientName, ClientSurname, ClientCode, PhoneNo, Email)  " +
"select @ClientId, @ClientName, @ClientSurame,  @ClientCode, @PhoneNo, @Email";

                /* Start Parameters */
                //ClientId
                SqlParameter parameterClientId = new SqlParameter();
                parameterClientId.ParameterName = "@ClientId";
                parameterClientId.DbType = System.Data.DbType.Int32;
                parameterClientId.Size = 4;
                parameterClientId.Direction = System.Data.ParameterDirection.Input;
                //parameterClientId.Value = 200;

                command.Parameters.Add(parameterClientId);
                //ClientName
                SqlParameter parameterName = new SqlParameter();
                parameterName.ParameterName = "@ClientName";
                parameterName.DbType = System.Data.DbType.String;
                parameterName.Size = 1024;
                parameterName.Direction = System.Data.ParameterDirection.Input;
                parameterName.Value = client.ClientName;

                command.Parameters.Add(parameterName);
                //ClientSurname
                SqlParameter parameterSurname = new SqlParameter();
                parameterSurname.ParameterName = "@ClientSurame";
                parameterSurname.DbType = System.Data.DbType.String;
                parameterSurname.Size = 1024;
                parameterSurname.Direction = System.Data.ParameterDirection.Input;
                parameterSurname.Value = client.ClientSurname;

                command.Parameters.Add(parameterSurname);
                //ClientCode
                SqlParameter parameterCode = new SqlParameter();
                parameterCode.ParameterName = "@ClientCode";
                parameterCode.DbType = System.Data.DbType.String;
                parameterCode.Size = 200;
                parameterCode.Direction = System.Data.ParameterDirection.Input;
                parameterCode.Value = client.ClientCode;

                command.Parameters.Add(parameterCode);
                //PhoneNo
                SqlParameter parameterPhoneNo = new SqlParameter();
                parameterPhoneNo.ParameterName = "@PhoneNo";
                parameterPhoneNo.DbType = System.Data.DbType.String;
                parameterPhoneNo.Size = 200;
                parameterPhoneNo.Direction = System.Data.ParameterDirection.Input;
                parameterPhoneNo.Value = client.PhoneNo;

                command.Parameters.Add(parameterPhoneNo);
                //Email
                SqlParameter parameterEmail = new SqlParameter();
                parameterEmail.ParameterName = "@Email";
                parameterEmail.DbType = System.Data.DbType.String;
                parameterEmail.Size = 512;
                parameterEmail.Direction = System.Data.ParameterDirection.Input;
                parameterEmail.Value = client.Email;

                command.Parameters.Add(parameterEmail);
                /* End */


                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                //DataSet dataSet = new DataSet();   // 1 DataSet poate contine mai multe Tabele


                //adapter.Fill(dataTable);

                connection.Close();


            }
            catch (Exception ex)
            {
                //errorMessage = ex; // prindem eroarea
                throw ex;
            }
            // TO DO
            //finally
            //{
            //    if (connection != null)
            //    {
            //        connection.Close();
            //    }
            //}

        }

        public void AddClient(ClientModel client)
        {
            try
            {
                //Build query
                String query = string.Format("declare @ClientId int " +
                    "exec GetNextId 0, 'TClient', @ClientId out, 0, 1 " +
                    "INSERT INTO {0} ({1}) VALUES ({2})",
                    "TClient",
                    "ClientId, ClientName, ClientSurname, ClientCode, PhoneNo, Email",
                    string.Concat("@ClientId, \'", client.ClientName, "\', \'", client.ClientSurname, "\', \'", client.ClientCode, "\', \'", client.PhoneNo, "\', \'", client.Email, "\'"));
                using (SqlConnection connection = new SqlConnection(Properties.Resources.ConnectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch (Exception g)
            {
                MessageBox.Show("Error during insert: " + g.Message);
            }
        }

        public bool CheckClientCodeIsUnicDA(string clientCode)
        {
            DataTable dataTable = new DataTable();
            try
            {
                SqlConnection connection = new SqlConnection(Properties.Resources.ConnectionString);
                connection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = connection;

                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "Select *" +
                " from TClient" +
                " where ClientCode = @ClientCode";
                SqlParameter parameter = new SqlParameter();
                parameter.ParameterName = "@ClientCode";
                parameter.DbType = System.Data.DbType.String;
                parameter.Size = 200;
                parameter.Direction = System.Data.ParameterDirection.Input;
                parameter.Value = clientCode;

                command.Parameters.Add(parameter);

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                //DataSet dataSet = new DataSet();   // 1 DataSet poate contine mai multe Tabele


                adapter.Fill(dataTable);

                connection.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (dataTable.Rows.Count == 0)
                return true;
            else
                return false;
        }
    }
}
