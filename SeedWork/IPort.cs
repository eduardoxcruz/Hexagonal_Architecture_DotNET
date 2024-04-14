using System.Threading.Tasks;

namespace SeedWork;

public interface IPort
{
    ValueTask Handle();
}