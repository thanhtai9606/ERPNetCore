using System;
using System.Collections.Generic;

namespace ERPNetCore.Models
{
    public partial class Employee
    {
        public Employee()
        {
            EmployeeDepartmentHistory = new HashSet<EmployeeDepartmentHistory>();
            GrantPermission = new HashSet<GrantPermission>();
            JobCandidate = new HashSet<JobCandidate>();
        }

        public int BusinessEntityId { get; set; }
        public string NationalIdnumber { get; set; }
        public string EmpCode { get; set; }
        public short? OrganizationLevel { get; set; }
        public string Level { get; set; }
        public string JobTitle { get; set; }
        public string Position { get; set; }
        public DateTime BirthDate { get; set; }
        public string MaritalStatus { get; set; }
        public string Gender { get; set; }
        public DateTime HireDate { get; set; }
        public DateTime? LeaveDate { get; set; }
        public Guid Rowguid { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string Avatar { get; set; }

        public virtual ICollection<EmployeeDepartmentHistory> EmployeeDepartmentHistory { get; set; }
        public virtual ICollection<GrantPermission> GrantPermission { get; set; }
        public virtual ICollection<JobCandidate> JobCandidate { get; set; }
        public virtual Person BusinessEntity { get; set; }
    }
}
