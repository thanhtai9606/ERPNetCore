using System;
using System.Collections.Generic;

namespace ERPNetCore.Models
{
    public partial class GrantPermission
    {
        public int PermissionId { get; set; }
        public int BusinessEntityId { get; set; }
        public DateTime? DateModified { get; set; }

        public virtual Employee BusinessEntity { get; set; }
        public virtual Permission Permission { get; set; }
    }
}
