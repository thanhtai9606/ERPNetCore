
using System;
using System.Collections.Generic;
using System.Linq;
using ERPNetCore.Models;

namespace ERPNetCore.Core.RepositoryPattern.GrantPermissionAdmin
{
    public class GrantPermissionRepository : Repository<GrantPermission>
    {
        public GrantPermissionRepository(ERPDatabaseContext context) : base(context) { }
    }
}