using Model.Entities;

using SeedWork;

namespace Example.Repositories;

public interface IExampleEntityWritableRepo : IWritableRepository<string, ExampleEntity>
{
}