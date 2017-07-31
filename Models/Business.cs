using System;
using System.Collections.Generic;

namespace ERPNetCore.Models
{
    public partial class Business
    {
        public Business()
        {
            Permission = new HashSet<Permission>();
        }

        public string BusinessId { get; set; }
        public string BusinessName { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual ICollection<Permission> Permission { get; set; }
    }
}
