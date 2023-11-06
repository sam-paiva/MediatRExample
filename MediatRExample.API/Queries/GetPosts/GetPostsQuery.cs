using MediatR;
using MediatRExample.API.Models;

namespace MediatRExample.API.Queries.GetPosts
{
    public record GetPostsQuery : IRequest<IEnumerable<Post>>;
}
