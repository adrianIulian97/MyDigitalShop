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
    public class BLMainClientAddress
    {
        public BLMainClientAddress()
        {

        }
        public DataTable ComboBoxCountyBL()
        {
            DAMainClientAddress da = new DAMainClientAddress();
            return da.ComboBoxCountyDA();
        }
        public DataTable ComboBoxCityBL(int indexCountyId)
        {
            DAMainClientAddress da = new DAMainClientAddress();
            return da.ComboBoxCityDA(indexCountyId);
        }
        public void ClientAddressSaveBL(ClientAddressModel clientAddress)
        {
            DAMainClientAddress da = new DAMainClientAddress();
            da.ClientAddressSaveDA(clientAddress);
        }
        public void ClientAddressSaveChangesBL(ClientAddressModel clientAddress)
        {
            DAMainClientAddress da = new DAMainClientAddress();
            da.ClientAddressSaveChangesDA(clientAddress);
        }
        public int ClientGetCliendIdBL(ClientModel client)
        {
            DAMainClientAddress da = new DAMainClientAddress();
            DataTable dataTable = new DataTable();
            dataTable = da.ClientGetCliendIdDA(client);
            return Convert.ToInt32(dataTable.Rows[0]["ClientId"]);
        }
    }
}
