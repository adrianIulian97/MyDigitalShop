using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class ClientAddressModel
    {
        public int ClientAddresId { get; set; }
        public int ClientId { get; set; }
        public int CountyId { get; set; }
        public int CityId { get; set; }
        public string StreetName { get; set; }
        public string StreetNo { get; set; }

        public ClientAddressModel()
        {

        }
    }
}
