using $ext_safeprojectname$.Model.Entities;

using SeedWork;

namespace $ext_safeprojectname$.Repositories;

public interface IExampleEntityWritableRepo : IWritableRepository<string, ExampleEntity>
{
}