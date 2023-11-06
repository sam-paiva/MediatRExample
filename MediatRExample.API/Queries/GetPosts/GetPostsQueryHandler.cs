using MediatR;
using MediatRExample.API.DataAccess;
using MediatRExample.API.Models;

namespace MediatRExample.API.Queries.GetPosts
{
    public class GetPostsQueryHandler : IRequestHandler<GetPostsQuery, IEnumerable<Post>>
    {
        private readonly FakeDataRepository _repository;

        public GetPostsQueryHandler(FakeDataRepository repository)
        {
            _repository = repository;
        }

        public Task<IEnumerable<Post>> Handle(GetPostsQuery request, CancellationToken cancellationToken)
         => Task.FromResult(_repository.GetPosts());
    }
}
