using System;
using System.Collections.Generic;

namespace ERPNetCore.Models
{
    public partial class TimerType
    {
        public int TimerTypeId { get; set; }
        public string Name { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
