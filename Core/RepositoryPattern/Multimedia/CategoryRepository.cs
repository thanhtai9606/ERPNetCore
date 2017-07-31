
using ERPNetCore.Models;

namespace ERPNetCore.Core.RepositoryPattern
{
    public class CategoryRepository : Repository<Category>
    {
        public CategoryRepository(ERPDatabaseContext context) : base(context){ }
    }
}