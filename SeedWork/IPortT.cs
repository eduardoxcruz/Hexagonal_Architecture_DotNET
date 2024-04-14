namespace SeedWork;

public interface IPort<in T>
{
    ValueTask Handle(T dto);
}