
using System;
using System.Collections.Generic;
using System.Linq;
using ERPNetCore.Models;

namespace ERPNetCore.Core.RepositoryPattern.GrantPermissionAdmin
{
    public class GrantPermissionAdmin
    {

        public BusinessRepository BusinessRepository { set; get; }
        public GrantPermissionRepository GrantPermissionRepository { set; get; }
        public PermissionRepository PermissionRepository { set; get; }
        public GrantPermissionAdmin(ERPDatabaseContext _context)
        {
            BusinessRepository = new BusinessRepository(_context);
            GrantPermissionRepository = new GrantPermissionRepository(_context);
            PermissionRepository = new PermissionRepository(_context);

        }
    }
}