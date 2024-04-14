using System.Threading.Tasks;

namespace SeedWork;

public interface IWritableRepository<TReturn, in TParam>
{
    ValueTask<TReturn> Create(TParam obj);
    ValueTask<TReturn> Update(TParam obj);
}