
using ERPNetCore.Core.RepositoryPattern;
using System;
using ERPNetCore.Models;
using ERPNetCore.Core.RepositoryPattern.Multimedia;
using ERPNetCore.Core.RepositoryPattern.BusinessEntities;
using ERPNetCore.Core.RepositoryPattern.Globalization;
using ERPNetCore.Core.RepositoryPattern.GrantPermissionAdmin;
using ERPNetCore.Core.RepositoryPattern.HR;

namespace ERPNetCore.Core
{
    public class UnitOfWork : IUnitOfWork
    {
        private ERPDatabaseContext _context;
        public MultimediaRepository MultimediaRepository { set; get; }
        public BusinessEntityRepository BusinessEntityRepository { set; get; }
        public CultureRepository CultureRepository { set; get; }
        public GrantPermissionAdmin GrantPermissionAdmin { set; get; }
        public HRRepository HRRepository { set; get; }
        public UnitOfWork(ERPDatabaseContext context)
        {
            this._context = context;
            MultimediaRepository = new MultimediaRepository(context);
            BusinessEntityRepository = new BusinessEntityRepository(context);
            CultureRepository = new CultureRepository(context);
            GrantPermissionAdmin = new GrantPermissionAdmin(context);
            HRRepository = new HRRepository(context);
        }
        public int Complete()
        {
            return _context.SaveChanges();
        }

        /// <summary>
        /// Disposes the current object
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// Disposes all external resources.
        /// </summary>
        /// <param name="disposing">The dispose indicator.</param>
        private void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (_context != null)
                {
                    _context.Dispose();
                    _context = null;
                }
            }
        }
    }
}