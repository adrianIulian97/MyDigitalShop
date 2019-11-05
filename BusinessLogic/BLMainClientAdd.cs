using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusinessLogic
{
    public class BLMainClientAdd
    {
        public BLMainClientAdd()
        {

        }
        public void AddClientToDataBase(ClientModel client)
        {
            DAMainClientAdd da = new DAMainClientAdd();
            da.AddClient(client);
        }
        public bool CheckClienCodeIsUnicBL(string clientCode)
        {
            DAMainClientAdd add = new DAMainClientAdd();
            return add.CheckClientCodeIsUnicDA(clientCode);
        }

    }
}
