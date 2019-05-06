using System.Threading.Tasks;

namespace Speakup.API.Domain.Repositories
{
    public interface IUnitOfWork
    {
         Task CompleteAsync();
    }
}