using System;
using System.Threading.Tasks;

namespace $ext_safeprojectname$.EFCore.Repositories.ExampleEntityRepositories;

public class ExampleEntityWritableRepository: IExampleEntityWritableRepo
{
    private readonly ExampleDbContext _dbContext;

    public ExampleEntityWritableRepository(ExampleDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public ValueTask<string> Create(ExampleEntity obj)
    {
        throw new NotImplementedException();
    }

    public ValueTask<string> Update(ExampleEntity obj)
    {
        throw new NotImplementedException();
    }
}