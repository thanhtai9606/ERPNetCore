using System;
using System.Collections.Generic;

namespace ERPNetCore.Models
{
    public partial class Catalog
    {
        public Catalog()
        {
            Category = new HashSet<Category>();
        }

        public int CatalogId { get; set; }
        public string CatalogName { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual ICollection<Category> Category { get; set; }
    }
}
