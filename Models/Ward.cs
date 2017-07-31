using System;
using System.Collections.Generic;

namespace ERPNetCore.Models
{
    public partial class Ward
    {
        public string WardId { get; set; }
        public string WardName { get; set; }
        public string EnglishName { get; set; }
        public string Level { get; set; }
        public string DistrictId { get; set; }

        public virtual District District { get; set; }
    }
}
