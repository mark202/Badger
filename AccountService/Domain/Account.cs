using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Account
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public DateTime EstablishedDate { get; set; }
        public DateTime ClosedDate { get; set; }
        public long AccountStatusId { get; set; } // Closed, Open
        public Person Owner { get; set; }

    }
}
