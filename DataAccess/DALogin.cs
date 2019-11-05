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
    public class DALogin
    {
        public DALogin()
        {

        }

        public DataTable CheckUser(string userName)//, out string errorMessage)
        {
            DataTable dataTable = new DataTable();

            try
            {
                SqlConnection connection = new SqlConnection(Properties.Resources.ConnectionString);
                connection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = connection;

                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "Select UserId, UserName, UserPassword " +
                    " from TERPUser " +
                    " where UserName = @UserName ";
                SqlParameter parameter = new SqlParameter();
                parameter.ParameterName = "@UserName";
                parameter.DbType = System.Data.DbType.String;
                parameter.Size = 256;
                parameter.Direction = System.Data.ParameterDirection.Input;
                parameter.Value = userName;

                command.Parameters.Add(parameter);

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                //DataSet dataSet = new DataSet();   // 1 DataSet poate contine mai multe Tabele
                

                adapter.Fill(dataTable);

                connection.Close();

                
            }
            catch(Exception ex)
            {
                //errorMessage = ex; // prindem eroarea
                throw ex;
            }

            return dataTable;

        }

        public void InsertLastLogin(DateTime dateTimeLastLogin, int idUser)
        {
            try
            {
                //Build query
                String query = string.Format("update TERPUser set LastLogin = \'{0}\' where UserId = {1}", dateTimeLastLogin, idUser);
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
    }
}
