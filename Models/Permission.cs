using System;
using System.Collections.Generic;

namespace ERPNetCore.Models
{
    public partial class Permission
    {
        public Permission()
        {
            GrantPermission = new HashSet<GrantPermission>();
        }

        public int PermissionId { get; set; }
        public string PermissionName { get; set; }
        public string BusinessId { get; set; }
        public string Description { get; set; }
        public DateTime? DateModified { get; set; }

        public virtual ICollection<GrantPermission> GrantPermission { get; set; }
        public virtual Business Business { get; set; }
    }
}
