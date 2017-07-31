

using ERPNetCore.Models;

namespace ERPNetCore.Core.RepositoryPattern.BusinessEntities.Phone
{
    public class PhoneNumTypeRepository : Repository<PhoneNumberType>
    {
        public PhoneNumTypeRepository(ERPDatabaseContext  context) : base(context) { }
    }
}