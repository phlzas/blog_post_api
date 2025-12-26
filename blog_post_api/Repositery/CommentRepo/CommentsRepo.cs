using blog_post_api.Data;
using blog_post_api.Data.Models;
using blog_post_api.Repositery.Genric;

namespace blog_post_api.Repositery.CommentRepo
{
    public class CommentsRepo : GenricRepo<Comments>, ICommentsRepo
    {
        public CommentsRepo(AppDbContext context) : base(context)
        {
        }

    }
}
