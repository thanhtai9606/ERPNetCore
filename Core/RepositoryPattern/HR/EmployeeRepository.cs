using System;
using System.Collections.Generic;
using System.Linq;
using ERPNetCore.Models;

namespace ERPNetCore.Core.RepositoryPattern.HR
{
    public class EmployeeRepository: Repository<Employee>
    {
        public EmployeeRepository(ERPDatabaseContext context) : base(context) { }
    }
}