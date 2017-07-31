using System;
using System.Collections.Generic;

namespace ERPNetCore.Models
{
    public partial class Item
    {
        public int ItemId { get; set; }
        public string Title { get; set; }
        public string Detail { get; set; }
        public string Src { get; set; }
        public int? Rating { get; set; }
        public int? View { get; set; }
        public string PostedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? CategoryId { get; set; }

        public virtual Category Category { get; set; }
    }
}
