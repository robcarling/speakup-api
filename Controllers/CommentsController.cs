using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Speakup.API.Domain.Models;
using Speakup.API.Domain.Services;
using Speakup.API.Resources;
using Speakup.API.Extensions;

namespace Speakup.API.Controllers
{
    [Route("/api/[controller]")]
    public class CommentsController : Controller
    {
        private readonly ICommentService _commentService;
        private readonly IMapper _mapper;
        
        public CommentsController(ICommentService commentService, IMapper mapper)
        {
            _commentService = commentService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IEnumerable<CommentResource>> GetAllAsync()
        {
            var comments = await _commentService.ListAsync();
            var resources = _mapper.Map<IEnumerable<Comment>, IEnumerable<CommentResource>>(comments);
            return resources;
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync([FromBody] SaveCommentResource resource)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState.GetErrorMessages());

            var comment = _mapper.Map<SaveCommentResource, Comment>(resource);
            var result = await _commentService.SaveAsync(comment);

            if (!result.Success)
                return BadRequest(result.Message);

            var commentResource = _mapper.Map<Comment, CommentResource>(result.Comment);
            return Ok(commentResource);
        }
    }
}