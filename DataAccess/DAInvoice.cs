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
    public class DAInvoice
    {
        public DAInvoice()
        {

        }
        public DataTable FilterData()
        {
            DataTable dataTable = new DataTable();

            try
            {
                SqlConnection connection = new SqlConnection(Properties.Resources.ConnectionString);
                connection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = connection;

                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "Select t.InvoiceId as InvoiceId, t.InvoiceNumber as InvoiceNumber" +
                    ", t.InvoiceDate as InvoiceDate,t.ClientId as ClientId, t.ClientAddressId as ClientAddressId," +
                    " t.UserId as UserId, t.Observations as Observations, c.ClientName as ClientName, " +
                    "StreetName, StreetNo, ci.CityName as CityName, co.CountyName as CountyName" +
                    " from TInvoice t" +
                    " join TClient c on c.ClientId = t.ClientId" +
                    " join TClientAddress ca on ca.ClientAddressId = t.ClientAddressId" +
                    " join TCity ci on ci.CityId = ca.CityId" +
                    " join TCounty co on co.CountyId = ca.CountyId";
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
        public DataTable ComboBoxClientDA()
        {
            DataTable dataTable = new DataTable();

            try
            {
                SqlConnection connection = new SqlConnection(Properties.Resources.ConnectionString);
                connection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = connection;

                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "Select * from TClient";
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
        public DataTable FilterDataWithParametersTable(int clientId, string invoiceNumber, DateTime dateFrom, DateTime dateTo)
        {
            DataTable dataTable = new DataTable();

            try
            {
                SqlConnection connection = new SqlConnection(Properties.Resources.ConnectionString);
                connection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = connection;

                command.CommandType = System.Data.CommandType.Text;
                String query;
                if (clientId != 0)
                {
                    query = string.Format("exec procedure_FilterInvoice_AdrianR {0},{1},\'{2}\',\'{3}\'",
                        clientId, invoiceNumber, dateFrom, dateTo);
                }
                else
                {
                    query = string.Format("exec procedure_FilterInvoice_AdrianR null,{0},\'{1}\',\'{2}\'",
                         invoiceNumber, dateFrom, dateTo);
                }
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
        public DataTable ComboBoxClientAddressDA(int clientId)
        {
            DataTable dataTable = new DataTable();

            try
            {
                SqlConnection connection = new SqlConnection(Properties.Resources.ConnectionString);
                connection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = connection;

                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = String.Format("Select * from TClientAddress where ClientId = {0}", clientId);
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

        public DataTable AddInvoiceToDataBase(InvoiceModel invoice)
        {
            DataTable dataTable = new DataTable();

            try
            {
                SqlConnection connection = new SqlConnection(Properties.Resources.ConnectionString);
                connection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                int a = 5;

                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = String.Format("declare @InvoiceId int" +
                    " exec GetNextId 0, 'TInvoice', @InvoiceId out, 0, 1" +
                    " insert into TInvoice(InvoiceId, InvoiceNumber, InvoiceDate, ClientId, ClientAddressId, UserId, Observations)" +
                    " select @InvoiceId, \'{0}\', {1}, {2}, {3}, {4}, {5}", 
                    invoice.InvoiceNumber, invoice.InvoiceDate, invoice.ClientId, invoice.ClientAddressId, a, invoice.Observations);
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
