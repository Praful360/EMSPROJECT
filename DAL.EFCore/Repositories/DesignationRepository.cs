using DAL.EFCore;
using DAL.EFCore.Repositories;
using Domain.Entities;

public class DesignationRepository : GenericRepository<Designation>, IDesignationRepository
{
    public DesignationRepository(ApplicationDbContext context) : base(context)
    {
    }
    //public IEnumerable<Developer> GetPopularDevelopers(int count)
    //{
    //    return _context.Developers.OrderByDescending(d => d.Followers).Take(count).ToList();
    //}
}