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
    public class BLMainCLientDelete
    {
        public BLMainCLientDelete() {  }
        public DataTable RefresDeleteClientToDataBasehData(int ClientId)
        {
            DAMainCLientDelete da = new DAMainCLientDelete();
            da.DeleteClient(ClientId);
            return da.RefreshData();
        }
    }
}
