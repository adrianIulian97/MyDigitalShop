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
    public class DAMainClientAddress
    {
        public DAMainClientAddress()
        {

        }
        public DataTable ComboBoxCountyDA()
        {
            DataTable dataTable = new DataTable();

            try
            {
                SqlConnection connection = new SqlConnection(Properties.Resources.ConnectionString);
                connection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = connection;

                command.CommandType = System.Data.CommandType.Text;
                String query = string.Format("select * from TCounty");
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
        public DataTable ComboBoxCityDA(int indexCountyId)
        {
            DataTable dataTable = new DataTable();

            try
            {
                SqlConnection connection = new SqlConnection(Properties.Resources.ConnectionString);
                connection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = connection;

                command.CommandType = System.Data.CommandType.Text;
                String query = string.Format("select * from TCity where CountyId = {0}", indexCountyId);
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
        public void ClientAddressSaveDA(ClientAddressModel clientAddress)
        {
            try
            {
                //Build query
                String query = string.Format("declare @ClientAddressId int" +
                    " exec GetNextId 0, 'TClientAddress', @ClientAddressId out, 0, 1" +
                    " insert into TClientAddress(ClientAddressId, ClientId, CityId, CountyId, StreetName, StreetNo)  " +
                    " select @ClientAddressId, {0}, {1}, {2}, \'{3}\', \'{4}\'",
                    clientAddress.ClientId, clientAddress.CityId, clientAddress.CountyId, clientAddress.StreetName, clientAddress.StreetNo);
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
        public void ClientAddressSaveChangesDA(ClientAddressModel clientAddress)
        {
            try
            {
                //Build query
                String query = string.Format("update TClientAddress " +
                    "set StreetName = \'{0}\', StreetNo = \'{1}\', CountyId = {2}, CityId = {3} where ClientAddressId = {4}",
                    clientAddress.StreetName, clientAddress.StreetNo, clientAddress.CountyId, clientAddress.CityId, clientAddress.ClientAddresId);
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
        public DataTable ClientGetCliendIdDA(ClientModel client)
        {
            DataTable dataTable = new DataTable();

            try
            {
                SqlConnection connection = new SqlConnection(Properties.Resources.ConnectionString);
                connection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = connection;

                command.CommandType = System.Data.CommandType.Text;
                String query = string.Format("select * from TClient " +
                    "where ClientName = \'{0}\' and ClientSurname = \'{1}\' and ClientCode = \'{2}\' and PhoneNo = \'{3}\' and Email = \'{4}\'", 
                    client.ClientName, client.ClientSurname, client.ClientCode, client.PhoneNo, client.Email);
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
            //client.ClientId = Convert.ToInt32(dataTable.Rows[0]["ClientId"]);
            return dataTable;
        }
    }
}
