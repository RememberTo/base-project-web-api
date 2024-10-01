using BaseProject.Application.Interfaces;
using BaseProject.Domain.Entities;
using BaseProject.Domain.Interfaces.Database;

namespace BaseProject.Persistence.Repositories;

public class UserRepository(IDbContext applicationDbContext) : IUserRepository
{
    public User GetById(Guid id)
    {
        throw new NotImplementedException();
    }

    public int Create(User entity)
    {
        throw new NotImplementedException();
    }

    public int Update(User entity)
    {
        throw new NotImplementedException();
    }

    public User Delete(Guid id)
    {
        throw new NotImplementedException();
    }
}