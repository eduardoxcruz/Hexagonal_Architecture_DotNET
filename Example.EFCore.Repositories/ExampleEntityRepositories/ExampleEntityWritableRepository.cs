using Example.EFCore.DataContext;
using Example.Repositories;

using Model.Entities;

namespace Example.EFCore.Repositories.ExampleEntityRepositories;

public class ExampleEntityWritableRepository : IExampleEntityWritableRepo
{
    private readonly ExampleDbContext _dbContext;

    public ExampleEntityWritableRepository(ExampleDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public ValueTask<string> Create(ExampleEntity obj)
    {
        string hello = "Hello world";

        return ValueTask.FromResult(hello);
    }

    public ValueTask<string> Update(ExampleEntity obj)
    {
        throw new NotImplementedException();
    }
}