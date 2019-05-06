using Speakup.API.Domain.Models;

namespace Speakup.API.Domain.Services.Communication
{
    public class SaveCommentResponse : BaseResponse
    {
        public Comment Comment { get; private set; }

        private SaveCommentResponse(bool success, string message, Comment comment) : base(success, message)
        {
            Comment = comment;
        }

        /// <summary>
        /// Creates a success response.
        /// </summary>
        /// <param name="comment">Saved comment.</param>
        /// <returns>Response.</returns>
        public SaveCommentResponse(Comment comment) : this(true, string.Empty, comment)
        { }

        /// <summary>
        /// Creates an error response.
        /// </summary>
        /// <param name="message">Error message.</param>
        /// <returns>Response.</returns>
        public SaveCommentResponse(string message) : this(false, message, null)
        { }
    }
}