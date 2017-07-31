
using System;
using System.Collections.Generic;
using System.Linq;
using ERPNetCore.Models;

namespace ERPNetCore.Core.RepositoryPattern.BusinessEntities.Phone
{
    public class EntityPhoneRepository : Repository<EntityPhone>
    {
        public EntityPhoneRepository(ERPDatabaseContext context) : base(context) { }
    }
}