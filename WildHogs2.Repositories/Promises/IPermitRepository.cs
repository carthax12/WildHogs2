using WildHogs2.Models;

namespace WildHogs2.Repositories.Promises
{
    public interface IPermitRepository
    {
        Task<List<Permit>> GetPermitsByOwnerId(int ownerId);
        Task<List<Permit>> GetPermitsByPermitNumber(int permitNumber);
        Task<Permit> GetPermitById(int permitId);
        Task<bool> UpsertPermit(Permit permit);
    }
}
