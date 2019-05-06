using AutoMapper;
using Speakup.API.Domain.Models;
using Speakup.API.Resources;

namespace Speakup.API.Mapping
{
    public class ModelToResourceProfile : Profile
    {
        public ModelToResourceProfile()
        {
            CreateMap<Comment, CommentResource>();
        }
    }
}