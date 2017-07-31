using System;
using System.Collections.Generic;

namespace ERPNetCore.Models
{
    public partial class EntityPhone
    {
        public EntityPhone()
        {
            BusinessEntityPhone = new HashSet<BusinessEntityPhone>();
        }

        public int PhoneId { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime ModifiedDate { get; set; }

        public virtual ICollection<BusinessEntityPhone> BusinessEntityPhone { get; set; }
    }
}
