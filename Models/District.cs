using System;
using System.Collections.Generic;

namespace ERPNetCore.Models
{
    public partial class District
    {
        public District()
        {
            Ward = new HashSet<Ward>();
        }

        public string DistrictId { get; set; }
        public string DistrictName { get; set; }
        public string EnglishName { get; set; }
        public string Level { get; set; }
        public string ProvinceId { get; set; }

        public virtual ICollection<Ward> Ward { get; set; }
        public virtual Province Province { get; set; }
    }
}
