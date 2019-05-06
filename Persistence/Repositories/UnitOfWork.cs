using System.Threading.Tasks;
using Speakup.API.Domain.Repositories;
using Speakup.API.Persistence.Contexts;

namespace Speakup.API.Persistence.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;

        public UnitOfWork(AppDbContext context)
        {
            _context = context;     
        }

        public async Task CompleteAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}