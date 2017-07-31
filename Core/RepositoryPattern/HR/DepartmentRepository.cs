using System;
using System.Collections.Generic;
using System.Linq;
using ERPNetCore.Models;

namespace ERPNetCore.Core.RepositoryPattern.HR
{
    public class DepartmentRepository : Repository<Department>
    {
        public DepartmentRepository (ERPDatabaseContext context) : base(context) { }
    }
}