using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Company
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public Address RegisteredAddress { get; set; }
        public Person PrimaryContact { get; set; }
        public virtual ICollection<Account> Accounts { get; set; }
    }
}
