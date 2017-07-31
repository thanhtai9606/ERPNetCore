using System;
using System.Collections.Generic;
using System.Linq;
using ERPNetCore.Models;

namespace ERPNetCore.Core.RepositoryPattern.BusinessEntities.AddressRepo
{
    public class AddressRepository : Repository<Address>
    {
        public AddressRepository (ERPDatabaseContext context): base(context) { }
    }
}