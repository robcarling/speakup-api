using AutoMapper;
using Speakup.API.Domain.Models;
using Speakup.API.Resources;

namespace Speakup.API.Mapping
{
    public class ResourceToModelProfile : Profile
    {
        public ResourceToModelProfile()
        {
            CreateMap<SaveCommentResource, Comment>();
        }
    }
}