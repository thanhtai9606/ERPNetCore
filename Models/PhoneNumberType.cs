using System;
using System.Collections.Generic;

namespace ERPNetCore.Models
{
    public partial class PhoneNumberType
    {
        public PhoneNumberType()
        {
            BusinessEntityPhone = new HashSet<BusinessEntityPhone>();
        }

        public int PhoneNumberTypeId { get; set; }
        public string Name { get; set; }
        public DateTime ModifiedDate { get; set; }

        public virtual ICollection<BusinessEntityPhone> BusinessEntityPhone { get; set; }
    }
}
