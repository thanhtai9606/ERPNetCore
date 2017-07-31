
using System;
using System.Collections.Generic;
using System.Linq;
using ERPNetCore.Models;

namespace ERPNetCore.Core.RepositoryPattern.Globalization
{
    public class GlobalCountryRepository : Repository<GlobalCountry>
    {
        public GlobalCountryRepository(ERPDatabaseContext context) : base(context) { }
    }
}