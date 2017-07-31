
using System;
using System.Collections.Generic;
using System.Linq;
using ERPNetCore.Models;

namespace ERPNetCore.Core.RepositoryPattern.HR
{
    public class PersonRepository : Repository<Person>
    {
        public PersonRepository(ERPDatabaseContext context) : base(context) { }
    }
}