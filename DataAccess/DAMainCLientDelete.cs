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
    public class DAMainCLientDelete
    {
        public DAMainCLientDelete()
        {

        }

        public void DeleteClient(int ClientId)
        {
            try
            {
                //Build query
                String query = string.Format("delete from {0} where ClientId = {1} ",
                    "TClient",
                    string.Concat(ClientId.ToString()));
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
            catch (Exception ex)
            {
                throw ex;
            }

            return dataTable;

        }
    }
}
