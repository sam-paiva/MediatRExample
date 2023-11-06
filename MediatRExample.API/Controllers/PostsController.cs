using MediatR;
using MediatRExample.API.Commands.CreatePost;
using MediatRExample.API.Queries.GetPosts;
using Microsoft.AspNetCore.Mvc;

namespace MediatRExample.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostsController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly ILogger<PostsController> _logger;

        public PostsController(IMediator mediator, ILogger<PostsController> logger)
        {
            _mediator = mediator;
            _logger = logger;
        }

        [HttpPost]
        public async Task<IActionResult> CreatePost(CreatePostCommand command, CancellationToken cancellationToken)
        {
            try
            {
                var post = await _mediator.Send(command, cancellationToken);
                return CreatedAtAction(nameof(CreatePost), post);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Failed to create new post");
                return StatusCode(500);
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetPosts(CancellationToken cancellationToken)
        {
            try
            {
                var posts = await _mediator.Send(new GetPostsQuery(), cancellationToken);
                return Ok(posts);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Failed to retrieve posts");
                return StatusCode(500);
            }
        }
    }
}
