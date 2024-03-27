using Microsoft.EntityFrameworkCore;

using WildHogs2.Models;
using WildHogs2.Repositories.Promises;

namespace WildHogs2.Repositories
{
    public class OwnerRepository : IOwnerRepository
    {
        private readonly IDbContextFactory<WildHogsContext> _contextFactory;

        public OwnerRepository(IDbContextFactory<WildHogsContext> contextFactory)
        {
            _contextFactory = contextFactory;
        }

        public async Task<IEnumerable<Owner>> GetAll()
        {
            var db = await _contextFactory.CreateDbContextAsync();
            var owners = await db.Owners.ToListAsync();
            return owners;
        }

        public async Task<Owner> GetById(string id)
        {
            var db = await _contextFactory.CreateDbContextAsync();
            var owner = db.Owners.FirstOrDefault(x => x.LandOwnerId == Convert.ToInt32(id));
            return owner ?? new Owner();
        }

        public async Task<IEnumerable<Owner>> Go(string term)
        {
            var db = await _contextFactory.CreateDbContextAsync();
            var owners = new List<Owner>();
            if (int.TryParse(term, out var result))
            {
                owners = db.Owners.Where(x => x.LandOwnerId == result).ToList();
            }
            else
            {
                owners = db.Owners.Where(x =>
                    x.LnameL!.Contains(term) ||
                    x.FnameL!.Contains(term) ||
                    x.StreetL!.Contains(term) ||
                    x.CountyL!.Contains(term) ||
                    x.CityL!.Contains(term))
                    .ToList();
            }
            return owners;
        }
    }
}
