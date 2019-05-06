using System.Collections.Generic;
using System.Threading.Tasks;
using Speakup.API.Domain.Models;

namespace Speakup.API.Domain.Repositories
{
    public interface ICommentRepository
    {
        Task<IEnumerable<Comment>> ListAsync();
        Task AddAsync(Comment comment);
    }
}