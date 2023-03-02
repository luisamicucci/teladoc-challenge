using Teladoc.Domain.Entities;

namespace Teladoc.Application.Interfaces
{
    public interface IUserRepository
    {
        Task<bool> Create(User user);
        Task<List<User>> RetrieveAll();
        Task<bool> IsEmailUnique(string email);
    }
}
