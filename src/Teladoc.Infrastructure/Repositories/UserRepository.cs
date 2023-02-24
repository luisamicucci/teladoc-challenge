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

        public async Task<bool> Create(User user)
        {
            user.Id = Guid.NewGuid();
            await _dbContext.AddAsync(user);
            
            return await _dbContext.SaveChangesAsync() > 0;
        }

        public async Task<List<User>> RetrieveAll()
        {
            return _dbContext.Users.ToList();
        }

        public async Task<bool> IsEmailUnique(string email)
        {
            return !_dbContext.Users.Any(usr => usr.Email == email);
        }
    }
}
