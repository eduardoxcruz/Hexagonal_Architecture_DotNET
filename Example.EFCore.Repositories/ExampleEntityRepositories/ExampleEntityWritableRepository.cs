using $ext_safeprojectname$.EFCore.DataContext;
using $ext_safeprojectname$.Repositories;

using $ext_safeprojectname$.Model.Entities;

namespace $ext_safeprojectname$.EFCore.Repositories.ExampleEntityRepositories;

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