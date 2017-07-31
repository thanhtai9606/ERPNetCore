﻿
using System;
using System.Collections.Generic;
using System.Linq;
using ERPNetCore.Models;

namespace ERPNetCore.Core.RepositoryPattern.HR
{
    public class HRRepository
    {
        public DepartmentRepository DepartmentHistoryRepository { set; get; }
        public EmployeeDepartmentRepository EmployeeDepartmentRepository { set; get; }
        public EmployeeRepository EmployeeRepository { set; get; }
        public JobRepository JobCandidateRepository { set; get; }
        public PasswordRepository PasswordRepository { set; get; }
        public PersonRepository PersonRepository { set; get; }
        public EmailAddressRepository EmailAddressRepository { set; get; }
        public HRRepository( ERPDatabaseContext context)
        {
            DepartmentHistoryRepository = new DepartmentRepository(context);
            EmployeeRepository = new EmployeeRepository(context);
            EmployeeDepartmentRepository = new EmployeeDepartmentRepository(context);
            JobCandidateRepository = new JobRepository(context);
            PasswordRepository = new PasswordRepository(context);
            PersonRepository = new PersonRepository(context);
            EmailAddressRepository = new EmailAddressRepository(context);
        }

    }
}