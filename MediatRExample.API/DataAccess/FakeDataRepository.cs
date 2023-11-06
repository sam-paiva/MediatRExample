using MediatRExample.API.Models;

namespace MediatRExample.API.DataAccess
{
    public class FakeDataRepository
    {
        private readonly List<Post> _posts;

        public FakeDataRepository()
        {
            _posts = new List<Post>();
        }

        public void SavePost(Post post) => _posts.Add(post);

        public IEnumerable<Post> GetPosts() => _posts;
    }
}
