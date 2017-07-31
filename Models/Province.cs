using System;
using System.Collections.Generic;

namespace ERPNetCore.Models
{
    public partial class Province
    {
        public Province()
        {
            District = new HashSet<District>();
        }

        public string ProvinceId { get; set; }
        public string ProvinceName { get; set; }
        public string EnglishName { get; set; }
        public string Level { get; set; }

        public virtual ICollection<District> District { get; set; }
    }
}
