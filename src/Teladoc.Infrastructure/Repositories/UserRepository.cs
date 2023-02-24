using Teladoc.Domain.Entities;
using Teladoc.Infrastructure.Interfaces;

namespace Teladoc.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        public Task<User> Create(User user)
        {
            throw new NotImplementedException();
        }

        public Task<List<User>> RetrieveAll()
        {
            throw new NotImplementedException();
        }

        public Task<bool> UniqueEmail(string email)
        {
            throw new NotImplementedException();
        }
    }
}
