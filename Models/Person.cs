using System;
using System.Collections.Generic;

namespace ERPNetCore.Models
{
    public partial class Person
    {
        public Person()
        {
            EmailAddress = new HashSet<EmailAddress>();
        }

        public int BusinessEntityId { get; set; }
        public string PersonType { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Guid Rowguid { get; set; }
        public DateTime ModifiedDate { get; set; }

        public virtual ICollection<EmailAddress> EmailAddress { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual Password Password { get; set; }
        public virtual BusinessEntity BusinessEntity { get; set; }
    }
}
