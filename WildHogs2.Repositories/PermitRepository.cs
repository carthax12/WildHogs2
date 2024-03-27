using Microsoft.EntityFrameworkCore;

using WildHogs2.Models;
using WildHogs2.Repositories.Promises;

namespace WildHogs2.Repositories
{
    public class PermitRepository : IPermitRepository
    {
        private readonly IDbContextFactory<WildHogsContext> _contextFactory;

        public PermitRepository(IDbContextFactory<WildHogsContext> contextFactory)
        {
            _contextFactory = contextFactory;
        }

        public async Task<List<Permit>> GetPermitsByOwnerId(int ownerId)
        {
            await using var db = await _contextFactory.CreateDbContextAsync();
            var permits = await db.Permits.Where(x => x.Landowner.GetValueOrDefault() == ownerId).ToListAsync();
            return permits;
        }

        public async Task<List<Permit>> GetPermitsByPermitNumber(int permitNumber)
        {
            await using var db = await _contextFactory.CreateDbContextAsync();
            var landowner = db.Permits.FirstOrDefaultAsync(x => x.Exemption == permitNumber).Result?.Landowner;
            var permits = await db.Permits.Where(x => x.Landowner == landowner.GetValueOrDefault()).ToListAsync();
            return permits;
        }

        public async Task<Permit> GetPermitById(int permitId)
        {
            await using var db = await _contextFactory.CreateDbContextAsync();
            var permit = await db.Permits.FirstOrDefaultAsync(x => x.Id == permitId);
            return permit ?? new Permit();
        }

        public async Task<bool> UpsertPermit(Permit permit)
        {
            await using var db = await _contextFactory.CreateDbContextAsync();
            if (permit.Id == 0)
            {
                db.Permits.Add(permit);
            }
            else
            {
                var permitFromDb = await db.Permits.FirstOrDefaultAsync(x => x.Id == permit.Id);
                if (permitFromDb == null)
                    return false;
                permitFromDb = permit;
            }
            return await db.SaveChangesAsync() == 1;
        }
    }
}
