using Teladoc.Domain.Entities;

namespace Teladoc.Infrastructure.Interfaces
{
    public interface IUserRepository
    {
        Task<User> Create(User user);
        Task<List<User>> RetrieveAll();
        Task<bool> UniqueEmail(string email);
    }
}
