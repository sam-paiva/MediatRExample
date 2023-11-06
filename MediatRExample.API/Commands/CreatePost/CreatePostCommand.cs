using MediatR;
using MediatRExample.API.Models;

namespace MediatRExample.API.Commands.CreatePost
{
    public record CreatePostCommand : IRequest<Post>
    {
        public string? Title { get; set; }
        public string? Content { get; set; }
    }
}
