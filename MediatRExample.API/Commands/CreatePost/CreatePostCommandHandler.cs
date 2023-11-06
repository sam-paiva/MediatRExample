using MediatR;
using MediatRExample.API.DataAccess;
using MediatRExample.API.Models;

namespace MediatRExample.API.Commands.CreatePost
{
    public class CreatePostCommandHandler : IRequestHandler<CreatePostCommand, Post>
    {
        private readonly FakeDataRepository _repository;

        public CreatePostCommandHandler(FakeDataRepository repository)
        {
            _repository = repository;
        }

        public Task<Post> Handle(CreatePostCommand request, CancellationToken cancellationToken)
        {
            var post = new Post(request.Title!, request.Content!);

            _repository.SavePost(post);

            return Task.FromResult(post);
        }
    }
}
