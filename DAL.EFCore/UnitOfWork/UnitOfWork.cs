using DAL.EFCore.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.EFCore.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            Departments = new DepartmentRepository(_context);
            Designations = new DesignationRepository(_context);
        }
        public IDesignationRepository Designations { get; private set; }
        public IDepartmentRepository Departments { get; private set; }
        public int Complete()
        {
            return _context.SaveChanges();
        }
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
