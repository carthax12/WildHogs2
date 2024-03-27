using WildHogs2.Models;

namespace WildHogs2.Repositories.Promises
{
    public interface IOwnerRepository
    {
        Task<IEnumerable<Owner>> Go(string term);
        Task<IEnumerable<Owner>> GetAll();
        Task<Owner> GetById(string id);
    }
}
