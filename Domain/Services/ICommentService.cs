using System.Collections.Generic;
using System.Threading.Tasks;
using Speakup.API.Domain.Models;
using Speakup.API.Domain.Services.Communication;

namespace Speakup.API.Domain.Services
{
    public interface ICommentService
    {
         Task<IEnumerable<Comment>> ListAsync();
         Task<SaveCommentResponse> SaveAsync(Comment comment);
    }
}