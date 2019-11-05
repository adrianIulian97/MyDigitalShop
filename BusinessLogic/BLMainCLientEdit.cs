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
    public class BLMainCLientEdit
    {

        DAMainCLientEdit da = new DAMainCLientEdit();
        public BLMainCLientEdit()
        {

        }

        public ClientModel ClientEditSource(int indexModifyClient)
        {
            ClientModel client = da.ClientEditSource(indexModifyClient);
            return client;
        }

        public void ClientEditDestination(ClientModel clientDestination)
        {
            da.ClientEditDestination(clientDestination);
        }
        public DataTable RefreshDataClientEdit()
        {
            DAMainCLientEdit da = new DAMainCLientEdit();
            return da.RefreshData();
        }
        public DataTable FilterAddressClientDataTableBL(int clientId)
        {
            DAMainCLientEdit da = new DAMainCLientEdit();
            DataTable tableClient = da.FilterAddressClientDataTableDA(clientId);
            return tableClient;
        }
    }
}
