

using ERPNetCore.Models;

namespace ERPNetCore.Core.RepositoryPattern.BusinessEntities.Phone
{
    public class BusinessEntityPhoneRepository:Repository<BusinessEntityPhone>
    {
        public BusinessEntityPhoneRepository(ERPDatabaseContext context) : base (context){ }
    }
}