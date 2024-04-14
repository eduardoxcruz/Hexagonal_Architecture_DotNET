namespace SeedWork;

public interface IUnitOfWork
{
    ValueTask<int> SaveChanges();
}