using System;
using System.Collections.Generic;
using System.Linq;
using ERPNetCore.Models;

namespace ERPNetCore.Core.RepositoryPattern.BusinessEntities.AddressRepo
{
    public class AddressTypeRepository : Repository<AddressType>
    {
        public AddressTypeRepository (ERPDatabaseContext context): base(context) { }
    }
}