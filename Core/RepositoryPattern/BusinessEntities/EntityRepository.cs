

using ERPNetCore.Models;

namespace ERPNetCore.Core.RepositoryPattern.BusinessEntities
{
    public class EntityRepository:Repository<BusinessEntity>
    {
        public EntityRepository (ERPDatabaseContext context) : base(context) { }
    }
}