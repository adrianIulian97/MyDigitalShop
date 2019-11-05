using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class InvoiceModel
    {
        public int InvoiceId { get; set; }
        public string InvoiceNumber { get; set; }
        public DateTime InvoiceDate { get; set; }
        public int ClientId { get; set; }
        public int ClientAddressId { get; set; }
        public int UserId { get; set; }
        public string Observations { get; set; }

        public InvoiceModel()
        {

        }
    }
}
