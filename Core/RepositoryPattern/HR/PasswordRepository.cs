using System;
using System.Collections.Generic;
using System.Linq;
using ERPNetCore.Models;

namespace ERPNetCore.Core.RepositoryPattern.HR
{
    public class PasswordRepository : Repository<Password>
    {
        public PasswordRepository(ERPDatabaseContext context) : base(context) { }
    }
}