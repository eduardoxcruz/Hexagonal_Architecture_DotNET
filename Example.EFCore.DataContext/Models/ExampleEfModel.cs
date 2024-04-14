using Model.Entities;

namespace Example.EFCore.DataContext.Models;

public class ExampleEfModel : ExampleEntity
{
    public ExampleEfModel(string name) : base(name)
    {
    }
}