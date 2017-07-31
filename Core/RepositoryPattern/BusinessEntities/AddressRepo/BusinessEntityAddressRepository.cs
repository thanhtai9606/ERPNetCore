using System;
using System.Collections.Generic;
using System.Linq;
using ERPNetCore.Models;

namespace ERPNetCore.Core.RepositoryPattern.BusinessEntities.AddressRepo
{
    public class BusinessEntityAddressRepository: Repository<BusinessEntityAddress>
    {
        public BusinessEntityAddressRepository(ERPDatabaseContext context) : base (context){ }
    }
}