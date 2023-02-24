using Teladoc.Domain;
using Teladoc.Domain.Entities;
using Teladoc.Infrastructure.Interfaces;

namespace Teladoc.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly TeladocApiContext _dbContext;

        public UserRepository(TeladocApiContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<User> Create(User user)
        {
            var usr = await _dbContext.AddAsync(user);
            await _dbContext.SaveChangesAsync();
            return usr.Entity;
        }

        public async Task<List<User>> RetrieveAll()
        {
            return _dbContext.Users.ToList();
        }

        public async Task<bool> UniqueEmail(string email)
        {
            return !_dbContext.Users.Any(usr => usr.Email == email);
        }
    }
}
