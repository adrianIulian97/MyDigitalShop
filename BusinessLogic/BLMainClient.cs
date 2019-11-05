using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusinessLogic
{
    public class BLMainClient
    {
        public BLMainClient()
        {

        }

        public DataTable FilterDataTable()
        {
            DAMainClient da = new DAMainClient();
            DataTable tableClient = da.FilterData();
            return tableClient;
        }
        public DataTable FilterDataWithParametersTable(ClientModel clientModelFilter)
        {
            DAMainClient da = new DAMainClient();
            DataTable tableClient = da.FilterDataWithParameters_v3(clientModelFilter);
            return tableClient;
        }
        public bool CheckInvoiceBL(int clientId)
        {
            DAMainClient da = new DAMainClient();
            DataTable dataTable = new DataTable();
            dataTable = da.CheckInvoiceDA(clientId);
            if (dataTable.Rows.Count > 0)
                return true;
            else
                return false;
        }
    }
}
