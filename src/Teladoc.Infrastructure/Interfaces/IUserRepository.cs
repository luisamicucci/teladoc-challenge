using Teladoc.Domain.Entities;

namespace Teladoc.Infrastructure.Interfaces
{
    public interface IUserRepository
    {
        Task<bool> Create(User user);
        Task<List<User>> RetrieveAll();
        Task<bool> IsEmailUnique(string email);
    }
}
