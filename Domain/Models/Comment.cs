using System.Collections.Generic;

namespace Speakup.API.Domain.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CommentBody { get; set; }
    }
}