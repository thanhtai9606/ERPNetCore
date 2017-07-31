using ERPNetCore.Models;

namespace ERPNetCore.Core.RepositoryPattern.Multimedia
{
    public class MultimediaRepository
    {
        private ERPDatabaseContext _context;
        public CatalogRepository  CatalogRepository { set; get;}
        public CategoryRepository CategoryRepository { set; get;}
        public ItemRepository ItemRepository { set; get;}

        public MultimediaRepository( ERPDatabaseContext context)
        {
            this._context = context;
            CatalogRepository = new CatalogRepository(context);
            CategoryRepository = new CategoryRepository(context);
            ItemRepository = new ItemRepository(context);
        }
    }
}