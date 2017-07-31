using System;
using System.Collections.Generic;

namespace ERPNetCore.Models
{
    public partial class GlobalValue
    {
        public int ControlId { get; set; }
        public string ControlName { get; set; }
        public string Vn { get; set; }
        public string Eng { get; set; }
        public string Description { get; set; }
    }
}
