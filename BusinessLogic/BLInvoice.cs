using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class BLInvoice
    {
        public BLInvoice()
        {

        }
        public DataTable FilterDataTable()
        {
            DAInvoice da = new DAInvoice();
            DataTable tableClient = da.FilterData();
            return tableClient;
        }
        public DataTable ComboBoxClientBL()
        {
            DAInvoice da = new DAInvoice();
            DataTable tableClient = da.ComboBoxClientDA();
            return tableClient;
        }
        public DataTable FilterDataWithParametersTable(int clientId, string invoiceNumber, DateTime dateFrom, DateTime dateTo)
        {
            DAInvoice da = new DAInvoice();
            DataTable tableClient = da.FilterDataWithParametersTable(clientId, invoiceNumber, dateFrom, dateTo);
            return tableClient;
        }
        public DataTable ComboBoxClientAddressBL(int clientId)
        {
            DAInvoice da = new DAInvoice();
            DataTable tableClient = da.ComboBoxClientAddressDA(clientId);
            return tableClient;
        }
        public DataTable AddInvoiceToDataBase(InvoiceModel invoiceModel)
        {
            DAInvoice da = new DAInvoice();
            DataTable tableClient = da.AddInvoiceToDataBase(invoiceModel);
            return tableClient;
        }
    }
}
