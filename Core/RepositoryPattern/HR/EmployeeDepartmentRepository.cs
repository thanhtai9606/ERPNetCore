
using System;
using System.Collections.Generic;
using System.Linq;
using ERPNetCore.Models;

namespace ERPNetCore.Core.RepositoryPattern.HR
{
    public class EmployeeDepartmentRepository : Repository<EmployeeDepartmentHistory>
    {
        public EmployeeDepartmentRepository (ERPDatabaseContext context) : base(context) { }
    }
}