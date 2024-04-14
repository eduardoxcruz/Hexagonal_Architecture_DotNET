using System.Threading.Tasks;

namespace SeedWork;

public interface IUnitOfWork
{
    ValueTask<int> SaveChanges();
}