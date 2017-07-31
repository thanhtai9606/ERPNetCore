
using System;
using System.Collections.Generic;
using System.Linq;
using ERPNetCore.Models;

namespace ERPNetCore.Core.RepositoryPattern.Globalization
{
    public class CultureRepository
    {
        public GlobalCountryRepository GlobalCountryRepository { set; get; }
        public GlobalValueRepository GlobalValueRepository { set; get; }
        public CultureRepository(ERPDatabaseContext context)
        {
            GlobalValueRepository = new GlobalValueRepository(context);
            GlobalCountryRepository = new GlobalCountryRepository(context);
        }
        
    }
}