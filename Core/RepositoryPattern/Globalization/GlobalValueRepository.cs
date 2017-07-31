
using System;
using System.Collections.Generic;
using System.Linq;
using ERPNetCore.Models;

namespace ERPNetCore.Core.RepositoryPattern.Globalization
{
    public class GlobalValueRepository : Repository<GlobalValue>
    {
        public GlobalValueRepository(ERPDatabaseContext context) : base(context) { }
    }
}