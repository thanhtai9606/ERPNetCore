
using ERPNetCore.Models;

namespace ERPNetCore.Core.RepositoryPattern
{
    public class ItemRepository : Repository<Item>
    {
        public ItemRepository(ERPDatabaseContext context) : base(context){}
    }
}