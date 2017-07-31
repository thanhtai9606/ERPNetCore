using System;
using System.Collections.Generic;

namespace ERPNetCore.Models
{
    public partial class BusinessEntity
    {
        public BusinessEntity()
        {
            BusinessEntityAddress = new HashSet<BusinessEntityAddress>();
            BusinessEntityContact = new HashSet<BusinessEntityContact>();
            BusinessEntityPhone = new HashSet<BusinessEntityPhone>();
        }

        public int BusinessEntityId { get; set; }
        public Guid Rowguid { get; set; }
        public DateTime ModifiedDate { get; set; }

        public virtual ICollection<BusinessEntityAddress> BusinessEntityAddress { get; set; }
        public virtual ICollection<BusinessEntityContact> BusinessEntityContact { get; set; }
        public virtual ICollection<BusinessEntityPhone> BusinessEntityPhone { get; set; }
        public virtual Person Person { get; set; }
    }
}
