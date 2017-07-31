﻿
using System;
using System.Collections.Generic;
using System.Linq;
using ERPNetCore.Models;

namespace ERPNetCore.Core.RepositoryPattern.GrantPermissionAdmin
{
    public class BusinessRepository : Repository<Business>
    {
        public BusinessRepository(ERPDatabaseContext context) : base(context) { }
    }
}