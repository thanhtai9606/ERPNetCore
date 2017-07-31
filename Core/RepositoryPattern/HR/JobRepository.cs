using System;
using System.Collections.Generic;
using System.Linq;
using ERPNetCore.Models;

namespace ERPNetCore.Core.RepositoryPattern.HR
{
    public class JobRepository:Repository<JobCandidate>
    {
        public JobRepository(ERPDatabaseContext context) : base(context) { }
    }
}