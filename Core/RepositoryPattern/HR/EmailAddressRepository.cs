using System;
using System.Collections.Generic;
using System.Linq;
using ERPNetCore.Models;

namespace ERPNetCore.Core.RepositoryPattern.HR
{
    public class EmailAddressRepository : Repository<EmailAddress>
    {
        public EmailAddressRepository(ERPDatabaseContext context) : base(context) { }
    }
}