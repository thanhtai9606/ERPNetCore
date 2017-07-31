

using System;
using System.Collections.Generic;
using System.Linq;
using ERPNetCore.Core.RepositoryPattern.BusinessEntities.AddressRepo;
using ERPNetCore.Models;

namespace ERPNetCore.Core.RepositoryPattern.BusinessEntities
{
    public class BusinessEntityRepository
    {
        public EntityRepository EntityRepository { set; get; }
        public AddressRepository AddressRepository { set; get; }
        public AddressTypeRepository AddressTypeRepository { set; get; }
        public BusinessEntityAddressRepository BusinessEntityAddressRepository { set; get; }
        public DistrictRepository DistrictRepository { set; get; }
        public ProvinceRepository ProvinceRepository { set; get; }
        public WardRepository WardRepository { set; get; }

        public BusinessEntityRepository(ERPDatabaseContext context)
        {
            EntityRepository = new EntityRepository(context);
            AddressRepository = new AddressRepository(context);
            AddressTypeRepository = new AddressTypeRepository(context);
            BusinessEntityAddressRepository = new BusinessEntityAddressRepository(context);
            DistrictRepository = new DistrictRepository(context);
            ProvinceRepository = new ProvinceRepository(context);
            WardRepository = new WardRepository(context);
        }
    }
}