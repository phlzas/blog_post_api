using blog_post_api.Data;
using blog_post_api.Data.Models;
using blog_post_api.Repositery.Genric;

namespace blog_post_api.Repositery.CommentReactionRepo
{
    public class CommentReactionsRepo : GenricRepo<CommentReaction>, ICommentReactionRepo
    {
        public CommentReactionsRepo(AppDbContext context) : base(context)
        {
        }
    }
}
