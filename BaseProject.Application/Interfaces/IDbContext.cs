namespace BaseProject.Application.Interfaces
{
    public interface IDbContext
    {
        //DbSet<>.........
        
        int SaveChanges(); 
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
