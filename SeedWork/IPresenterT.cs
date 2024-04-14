namespace SeedWork;

public interface IPresenterT<out T>
{
    public T Content { get; }
}