namespace BaseProject.Domain.Interfaces.Database;

public interface IUnitOfWork : IDisposable
{
    IUserRepository Users { get; }
    int Complete();
}