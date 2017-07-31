
using ERPNetCore.Models;

namespace ERPNetCore.Core.RepositoryPattern.Multimedia
{
    public class CatalogRepository : Repository<Catalog>
    {
        public CatalogRepository(ERPDatabaseContext context) : base(context){}
    }
}