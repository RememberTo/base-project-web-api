using BaseProject.Domain.Entities;

namespace BaseProject.Domain.Interfaces.Database;

public interface IUserRepository : IRepository<User, Guid>
{
}