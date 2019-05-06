using System.ComponentModel.DataAnnotations;

namespace Speakup.API.Resources
{
    public class SaveCommentResource
    {
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
        public string CommentBody { get; set; }
    }
}