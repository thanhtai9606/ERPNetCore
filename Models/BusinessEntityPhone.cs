using System;
using System.Collections.Generic;

namespace ERPNetCore.Models
{
    public partial class BusinessEntityPhone
    {
        public int BusinessEntityId { get; set; }
        public int PhoneId { get; set; }
        public int PhoneNumberTypeId { get; set; }
        public Guid Rowguid { get; set; }
        public DateTime ModifiedDate { get; set; }

        public virtual BusinessEntity BusinessEntity { get; set; }
        public virtual EntityPhone Phone { get; set; }
        public virtual PhoneNumberType PhoneNumberType { get; set; }
    }
}
