using Domain.Entities;

using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.EFCore.Repositories
{
    public class DepartmentRepository : GenericRepository<Department>, IDepartmentRepository
{
        public DepartmentRepository(ApplicationDbContext context) : base(context)
        {
        }
        //public IEnumerable<Developer> GetPopularDevelopers(int count)
        //{
        //    return _context.Developers.OrderByDescending(d => d.Followers).Take(count).ToList();
        //}
    }
}
