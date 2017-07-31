using System;
using System.Collections.Generic;

namespace ERPNetCore.Models
{
    public partial class Category
    {
        public Category()
        {
            Item = new HashSet<Item>();
        }

        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? CatalogId { get; set; }

        public virtual ICollection<Item> Item { get; set; }
        public virtual Catalog Catalog { get; set; }
    }
}
