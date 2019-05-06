using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Speakup.API.Domain.Models;
using Speakup.API.Domain.Repositories;
using Speakup.API.Persistence.Contexts;

namespace Speakup.API.Persistence.Repositories
{
    public class CommentRepository : BaseRepository, ICommentRepository
    {
        public CommentRepository(AppDbContext context) : base(context)
        { }

        public async Task<IEnumerable<Comment>> ListAsync()
        {
            return await _context.Comments.ToListAsync();
        }
    
        public async Task AddAsync(Comment comment)
        {
            await _context.Comments.AddAsync(comment);
        }
    }
}