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
    public class DAMainCLientEdit
    {
        public DAMainCLientEdit()
        {

        }

        public ClientModel ClientEditSource(int indexModifyClient)
        {
            DataTable dataTable = new DataTable();
            ClientModel client = new ClientModel();

            try
            {
                SqlConnection connection = new SqlConnection(Properties.Resources.ConnectionString);
                connection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = connection;

                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "Select ClientId, ClientName, ClientSurname, ClientCode, PhoneNo, Email " +
                    " from TClient " +
                    " where ClientId = @ClientId ";
                SqlParameter parameter = new SqlParameter();
                parameter.ParameterName = "@ClientId";
                parameter.DbType = System.Data.DbType.Int32;
                parameter.Size = 4;
                parameter.Direction = System.Data.ParameterDirection.Input;
                parameter.Value = indexModifyClient;

                command.Parameters.Add(parameter);

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;

                adapter.Fill(dataTable);

                connection.Close();


            }
            catch (Exception ex)
            {
                throw ex;
            }
            client.ClientId = Convert.ToInt32(dataTable.Rows[0]["ClientId"]);
            client.ClientName = dataTable.Rows[0]["ClientName"].ToString();
            client.ClientSurname = dataTable.Rows[0]["ClientSurname"].ToString();
            client.ClientCode = dataTable.Rows[0]["ClientCode"].ToString();
            client.PhoneNo = dataTable.Rows[0]["PhoneNo"].ToString();
            client.Email = dataTable.Rows[0]["Email"].ToString();
            return client;
        }

        public void ClientEditDestination(ClientModel client)
        {
            try
            {
                //Build query
                String query = string.Format("update TClient set " +
                    "ClientName = \'{0}\', " +
                    "ClientSurname = \'{1}\', " +
                    "ClientCode = \'{2}\', " +
                    "PhoneNo = \'{3}\', " +
                    "Email = \'{4}\' " +
                    "where ClientId = \'{5}\'", client.ClientName, client.ClientSurname, client.ClientCode, 
                                            client.PhoneNo, client.Email, client.ClientId);
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

        public DataTable RefreshData()
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

        public DataTable FilterAddressClientDataTableDA(int clientId)//, out string errorMessage)
        {
            DataTable dataTable = new DataTable();

            try
            {
                SqlConnection connection = new SqlConnection(Properties.Resources.ConnectionString);
                connection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = connection;

                command.CommandType = System.Data.CommandType.Text;
                String query = string.Format("select c.CountyName, b.CityName, a.CityId, a.CountyId, a.ClientId, a.ClientAddressId, a.StreetName, a.StreetNo" +
                    " from TClientAddress a" +
                    " join TCity b on a.CityId = b.CityId" +
                    " join TCounty c on a.CountyId = c.CountyId" +
                    " join TClient d on a.ClientId = d.ClientId" +
                    " where a.ClientId = {0}",
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
